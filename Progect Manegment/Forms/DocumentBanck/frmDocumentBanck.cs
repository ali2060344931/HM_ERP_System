using HM_ERP_System.Forms.Main_Form;
using MyClass;
using Progect_Manegment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.DocumentBanck
{
    public partial class frmDocumentBanck : frmMasterForm
    {
        private DBcontextModel db = new DBcontextModel();
        public int IDLIST = 0;
        public string FormName;
        public int ListInFoemId;
        public int Id_Project = 0;
        public DataTable dtDocumentBancks;
        string sFileName = "";
        long nLength = 0;
        byte[] barFile = null;
        string NameDocument;

        public frmDocumentBanck()
        {
            InitializeComponent();
        }

        private void frmDocumentBanck_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + @"\data_Files"))
                Directory.CreateDirectory(Application.StartupPath + @"\data_Files");

            lblZarfiyatMojaz.Text = "2000";

            ShowInfoToDGV(dtDocumentBancks);

            AddcmbOnovanFile();
        }

        private void FilltxtMoZoFile()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    txtMoZoFile.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtMoZoFile.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection ac = new AutoCompleteStringCollection();

                    var q = db.DocumentBancks.ToList();
                    foreach (var c in q)
                    {
                        ac.Add(c.MoZoFile);
                    }
                    txtMoZoFile.AutoCompleteCustomSource = ac;
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void AddcmbOnovanFile()
        {
            var Q = db.DocumentBancks.Select(c => c.File_Title).Distinct();
            cmbOnovanFile.DataSource = Q.ToList();
            cmbOnovanFile.DisplayMember = "File_Title";
            cmbOnovanFile.SelectedIndex = -1;
        }

        void ShowInfoToDGV(DataTable dt)
        {
            try
            {
                if (dt != null)
                {
                    dgwList.DataSource = dt;
                }
                else
                {
                    var q = from r in db.DocumentBancks
                            where r.FormName == FormName && r.ListInFoemId == ListInFoemId && (r.MoZoFile.Contains(txtSearch.Text) || r.File_Title.Contains(txtSearch.Text) || r.FileName.Contains(txtSearch.Text))
                            orderby r.MoZoFile
                            select new
                            {
                                r.Id,
                                r.MoZoFile,
                                r.File_Title,
                                r.FileName,
                                LengthFile = r.LengthFile / 1000
                            };
                    dgwList.DataSource = q.ToList();
                    dgwList.AutoSizeColumns();
                    FilltxtMoZoFile();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                if (IDLIST == 0)
                {
                    if (PublicClass.FindEmptyControls(txtAdresFile, ResourceCode.T048, txtMoZoFile, ResourceCode.T049, cmbOnovanFile, ResourceCode.T050)) return;

                    if (Convert.ToInt32(lblHajmFile.Text) > Convert.ToInt32(lblZarfiyatMojaz.Text))
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T051);
                        return;
                    }

                }
                else
                {
                    if (PublicClass.FindEmptyControls(txtMoZoFile, ResourceCode.T049, cmbOnovanFile, ResourceCode.T050)) return;
                }

                if (IDLIST == 0)

                {//ثبت

                    byte[] file_binary = File.ReadAllBytes(txtAdresFile.Text);
                    Entity.DocumentBanck.DocumentBanck DB = new Entity.DocumentBanck.DocumentBanck();
                    DB.MoZoFile = txtMoZoFile.Text;
                    DB.FormName = FormName;
                    DB.ListInFoemId = ListInFoemId;
                    DB.FileName = sFileName;
                    DB.File_Title = cmbOnovanFile.Text;
                    DB.LengthFile = nLength;
                    DB.Data = file_binary;
                    db.DocumentBancks.Add(DB);
                    db.SaveChanges();
                }
                else
                {//ویرایش
                    var q = db.DocumentBancks.Where(c => c.Id == ListId).First();

                    if (txtAdresFile.Text != "")
                    {
                        byte[] file_binary = System.IO.File.ReadAllBytes(txtAdresFile.Text);
                        q.Data = file_binary;
                        q.FileName = sFileName;
                        q.LengthFile = nLength;
                    }

                    q.MoZoFile = txtMoZoFile.Text;
                    q.File_Title = cmbOnovanFile.Text;
                    db.SaveChanges();

                }

                PublicClass.WindowAlart("1");
                CelereItems();
                ShowInfoToDGV(dtDocumentBancks);
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void CelereItems()
        {
            txtMoZoFile.ResetText();
            cmbOnovanFile.ResetText();
            txtAdresFile.ResetText();
            lblHajmFile.ResetText();
            btnChoisFileNew.Enabled = true;
            txtAdresFile.Enabled = true;
            IDLIST = 0;
            AddcmbOnovanFile();
            btnChoisFileNew.Focus();
        }

        private void mtdReadWriteStream(System.IO.MemoryStream readStream, System.IO.FileStream writeStream, int Length)
        {
            try
            {
                Byte[] buffer = new Byte[Length];
                int bytesRead = readStream.Read(buffer, 0, Length);
                {
                    writeStream.Write(buffer, 0, bytesRead);
                    bytesRead = readStream.Read(buffer, 0, Length);
                }
                readStream.Close();
                writeStream.Close();

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnChoisFileNew_Click(object sender, EventArgs e)
        {
            //-----
            try
            {
                openFileDialog1.Multiselect = false;//جهت انتخاب تنها یک فایل
                openFileDialog1.AddExtension = false;
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = true;
                openFileDialog1.Title = "فایل مورد نظر را انتخاب نمائید";
                //openFileDialog1.InitialDirectory;

                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                    sFileName = fileInfo.Name;
                    nLength = fs.Length;
                    lblHajmFile.Text = (nLength / 1024).ToString();
                    cmbOnovanFile.Text = Path.GetExtension(fileInfo.Name).Replace(".", "");
                    barFile = new byte[fs.Length];
                    fs.Read(barFile, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                    txtAdresFile.Text = openFileDialog1.FileName;
                    txtMoZoFile.Focus();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        int ListId = 0;

        private void dgwList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                ListId = Convert.ToInt32(dgwList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "ShowFile")
                {

                    try
                    {
                        string fn = "";
                        var q = db.DocumentBancks.Where(c => c.Id == ListId).First();
                        MemoryStream ms = new MemoryStream((Byte[])q.Data);
                        fn = Application.StartupPath + @"\data_Files\" + q.FileName;
                        int FileLength = (int)q.LengthFile;
                        FileStream writeStream = new FileStream(fn, FileMode.Create, FileAccess.Write);
                        mtdReadWriteStream(ms, writeStream, FileLength);
                        System.Diagnostics.Process.Start(fn);

                    }
                    catch (Exception er)
                    {
                        PublicClass.ShowErrorMessage(er);
                    }

                }
                else if (e.Column.Key == "Download")
                {
                    try
                    {
                        var q = db.DocumentBancks.Where(c => c.Id == ListId).First();
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        MemoryStream ms = new MemoryStream((Byte[])q.Data);

                        saveFileDialog1.FileName = q.FileName;

                        int FileLength = (int)q.LengthFile;
                        //set default value
                        string sSaveLocation = @"C:\DVPRU";
                        saveFileDialog1.ShowDialog();
                        sSaveLocation = saveFileDialog1.FileName.ToString();
                        // create a write stream
                        FileStream writeStream = new FileStream(sSaveLocation, FileMode.Create, FileAccess.Write);
                        // write to the stream
                        mtdReadWriteStream(ms, writeStream, FileLength);

                        if (MessageBox.Show("فایل در مسیر تعیین شده با موفقیت ذخیره شده" + '\n' + "آیا فایل مورد نظر نمایش داده شود", ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.No) return;

                        System.Diagnostics.Process.Start(sSaveLocation);
                    }
                    catch (Exception er)
                    {
                        PublicClass.ShowErrorMessage(er);
                    }
                }
                else if (e.Column.Key == "Delete")
                {
                    try
                    {
                        if (ListId == 0)
                            return;

                        if (MessageBox.Show("آیا فایل مورد نظر حذف گردد" + '\n' + "نام/عنوان فایل: " + NameDocument, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.No) return;

                        var q = db.DocumentBancks.Where(c => c.Id == ListId).First();
                        db.DocumentBancks.Remove(q);
                        db.SaveChanges();
                        PublicClass.WindowAlart("2");
                        ShowInfoToDGV(dtDocumentBancks);

                    }
                    catch (Exception er)
                    {
                        PublicClass.ShowErrorMessage(er);
                    }
                }
                else if (e.Column.Key == "Edit")
                {
                    try
                    {
                        btnChoisFileNew.Enabled = false;
                        txtAdresFile.Enabled = false;

                        var q = db.DocumentBancks.Where(c => c.Id == ListId).First();
                        txtMoZoFile.Text = q.MoZoFile;
                        cmbOnovanFile.Text = q.File_Title;
                        IDLIST = ListId;

                    }
                    catch (Exception er)
                    {
                        PublicClass.ShowErrorMessage(er);
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void txtAdresFile_Click(object sender, EventArgs e)
        {
            btnChoisFileNew_Click(null, null);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelereItems();
        }

        private void frmDocumentBanck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
            //            if (e.Control && e.KeyCode == Keys.F12) { UpdateData();PublicClass.WindowAlart("1", ResourceCode.T161); }
        }
    }
}

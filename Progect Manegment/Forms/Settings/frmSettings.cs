using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.TruckUsageType;
using HM_ERP_System.Forms.Main_Form;

using MyClass;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Settings
{
    public partial class frmSettings : frmMasterForm, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;

        public frmSettings(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Maximized;
            CallUpdateTata();
        }
        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void CallUpdateTata()
        {
            txtSetDayToReportList.Value=Properties.Settings.Default.SetDayToReportList;
            chkShowAccountBalance.Checked=Properties.Settings.Default.StatusShowAccountBalance;
            //Todo: دستور نمایش عکس ها
            DataTable onRec = new DataTable();
            onRec = MyClass.Manage_Photos.Read_TableFromBank_InsertToDataTable("SELECT * FROM ImageCoes where id=1");
            picLogo.Image = MyClass.Manage_Photos.GetImageFromeFieldValues(onRec.Rows[0]["Image"]);

        }

        int ListId = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                return;

            Properties.Settings.Default.SetDayToReportList=txtSetDayToReportList.Value;
            Properties.Settings.Default.StatusShowAccountBalance=chkShowAccountBalance.Checked;

            using (var db = new DBcontextModel())
            {
                ////ذخیره کردن تصویر
                //if (db.ImageCos.Count()==0)
                //    //جدید
                //    MyClass.SqlBankClass.InsertWithPicture("ImageCoes", picLogo.Image, "11");
                //else
                //    //ویرایش
                //    MyClass.SqlBankClass.UpdateWithPicture("ImageCoes", "Image", picLogo.Image, new string[] { "Name" }, new string[] { "12" }, "Id=1");



                var q = db.ImageCos.Count();
                if (q==0)
                    ListId=0;
                else
                    ListId=1;
                System.Drawing.Image picture = picLogo.Image;
                byte[] arrpic = null;
                System.IO.MemoryStream mp = new System.IO.MemoryStream();
                picture.Save(mp, picture.RawFormat);
                arrpic = mp.GetBuffer();

                var car = new Repository<Entity.ImageCo.ImageCo>(db);
                car.SaveOrUpdate(new Entity.ImageCo.ImageCo { Id = ListId,Name="Pic",Image= arrpic }, ListId);
            }

                Properties.Settings.Default.Save();
            PublicClass.WindowAlart("1");
            if (_updatableForms!=null)
                _updatableForms.UpdateData();


        }

        private void frmSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_ = new OpenFileDialog();
            openFileDialog_.FileName = "";
            openFileDialog_.Filter = "jpeg Files(*.jpg)|*.jpg|png Files(*.png)|*.png|Bitmap Filse(*.bmp)|*.bmp|Tif Filse(*.tif)|*.tif";
            DialogResult d = openFileDialog_.ShowDialog();
            if (openFileDialog_.FileName != "" && d != DialogResult.Cancel)
                picLogo.Image = Image.FromFile(openFileDialog_.FileName);

        }
    }
}

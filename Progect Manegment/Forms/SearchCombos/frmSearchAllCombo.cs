using HM_ERP_System.Forms.Main_Form;

using Janus.Windows.GridEX;

using MyClass;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.SearchCombos
{
    public partial class frmSearchAllCombo : Form// frmMasterForm
    {
        public DataTable dt;
        public string ColItems = "";
        public int ColumnsCount = 0;
        public string TypeControl = "";
        string Key_ = "";

        public frmSearchAllCombo()
        {
            InitializeComponent();
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        const int CS_NOCLOSE = 0x200;

        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= CS_NOCLOSE;
        //        return cp;
        //    }
        //}

        private void frmSearchAllCombo_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            DataTable dtSub = new DataTable();
            dtSub.Columns.Add("Key", typeof(string));
            dtSub.Columns.Add("Name", typeof(string));
            PublicClass.Id_ = 0;
            string[] txt = ColItems.Split(',');

            for (int i = 0; i < ColumnsCount; i++)
            {
                GridEXColumn column = new GridEXColumn(txt[i * 5]);
                grList.RootTable.Columns.Add(column);

                grList.RootTable.Columns[i + 1].Key = txt[i * 5];
                grList.RootTable.Columns[i + 1].Caption = txt[i * 5 + 1];
                grList.RootTable.Columns[i + 1].DataMember = txt[i * 5 + 2];
                grList.RootTable.Columns[i + 1].Visible = Convert.ToBoolean(txt[i * 5 + 3]);
                grList.RootTable.Columns[i + 1].Width = Convert.ToInt32(txt[i * 5 + 4]);
                grList.RootTable.Columns[i + 1].FilterRowComparison =ConditionOperator.Contains;
                grList.RootTable.Columns[i + 1].CellStyle.TextAlignment= TextAlignment.Center;
                grList.RootTable.Columns[i + 1].HeaderStyle.TextAlignment= TextAlignment.Center;
                grList.RootTable.Columns[i + 1].FilterEditType = FilterEditType.Combo;
                //grList.RootTable.Columns[i + 1].Tag = txt[i * 5 + 5];
                if (Convert.ToBoolean(txt[i * 5 + 3]))
                {
                    DataRow newRow = dtSub.NewRow();
                    newRow["Key"] = txt[i * 5];
                    newRow["Name"] = txt[i * 5 + 1];
                    dtSub.Rows.Add(newRow);
                }
            }
            grList.DataSource = dt;
            //PublicClass.SettingGridEX(grList);
            cmbSub.DataSource = dtSub;
            cmbSub.DisplayMember = "Name";
            cmbSub.ValueMember = "Key";
            cmbSub.SelectedIndex = 0;
            txtSub.Focus();
        }

        private void txtSub_ButtonCustomClick(object sender, EventArgs e)
        {
            var filteredRows = from row in dt.AsEnumerable()
                               where row.Field<object>(Key_).ToString().Contains(txtSub.Text.ToString())
                               select row;
            DataTable newTable = new DataTable();
            newTable = dt.Clone();
            if (filteredRows.Count() > 0)
            {
                newTable = filteredRows.CopyToDataTable();
                grList.DataSource = newTable;
            }
            else
                grList.DataSource = null;
        }

        private void txtSub_ButtonCustom2Click(object sender, EventArgs e)
        {
            grList.DataSource = dt;
        }

        private void cmbSub_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Key_ = cmbSub.Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        int id = 0;
        string  text = "";
        private void grList_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {

            if (e.Column.Key == "Select")
            {
                if (TypeControl == "mcc")
                {
                    id = Convert.ToInt32(grList.GetRow().Cells["Id"].Value);
                    PublicClass.Id_ = id;
                }
                else if (TypeControl == "ccb")
                {
                    text = grList.GetRow().Cells["Name"].Value.ToString();

                    PublicClass.text_ = text;
                }
                    this.Close();
            }
        }

        private void txtSub_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.Enter)
                txtSub_ButtonCustomClick(null, null);
        }

        private void grList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Insert)
            {
                //int id=Convert.ToInt32( (grList.GetRow().Cells["id"].Value.ToString()));
                id = Convert.ToInt32(grList.GetRow().Cells["Id"].Value);
                PublicClass.Id_=id;
                this.Close();

            }
        }

        private void cmbSub_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void frmSearchAllCombo_KeyDown(object sender, KeyEventArgs e)
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

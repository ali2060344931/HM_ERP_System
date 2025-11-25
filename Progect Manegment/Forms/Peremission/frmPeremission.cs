using HM_ERP_System.Entity.Gender;
using HM_ERP_System.Entity.Role;
using HM_ERP_System.Entity.RolePermissione;
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

namespace HM_ERP_System.Forms.Peremission
{
    /// <summary>
    /// فرم مدیریت دسترسی ها
    /// </summary>
    public partial class frmPeremission : frmMasterForm
    {
        public frmPeremission()
        {
            InitializeComponent();
        }

        private void frmPeremission_Load(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Maximized;
            FillcmbRoles();
            CallUpdateTata();
            FilldgvList();
        }
        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from pr in db.Peremissions
                            //where pr.Id >1
                        select new
                        {
                            pr.Id,
                            Code = pr.NodeName,
                            PeremissionName = pr.Des,
                            Path = pr.Rot,
                        };
                DataTable dt = PublicClass.EntityTableToDataTable(q.ToList());dgvList.DataSource = dt;
                dgvList.AutoSizeColumns();
            }
        }

        private void FillcmbRoles()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.Roles.ToList();
                cmbRoles.DataSource = q;
            }
        }

        private void CallUpdateTata()
        {
            SaveNodeToDataBase();
            FillRolePermissiones();

        }

        void FillRolePermissiones()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var rol = db.Roles.ToList();
                    foreach (var role in rol)
                    {
                        var pr = db.Peremissions.ToList();
                        foreach (var item in pr)
                        {
                            var q = db.RolePermissiones.Where(c => c.RoleId==role.Id && c.PermissionId==item.Id);
                            if (q.Count()==0)
                            {
                                db.RolePermissiones.Add(new RolePermissione { RoleId = role.Id, PermissionId=item.Id, status=true });
                            }
                        }
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        //ToDo: نمایش تمامی ریشه های ساختار درختی
        /// <summary>
        /// نمایش تمامی ریشه های ساختار درختی
        /// </summary>
        /// <param name="Nodes"></param>
        /// <param name="Node"></param>
        /// <param name="Mode">مقدار 0 و 1</param>
        public void AddChildren(List<TreeNode> Nodes, TreeNode Node, int Mode)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    foreach (TreeNode thisNode in Node.Nodes)
                    {
                        var PeremissionsId = db.Peremissions.Where(x => x.NodeName==thisNode.Name).FirstOrDefault().Id;

                        var TF = db.RolePermissiones.Where(c => c.RoleId==RoleId_ && c.PermissionId==PeremissionsId).First();
                        //if(RoleId_==1 && PeremissionsId==2)
                        //{
                        //    MessageBox.Show("Test");
                        //}

                        if (Mode==0)
                            thisNode.Checked = TF.status;
                        else
                        {
                            TF.status=thisNode.Checked;
                            db.SaveChanges();
                        }
                        AddChildren(Nodes, thisNode, Mode);
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        void SaveNodeToDataBase()
        {
            try
            {
                string txt = "";
                using (var db = new DBcontextModel())
                {
                    int n = 0;
                    {
                        void SaveNode(TreeNode node)
                        {
                            var q0 = db.Peremissions.Where(c => c.NodeName==node.Name);
                            if (q0.Count() == 0)
                            {//جدید
                                //txt+=node.Text+","+node.Name+","+node.Tag+'\n';
                                db.Peremissions.Add(new Entity.Peremission.Peremission { Des = node.Text, NodeName=node.Name, Rot=node.FullPath });
                                db.SaveChanges();
                                n++;
                            }
                            else
                            {//ویرایش
                                q0.First().NodeName= node.Name;
                                q0.First().Rot=node.FullPath;
                            }
                            db.SaveChanges();
                            foreach (TreeNode child in node.Nodes)
                            {
                                SaveNode(child);
                            }
                        }
                        foreach (TreeNode rootNode in trPeremission.Nodes)
                        {
                            SaveNode(rootNode);
                        }
                        //Clipboard.SetText(txt);
                        //MessageBox.Show("ok");
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        int RoleId_ = 0;
        private void cmbRoles_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                RoleId_ = Convert.ToInt32(cmbRoles.Value);

                List<TreeNode> Nodes = new List<TreeNode>();
                for (int i = 0; i < trPeremission.Nodes.Count; i++)
                {
                    AddChildren(Nodes, trPeremission.Nodes[i], 0);
                }

                grListPeremission.Visible= true;
                panelAddNew.Visible= true;
            }
            catch (Exception)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRoles.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T064); return;
                }

                if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No) return;

                List<TreeNode> Nodes = new List<TreeNode>();
                for (int i = 0; i < trPeremission.Nodes.Count; i++)
                {
                    AddChildren(Nodes, Node: trPeremission.Nodes[i], Mode: 1);
                }

                PublicClass.WindowAlart("1");

                frmMainForm f = Application.OpenForms["frmMainForm"] as frmMainForm;
                f.setPeremissions();

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void frmPeremission_KeyDown(object sender, KeyEventArgs e)
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

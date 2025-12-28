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
using System.Windows.Media;

namespace HM_ERP_System.Forms.Peremission
{
    /// <summary>
    /// فرم مدیریت دسترسی ها
    /// </summary>
    public partial class frmPeremission : frmMasterForm
    {
        Dictionary<TreeNode, bool> _expandState = new Dictionary<TreeNode, bool>();
        List<TreeNode> _foundNodes = new List<TreeNode>();
        int _currentIndex = -1;
        string _searchText = "";

        public frmPeremission()
        {
            InitializeComponent();
        }

        private void frmPeremission_Load(object sender, EventArgs e)
        {
            trPeremission.DrawMode = TreeViewDrawMode.OwnerDrawText;
            trPeremission.DrawNode += treeView1_DrawNode;
            WindowState = FormWindowState.Maximized;
            FillcmbRoles();
            CallUpdateTata();
            FilldgvList();
        }

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (_foundNodes.Contains(e.Node))
            {
                Font font = e.Node == trPeremission.SelectedNode
                    ? new Font(e.Node.TreeView.Font, FontStyle.Bold)
                    : e.Node.TreeView.Font;

                TextRenderer.DrawText(
                    e.Graphics,
                    e.Node.Text,
                    font,
                    e.Bounds,
                 System.Drawing.Color.Red,          // رنگ Highlight
                    TextFormatFlags.GlyphOverhangPadding
                );
            }
            else
            {
                e.DrawDefault = true;
            }
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
                DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); dgvList.DataSource = dt;
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
                            var q = db.RolePermissiones.Where(c => c.RoleId == role.Id && c.PermissionId == item.Id);
                            if (q.Count() == 0)
                            {
                                db.RolePermissiones.Add(new RolePermissione { RoleId = role.Id, PermissionId = item.Id, status = true });
                            }
                        }
                    }
                    db.SaveChangesSafe();
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
                        var PeremissionsId = db.Peremissions.Where(x => x.NodeName == thisNode.Name).First().Id;

                        var TF = db.RolePermissiones.Where(c => c.RoleId == RoleId_ && c.PermissionId == PeremissionsId).First();
                        //if(RoleId_==1 && PeremissionsId==2)
                        //{
                        //    MessageBox.Show("Test");
                        //}

                        if (Mode == 0)
                            thisNode.Checked = TF.status;
                        else
                        {
                            TF.status = thisNode.Checked;
                            db.SaveChangesSafe();
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
                            var q0 = db.Peremissions.Where(c => c.NodeName == node.Name);
                            if (q0.Count() == 0)
                            {//جدید
                                db.Peremissions.Add(new Entity.Peremission.Peremission { Des = node.Text, NodeName = node.Name, Rot = node.FullPath });
                                //db.SaveChangesSafe();
                                n++;
                            }
                            else
                            {//ویرایش
                                q0.First().Des = node.Text;
                                q0.First().NodeName = node.Name;
                                q0.First().Rot = node.FullPath;
                            }
                            db.SaveChangesSafe();
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

                grListPeremission.Visible = true;
                panelAddNew.Visible = true;
            }
            catch (Exception)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRoles.SelectedIndex == -1)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _expandState.Clear();
            SaveExpandState(trPeremission.Nodes);
            _foundNodes.Clear();
            _currentIndex = -1;
            _searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(_searchText))
                return;

            FindAllNodes(trPeremission.Nodes, _searchText);

            if (_foundNodes.Count > 0)
                GoToNode(0);

            trPeremission.Invalidate(); // رفرش Highlight

            if (_foundNodes.Count > 0)
            {
                btnSearch.Text ="تعداد: " +_foundNodes.Count.ToString();
            }
            else
            {
                btnSearch.Text = "جستجو...";

            }
        }
        private void FindAllNodes(TreeNodeCollection nodes, string searchText)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    _foundNodes.Add(node);

                FindAllNodes(node.Nodes, searchText);
            }
        }

        private void GoToNode(int index)
        {
            TreeNode node = _foundNodes[index];

            ExpandPath(node);
            trPeremission.SelectedNode = node;
            node.EnsureVisible();

            trPeremission.Invalidate();
        }

        private void ExpandPath(TreeNode node)
        {
            TreeNode parent = node.Parent;
            while (parent != null)
            {
                parent.Expand();
                parent = parent.Parent;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_foundNodes.Count == 0) return;

            _currentIndex++;
            if (_currentIndex >= _foundNodes.Count)
                _currentIndex = 0;

            GoToNode(_currentIndex);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_foundNodes.Count == 0) return;

            _currentIndex--;
            if (_currentIndex < 0)
                _currentIndex = _foundNodes.Count - 1;

            GoToNode(_currentIndex);
        }

        private void SaveExpandState(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                _expandState[node] = node.IsExpanded;
                SaveExpandState(node.Nodes);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            // پاک کردن نتایج جستجو
            _foundNodes.Clear();
            _currentIndex = -1;
            _searchText = "";

            // برگرداندن وضعیت Expand
            RestoreExpandState(trPeremission.Nodes);

            // حذف انتخاب
            trPeremission.SelectedNode = null;

            // رفرش برای حذف Highlight
            trPeremission.Invalidate();
            btnSearch.Text = "جستجو...";
        }
        private void RestoreExpandState(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (_expandState.TryGetValue(node, out bool isExpanded))
                {
                    if (isExpanded)
                        node.Expand();
                    else
                        node.Collapse();
                }

                RestoreExpandState(node.Nodes);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

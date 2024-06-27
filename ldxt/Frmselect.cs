using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ldxt
{
    public partial class Frmselect : Form
    {
        public Frmselect()
        {
            InitializeComponent();
            LoadTreeViewNodes();
            dgvinfo.ContextMenuStrip = contextMenuStrip1;
            dgvinfo.MouseDown += new MouseEventHandler(dgvinfo_MouseDown_1);
        }
        
        private void butexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmselect_Load(object sender, EventArgs e)
        {
            LoadAllDevices();
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            Frmadd frm = new Frmadd();
            frm.Show();
        }

        private void LoadTreeViewNodes()
        {
            // 加载树节点的逻辑
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            if (selectedNode != null)
            {
                if (selectedNode.Parent == null) // 根节点
                {
                    LoadAllDevices();
                }
                else
                {
                    string regionName = selectedNode.Text; // 假设节点的文本是区域名称
                    LoadDevicesByRegion(regionName);
                }
            }
        }

        private void LoadAllDevices()
        {
            string sql = @"SELECT c.[CameraId], r.[RegionName], c.[Group], c.[Model], c.[IsStart], c.[Time]
                           FROM [dbo].[Camera] c
                           JOIN [dbo].[Region] r ON c.[RegionId] = r.[RegionId]
                           WHERE 1=1";
            DataTable dataTable = DBHelper.SPQ(sql);

            dgvinfo.DataSource = dataTable;
        }

        private void LoadDevicesByRegion(string regionName)
        {
            string sql = @"SELECT c.[CameraId], r.[RegionName], c.[Group], c.[Model], c.[IsStart], c.[Time]
                           FROM [dbo].[Camera] c
                           JOIN [dbo].[Region] r ON c.[RegionId] = r.[RegionId]
                           WHERE r.RegionName = @RegionName";
            SqlParameter[] parameters = {
                new SqlParameter("@RegionName", regionName)
            };

            DataTable dataTable = DBHelper.SPQ(sql, parameters);
            dgvinfo.DataSource = dataTable;
        }

        private void butbj_Click(object sender, EventArgs e)
        {
            if (dgvinfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvinfo.SelectedRows[0];
                int cameraId = Convert.ToInt32(selectedRow.Cells["CameraId"].Value);
                string regionName = selectedRow.Cells["RegionName"].Value.ToString();
                string group = selectedRow.Cells["Group"].Value.ToString();
                string model = selectedRow.Cells["Model"].Value.ToString();
                bool isStart = Convert.ToBoolean(selectedRow.Cells["IsStart"].Value);

                // 打开编辑窗体并传递选中行的数据
                FrmEdit frmEdit = new FrmEdit(cameraId, regionName, group, model, isStart);
                frmEdit.ShowDialog();

                // 重新加载数据
                if (treeView1.SelectedNode != null)
                {
                    treeView1_AfterSelect(this, new TreeViewEventArgs(treeView1.SelectedNode));
                }
            }
            else
            {
                MessageBox.Show("请先选择一行数据进行编辑。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvinfo.Rows[e.RowIndex];
                int cameraId = Convert.ToInt32(selectedRow.Cells["CameraId"].Value);
                string regionName = selectedRow.Cells["RegionName"].Value.ToString();
                string group = selectedRow.Cells["Group"].Value.ToString();
                string model = selectedRow.Cells["Model"].Value.ToString();
                bool isStart = Convert.ToBoolean(selectedRow.Cells["IsStart"].Value);

                // 打开编辑窗体并传递选中行的数据
                FrmEdit frmEdit = new FrmEdit(cameraId, regionName, group, model, isStart);
                frmEdit.ShowDialog();

                // 重新加载数据
                if (treeView1.SelectedNode != null)
                {
                    treeView1_AfterSelect(this, new TreeViewEventArgs(treeView1.SelectedNode));
                }
            }
        }

        private void butsc_Click(object sender, EventArgs e)
        {
            if (dgvinfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvinfo.SelectedRows[0];
                string cameraId = selectedRow.Cells["CameraId"].Value.ToString();

                // 显示确认删除的对话框
                DialogResult dialogResult = MessageBox.Show("确定要删除此信息吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    // 执行删除操作
                    DeleteCameraRecord(cameraId);

                    // 重新加载数据
                    if (treeView1.SelectedNode != null)
                    {
                        treeView1_AfterSelect(this, new TreeViewEventArgs(treeView1.SelectedNode));
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择一行数据进行删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteCameraRecord(string cameraId)
        {
            string sql = "DELETE FROM Camera WHERE CameraId = @CameraId";
            SqlParameter[] parameters = {
                new SqlParameter("@CameraId", cameraId)
            };

            try
            {
                int rowsAffected = DBHelper.ZSG(sql, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除失败，请重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除过程中发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvinfo.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }
        }

        

        private void SetCameraStatus(string cameraId, bool isStart)
        {
            string sql = "UPDATE Camera SET IsStart = @IsStart WHERE CameraId = @CameraId";
            SqlParameter[] parameters = {
                new SqlParameter("@IsStart", isStart),
                new SqlParameter("@CameraId", cameraId)
            };

            try
            {
                int rowsAffected = DBHelper.ZSG(sql, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show(isStart ? "启用成功" : "停用成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 重新加载数据
                    if (treeView1.SelectedNode != null)
                    {
                        treeView1_AfterSelect(this, new TreeViewEventArgs(treeView1.SelectedNode));
                    }
                }
                else
                {
                    MessageBox.Show(isStart ? "启用失败，请重试。" : "停用失败，请重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"设置状态过程中发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 启用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvinfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvinfo.SelectedRows[0];
                string cameraId = selectedRow.Cells["CameraId"].Value.ToString();
                SetCameraStatus(cameraId, true);
            }
        }

        private void 停用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvinfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvinfo.SelectedRows[0];
                string cameraId = selectedRow.Cells["CameraId"].Value.ToString();
                SetCameraStatus(cameraId, false);
            }
        }

        private void dgvinfo_MouseDown_1(object sender, MouseEventArgs e)
        {
            // 确保右键点击时选中行
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvinfo.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvinfo.ClearSelection();
                    dgvinfo.Rows[hitTestInfo.RowIndex].Selected = true;

                    // 获取选中行的摄像头状态
                    DataGridViewRow selectedRow = dgvinfo.Rows[hitTestInfo.RowIndex];
                    bool isStart = Convert.ToBoolean(selectedRow.Cells["IsStart"].Value);

                    // 根据摄像头状态设置菜单项的可见性
                    启用ToolStripMenuItem.Visible = !isStart;
                    停用ToolStripMenuItem.Visible = isStart;

                    // 显示右键菜单
                    contextMenuStrip1.Show(dgvinfo, new Point(e.X, e.Y));
                }
            }
        }
    }
}

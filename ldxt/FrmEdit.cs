using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ldxt
{
    public partial class FrmEdit : Form
    {
        private int cameraId;
        private string regionName;
        private string group;
        private string model;
        private bool isStart;

        public FrmEdit(int cameraId, string regionName, string group, string model, bool isStart)
        {
            InitializeComponent();
            this.cameraId = cameraId;
            this.regionName = regionName;
            this.group = group;
            this.model = model;
            this.isStart = isStart;
        }

        private void butexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            // 加载区域数据到ComboBox
            //LoadRegions();

            // 加载传递的数据到控件
            comqy.Text = regionName;
            comzb.Text = group;
            textxh.Text = model;
            radyes.Checked = isStart;
            radno.Checked = !isStart;
        }

        private void LoadRegions()
        {
            string sql = "SELECT RegionName FROM Region";
            DataTable regions = DBHelper.SPQ(sql, null);

            foreach (DataRow row in regions.Rows)
            {
                comqy.Items.Add(row["RegionName"].ToString());
            }
        }
        private void butbc_Click(object sender, EventArgs e)
        {
            string newRegionName = comqy.Text;
            string newGroup = comzb.Text;
            string newModel = textxh.Text;
            bool newIsStart = radyes.Checked;

            if (string.IsNullOrEmpty(newRegionName) ||
                string.IsNullOrEmpty(newGroup) ||
                string.IsNullOrEmpty(newModel))
            {
                MessageBox.Show("数据不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 更新数据库中的记录
            string sql = @"UPDATE Camera
                           SET RegionId = (SELECT RegionId FROM Region WHERE RegionName = @RegionName),
                               [Group] = @Group,
                               [Model] = @Model,
                               [IsStart] = @IsStart
                           WHERE CameraId = @CameraId";

            SqlParameter[] parameters = {
                new SqlParameter("@RegionName", newRegionName),
                new SqlParameter("@Group", newGroup),
                new SqlParameter("@Model", newModel),
                new SqlParameter("@IsStart", newIsStart),
                new SqlParameter("@CameraId", cameraId)
            };

            int rowsAffected = DBHelper.ZSG(sql, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("保存失败，请重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ldxt
{
    public partial class Frmadd : Form
    {
        public Frmadd()
        {
            InitializeComponent();
        }

        private void butesc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butbc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comqy.Text) ||
                string.IsNullOrEmpty(comgroup.Text) ||
                string.IsNullOrEmpty(textxh.Text))
            {
                MessageBox.Show("数据不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isEnabled = radyes.Checked; // 根据单选按钮状态确定是否启用设备
            int regionId = GetRegionId(comqy.Text);

            if (regionId == -1)
            {
                MessageBox.Show("无法找到对应的区域", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSaved = SaveDevice(regionId, comgroup.Text, textxh.Text, isEnabled);

            if (isSaved)
            {
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("保存失败，请重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetRegionId(string regionName)
        {
            try
            {
                string sql = "SELECT RegionId FROM Region WHERE RegionName = @RegionName";
                SqlParameter[] parameters = {
                    new SqlParameter("@RegionName", regionName)
                };

                object result = DBHelper.DSG(sql, parameters);
                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"获取区域ID时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private bool SaveDevice(int regionId, string group, string model, bool isEnabled)
        {
            try
            {
                string sql = "INSERT INTO Camera (RegionId, [Group], Model, IsStart, Time) VALUES (@RegionId, @Group, @Model, @IsStart, @Time)";
                SqlParameter[] parameters = {
                    new SqlParameter("@RegionId", regionId),
                    new SqlParameter("@Group", group),
                    new SqlParameter("@Model", model),
                    new SqlParameter("@IsStart", isEnabled),
                    new SqlParameter("@Time", DateTime.Now)
                };

                int rowsAffected = DBHelper.ZSG(sql, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存过程中发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Frmadd_Load(object sender, EventArgs e)
        {
            comqy.SelectedIndex = 0;
            comgroup.SelectedIndex = 0;
        }
    }
}

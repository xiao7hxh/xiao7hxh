using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ldxt
{
    public partial class FrmRecord : Form
    {
        public FrmRecord()
        {
            InitializeComponent();
        }

        private void FrmRecord_Load(object sender, EventArgs e)
        {
            comqy.SelectedIndex = 0;
            listView1.View = View.Details;
            listView1.Columns.Add("记录编号", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("匹配学生", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("匹配率", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("区域", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("设备编号", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("拍摄时间", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("小夏春美（防伪标）", 100, HorizontalAlignment.Left);

            // 窗体加载时查询所有数据
            LoadAllData();
        }

        private void LoadAllData()
        {
            // 查询所有数据的 SQL 语句
            string query = @"SELECT r.[RecordId], s.[StudentName], r.[Rate], e.[RegionName], r.[CameraId], r.[Time]
                           FROM [dbo].[Record] r
                           JOIN [dbo].[Student] s ON r.[StudentId] = s.[StudentId]
                           JOIN [dbo].[Region] e ON r.[RegionId] = e.[RegionId]
                           WHERE 1=1";

            try
            {
                DataTable dataTable = DBHelper.SPQ(query);
                BindDataToListView(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void BindDataToListView(DataTable dataTable)
        {
            listView1.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["RecordId"].ToString());
                item.SubItems.Add(row["StudentName"].ToString());
                item.SubItems.Add(row["Rate"].ToString());
                item.SubItems.Add(row["RegionName"].ToString());
                item.SubItems.Add(row["CameraId"].ToString());
                item.SubItems.Add(row["Time"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void butselect_Click(object sender, EventArgs e)
        {
            // 获取用户选择的区域和时间段
            string selectedRegion = comqy.SelectedItem.ToString();
            DateTime startDate = dateing.Value;
            DateTime endDate = datetime.Value;

            // 查询语句，根据选择的区域和时间段进行查询
            string query = @"SELECT r.[RecordId], s.[StudentName], r.[Rate], e.[RegionName], r.[CameraId], r.[Time]
                             FROM [dbo].[Record] r
                             JOIN [dbo].[Student] s ON r.[StudentId] = s.[StudentId]
                             JOIN [dbo].[Region] e ON r.[RegionId] = e.[RegionId]
                             WHERE (@Region = '全部' OR e.[RegionName] = @Region)
                             AND r.[Time] BETWEEN @StartDate AND @EndDate";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Region", selectedRegion),
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };

            try
            {
                DataTable dataTable = DBHelper.SPQ(query, parameters);
                BindDataToListView(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ldxt
{
    public partial class FrmStudent : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataSet ds;

        public FrmStudent()
        {
            InitializeComponent();
        }

        private void butexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            // SQL 查询语句
            string sql = @"SELECT * FROM [dbo].[Student]";

            // 使用 DBHelper 类中的连接字符串和数据操作方法
            using (SqlConnection connection = new SqlConnection(DBHelper.str))
            {
                adapter = new SqlDataAdapter(sql, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                adapter.Fill(ds, "Student");
                dataTable = ds.Tables["Student"];
                dgvinto.DataSource = dataTable;
            }
        }

        private void butgx_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("确定保存吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (choice == DialogResult.OK)
            {
                try
                {
                    // 更新数据到数据库
                    adapter.Update(ds, "Student");
                    MessageBox.Show("保存成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存失败：{ex.Message}");
                }
            }
        }
    }
}

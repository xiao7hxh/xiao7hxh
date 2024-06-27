using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ldxt
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void butesc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出系统？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CheckUser())
                {
                    if (this.CheckDBUser())
                    {
                        FrmMain main = new FrmMain();
                        User user = new User
                        {
                            UserName = this.textname.Text,
                            UserPwd = this.textpwd.Text
                        };
                        this.Hide();
                        main.user = user;
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误，请重试。", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("请输入有效的用户名和密码。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckUser()
        {
            if (string.IsNullOrEmpty(this.textname.Text) || string.IsNullOrEmpty(this.textpwd.Text))
            {
                return false;
            }
            return true;
        }

        public bool CheckDBUser()
        {
            try
            {
                string sql = "SELECT COUNT(1) FROM [User] WHERE UserName = @UserName AND PassWord = @PassWord";
                SqlParameter[] parameters = {
                    new SqlParameter("@UserName", this.textname.Text),
                    new SqlParameter("@PassWord", this.textpwd.Text)
                };

                object result = DBHelper.DHDL(sql,parameters);

                if (result != null && Convert.ToInt32(result) > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据库连接错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public class User
        {
            public string UserName { get; set; }
            public string UserPwd { get; set; }
        }
    }
}

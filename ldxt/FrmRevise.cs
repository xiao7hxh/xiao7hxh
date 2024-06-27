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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ldxt
{
    public partial class FrmRevise : Form
    {
        private string currentUserName;
        public FrmRevise(string userName)
        {
            InitializeComponent();
            currentUserName = userName;
        }

        private void butfh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textpwd.Text) || string.IsNullOrEmpty(textnewpwd.Text) || string.IsNullOrEmpty(textqr.Text))
            {
                MessageBox.Show("所有字段都是必填的。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textnewpwd.Text != textqr.Text)
            {
                MessageBox.Show("新密码和确认密码不匹配。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckPassword(currentUserName, textpwd.Text))
            {
                MessageBox.Show("原密码不正确。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ChangePassword(currentUserName, textnewpwd.Text))
            {
                MessageBox.Show("密码修改成功。", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("密码修改失败，请重试。", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
        private bool CheckPassword(string userName, string password)
        {
            string sql = "SELECT COUNT(1) FROM [User] WHERE UserName = @UserName AND PassWord = @Password";
            SqlParameter[] parameters = {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", password)
            };

            object result = DBHelper.DHDL(sql, parameters);
            return result != null && Convert.ToInt32(result) > 0;
        }

        private bool ChangePassword(string userName, string newPassword)
        {
            string sql = "UPDATE [User] SET PassWord = @NewPassword WHERE UserName = @UserName";
            SqlParameter[] parameters = {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@NewPassword", newPassword)
            };

            int result = DBHelper.ZSG(sql, parameters);
            return result > 0;
        }
    }
}

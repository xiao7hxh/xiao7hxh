using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ldxt.Frmlogin;

namespace ldxt
{
    public partial class FrmMain : Form
    {
        public User user { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出系统？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void yongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRevise form = new FrmRevise(user.UserName);
            form.ShowDialog();
        }

        private void 设备管理CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 查询设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmselect frm = new Frmselect();
            frm.Show();
        }

        private void 添加设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmadd frm = new Frmadd();
            frm.Show();
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelp frm = new FrmHelp();
            frm.Show();
        }

        private void 门禁记录管理RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecord frm = new FrmRecord();
            frm.Show();
        }

        private void 学生信息管理SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudent frm = new FrmStudent();
            frm.Show();
        }
    }
}

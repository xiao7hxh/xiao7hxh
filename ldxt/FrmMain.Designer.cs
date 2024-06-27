namespace ldxt
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息管理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.门禁记录管理RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yongToolStripMenuItem,
            this.设备管理CToolStripMenuItem,
            this.学生信息管理SToolStripMenuItem,
            this.门禁记录管理RToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yongToolStripMenuItem
            // 
            this.yongToolStripMenuItem.Name = "yongToolStripMenuItem";
            this.yongToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.yongToolStripMenuItem.Text = "用户管理（U）";
            this.yongToolStripMenuItem.Click += new System.EventHandler(this.yongToolStripMenuItem_Click);
            // 
            // 设备管理CToolStripMenuItem
            // 
            this.设备管理CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询设备ToolStripMenuItem,
            this.添加设备ToolStripMenuItem});
            this.设备管理CToolStripMenuItem.Name = "设备管理CToolStripMenuItem";
            this.设备管理CToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.设备管理CToolStripMenuItem.Text = "设备管理（C）";
            this.设备管理CToolStripMenuItem.Click += new System.EventHandler(this.设备管理CToolStripMenuItem_Click);
            // 
            // 查询设备ToolStripMenuItem
            // 
            this.查询设备ToolStripMenuItem.Name = "查询设备ToolStripMenuItem";
            this.查询设备ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.查询设备ToolStripMenuItem.Text = "查询设备";
            this.查询设备ToolStripMenuItem.Click += new System.EventHandler(this.查询设备ToolStripMenuItem_Click);
            // 
            // 添加设备ToolStripMenuItem
            // 
            this.添加设备ToolStripMenuItem.Name = "添加设备ToolStripMenuItem";
            this.添加设备ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.添加设备ToolStripMenuItem.Text = "添加设备";
            this.添加设备ToolStripMenuItem.Click += new System.EventHandler(this.添加设备ToolStripMenuItem_Click);
            // 
            // 学生信息管理SToolStripMenuItem
            // 
            this.学生信息管理SToolStripMenuItem.Name = "学生信息管理SToolStripMenuItem";
            this.学生信息管理SToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.学生信息管理SToolStripMenuItem.Text = "学生信息管理（S）";
            this.学生信息管理SToolStripMenuItem.Click += new System.EventHandler(this.学生信息管理SToolStripMenuItem_Click);
            // 
            // 门禁记录管理RToolStripMenuItem
            // 
            this.门禁记录管理RToolStripMenuItem.Name = "门禁记录管理RToolStripMenuItem";
            this.门禁记录管理RToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.门禁记录管理RToolStripMenuItem.Text = "门禁记录管理（R）";
            this.门禁记录管理RToolStripMenuItem.Click += new System.EventHandler(this.门禁记录管理RToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.帮助HToolStripMenuItem.Text = "帮助（H）";
            this.帮助HToolStripMenuItem.Click += new System.EventHandler(this.帮助HToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 24);
            this.toolStripMenuItem1.Text = "退出系统（E）";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 545);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "灵动人脸识门禁系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 门禁记录管理RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加设备ToolStripMenuItem;
    }
}
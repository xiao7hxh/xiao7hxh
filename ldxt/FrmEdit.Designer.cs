namespace ldxt
{
    partial class FrmEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.labqy = new System.Windows.Forms.Label();
            this.labzb = new System.Windows.Forms.Label();
            this.labxh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comqy = new System.Windows.Forms.ComboBox();
            this.comzb = new System.Windows.Forms.ComboBox();
            this.textxh = new System.Windows.Forms.TextBox();
            this.radyes = new System.Windows.Forms.RadioButton();
            this.radno = new System.Windows.Forms.RadioButton();
            this.butbc = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "门禁拍照设备信息";
            // 
            // labqy
            // 
            this.labqy.AutoSize = true;
            this.labqy.Location = new System.Drawing.Point(54, 91);
            this.labqy.Name = "labqy";
            this.labqy.Size = new System.Drawing.Size(52, 15);
            this.labqy.TabIndex = 1;
            this.labqy.Text = "区域：";
            // 
            // labzb
            // 
            this.labzb.AutoSize = true;
            this.labzb.Location = new System.Drawing.Point(54, 147);
            this.labzb.Name = "labzb";
            this.labzb.Size = new System.Drawing.Size(45, 15);
            this.labzb.TabIndex = 2;
            this.labzb.Text = "组别:";
            // 
            // labxh
            // 
            this.labxh.AutoSize = true;
            this.labxh.Location = new System.Drawing.Point(54, 203);
            this.labxh.Name = "labxh";
            this.labxh.Size = new System.Drawing.Size(52, 15);
            this.labxh.TabIndex = 3;
            this.labxh.Text = "型号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "是否启用：";
            // 
            // comqy
            // 
            this.comqy.FormattingEnabled = true;
            this.comqy.Items.AddRange(new object[] {
            "请选择",
            "教学楼",
            "图书馆",
            "体育馆",
            "宿舍楼",
            "餐厅"});
            this.comqy.Location = new System.Drawing.Point(135, 88);
            this.comqy.Name = "comqy";
            this.comqy.Size = new System.Drawing.Size(315, 23);
            this.comqy.TabIndex = 5;
            // 
            // comzb
            // 
            this.comzb.FormattingEnabled = true;
            this.comzb.Items.AddRange(new object[] {
            "请选择",
            "一组",
            "二组"});
            this.comzb.Location = new System.Drawing.Point(135, 138);
            this.comzb.Name = "comzb";
            this.comzb.Size = new System.Drawing.Size(315, 23);
            this.comzb.TabIndex = 6;
            // 
            // textxh
            // 
            this.textxh.Location = new System.Drawing.Point(135, 193);
            this.textxh.Name = "textxh";
            this.textxh.Size = new System.Drawing.Size(315, 25);
            this.textxh.TabIndex = 7;
            // 
            // radyes
            // 
            this.radyes.AutoSize = true;
            this.radyes.Location = new System.Drawing.Point(187, 254);
            this.radyes.Name = "radyes";
            this.radyes.Size = new System.Drawing.Size(43, 19);
            this.radyes.TabIndex = 8;
            this.radyes.TabStop = true;
            this.radyes.Text = "是";
            this.radyes.UseVisualStyleBackColor = true;
            // 
            // radno
            // 
            this.radno.AutoSize = true;
            this.radno.Location = new System.Drawing.Point(343, 254);
            this.radno.Name = "radno";
            this.radno.Size = new System.Drawing.Size(43, 19);
            this.radno.TabIndex = 9;
            this.radno.TabStop = true;
            this.radno.Text = "否";
            this.radno.UseVisualStyleBackColor = true;
            // 
            // butbc
            // 
            this.butbc.Location = new System.Drawing.Point(236, 309);
            this.butbc.Name = "butbc";
            this.butbc.Size = new System.Drawing.Size(71, 38);
            this.butbc.TabIndex = 10;
            this.butbc.Text = "保存";
            this.butbc.UseVisualStyleBackColor = true;
            this.butbc.Click += new System.EventHandler(this.butbc_Click);
            // 
            // butexit
            // 
            this.butexit.Location = new System.Drawing.Point(329, 309);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(77, 38);
            this.butexit.TabIndex = 11;
            this.butexit.Text = "关闭";
            this.butexit.UseVisualStyleBackColor = true;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 369);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butbc);
            this.Controls.Add(this.radno);
            this.Controls.Add(this.radyes);
            this.Controls.Add(this.textxh);
            this.Controls.Add(this.comzb);
            this.Controls.Add(this.comqy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labxh);
            this.Controls.Add(this.labzb);
            this.Controls.Add(this.labqy);
            this.Controls.Add(this.label1);
            this.Name = "FrmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑设备信息";
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labqy;
        private System.Windows.Forms.Label labzb;
        private System.Windows.Forms.Label labxh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comqy;
        private System.Windows.Forms.ComboBox comzb;
        private System.Windows.Forms.TextBox textxh;
        private System.Windows.Forms.RadioButton radyes;
        private System.Windows.Forms.RadioButton radno;
        private System.Windows.Forms.Button butbc;
        private System.Windows.Forms.Button butexit;
    }
}
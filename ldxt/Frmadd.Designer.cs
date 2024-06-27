namespace ldxt
{
    partial class Frmadd
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comqy = new System.Windows.Forms.ComboBox();
            this.comgroup = new System.Windows.Forms.ComboBox();
            this.textxh = new System.Windows.Forms.TextBox();
            this.radyes = new System.Windows.Forms.RadioButton();
            this.radno = new System.Windows.Forms.RadioButton();
            this.butbc = new System.Windows.Forms.Button();
            this.butesc = new System.Windows.Forms.Button();
            this.groupor = new System.Windows.Forms.GroupBox();
            this.groupor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "门禁拍照设备信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "区域：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "组别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "型号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "是否启用：";
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
            this.comqy.Location = new System.Drawing.Point(188, 79);
            this.comqy.Name = "comqy";
            this.comqy.Size = new System.Drawing.Size(243, 23);
            this.comqy.TabIndex = 5;
            // 
            // comgroup
            // 
            this.comgroup.FormattingEnabled = true;
            this.comgroup.Items.AddRange(new object[] {
            "请选择",
            "一组",
            "二组"});
            this.comgroup.Location = new System.Drawing.Point(188, 131);
            this.comgroup.Name = "comgroup";
            this.comgroup.Size = new System.Drawing.Size(243, 23);
            this.comgroup.TabIndex = 6;
            // 
            // textxh
            // 
            this.textxh.Location = new System.Drawing.Point(188, 196);
            this.textxh.Name = "textxh";
            this.textxh.Size = new System.Drawing.Size(235, 25);
            this.textxh.TabIndex = 7;
            // 
            // radyes
            // 
            this.radyes.AutoSize = true;
            this.radyes.Location = new System.Drawing.Point(26, 26);
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
            this.radno.Location = new System.Drawing.Point(126, 26);
            this.radno.Name = "radno";
            this.radno.Size = new System.Drawing.Size(43, 19);
            this.radno.TabIndex = 9;
            this.radno.TabStop = true;
            this.radno.Text = "否";
            this.radno.UseVisualStyleBackColor = true;
            // 
            // butbc
            // 
            this.butbc.Location = new System.Drawing.Point(214, 315);
            this.butbc.Name = "butbc";
            this.butbc.Size = new System.Drawing.Size(93, 30);
            this.butbc.TabIndex = 10;
            this.butbc.Text = "保存";
            this.butbc.UseVisualStyleBackColor = true;
            this.butbc.Click += new System.EventHandler(this.butbc_Click);
            // 
            // butesc
            // 
            this.butesc.Location = new System.Drawing.Point(314, 319);
            this.butesc.Name = "butesc";
            this.butesc.Size = new System.Drawing.Size(109, 26);
            this.butesc.TabIndex = 11;
            this.butesc.Text = "关闭";
            this.butesc.UseVisualStyleBackColor = true;
            this.butesc.Click += new System.EventHandler(this.butesc_Click);
            // 
            // groupor
            // 
            this.groupor.Controls.Add(this.radyes);
            this.groupor.Controls.Add(this.radno);
            this.groupor.Location = new System.Drawing.Point(188, 233);
            this.groupor.Name = "groupor";
            this.groupor.Size = new System.Drawing.Size(235, 60);
            this.groupor.TabIndex = 12;
            this.groupor.TabStop = false;
            // 
            // Frmadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 375);
            this.Controls.Add(this.groupor);
            this.Controls.Add(this.butesc);
            this.Controls.Add(this.butbc);
            this.Controls.Add(this.textxh);
            this.Controls.Add(this.comgroup);
            this.Controls.Add(this.comqy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frmadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加设备";
            this.Load += new System.EventHandler(this.Frmadd_Load);
            this.groupor.ResumeLayout(false);
            this.groupor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comqy;
        private System.Windows.Forms.ComboBox comgroup;
        private System.Windows.Forms.TextBox textxh;
        private System.Windows.Forms.RadioButton radyes;
        private System.Windows.Forms.RadioButton radno;
        private System.Windows.Forms.Button butbc;
        private System.Windows.Forms.Button butesc;
        private System.Windows.Forms.GroupBox groupor;
    }
}
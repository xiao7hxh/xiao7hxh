namespace ldxt
{
    partial class FrmRecord
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
            this.comqy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateing = new System.Windows.Forms.DateTimePicker();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.butselect = new System.Windows.Forms.Button();
            this.labjg = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "区域：";
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
            this.comqy.Location = new System.Drawing.Point(92, 64);
            this.comqy.Name = "comqy";
            this.comqy.Size = new System.Drawing.Size(148, 23);
            this.comqy.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "起始时间：";
            // 
            // dateing
            // 
            this.dateing.Location = new System.Drawing.Point(384, 59);
            this.dateing.Name = "dateing";
            this.dateing.Size = new System.Drawing.Size(200, 25);
            this.dateing.TabIndex = 4;
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(384, 109);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 25);
            this.datetime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "结束时间：";
            // 
            // butselect
            // 
            this.butselect.Location = new System.Drawing.Point(631, 109);
            this.butselect.Name = "butselect";
            this.butselect.Size = new System.Drawing.Size(77, 27);
            this.butselect.TabIndex = 7;
            this.butselect.Text = "查询";
            this.butselect.UseVisualStyleBackColor = true;
            this.butselect.Click += new System.EventHandler(this.butselect_Click);
            // 
            // labjg
            // 
            this.labjg.AutoSize = true;
            this.labjg.Location = new System.Drawing.Point(19, 162);
            this.labjg.Name = "labjg";
            this.labjg.Size = new System.Drawing.Size(67, 15);
            this.labjg.TabIndex = 8;
            this.labjg.Text = "查询结果";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(769, 286);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 487);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labjg);
            this.Controls.Add(this.butselect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.dateing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comqy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询采集记录";
            this.Load += new System.EventHandler(this.FrmRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comqy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateing;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butselect;
        private System.Windows.Forms.Label labjg;
        private System.Windows.Forms.ListView listView1;
    }
}
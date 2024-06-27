namespace ldxt
{
    partial class FrmStudent
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
            this.labstudent = new System.Windows.Forms.Label();
            this.dgvinto = new System.Windows.Forms.DataGridView();
            this.butgx = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdenCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntraTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinto)).BeginInit();
            this.SuspendLayout();
            // 
            // labstudent
            // 
            this.labstudent.AutoSize = true;
            this.labstudent.Location = new System.Drawing.Point(13, 13);
            this.labstudent.Name = "labstudent";
            this.labstudent.Size = new System.Drawing.Size(97, 15);
            this.labstudent.TabIndex = 0;
            this.labstudent.Text = "学生信息浏览";
            // 
            // dgvinto
            // 
            this.dgvinto.AllowUserToAddRows = false;
            this.dgvinto.AllowUserToDeleteRows = false;
            this.dgvinto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.IdenCard,
            this.FieId,
            this.PicUrl,
            this.EntraTime,
            this.cht});
            this.dgvinto.Location = new System.Drawing.Point(12, 48);
            this.dgvinto.Name = "dgvinto";
            this.dgvinto.ReadOnly = true;
            this.dgvinto.RowHeadersWidth = 51;
            this.dgvinto.RowTemplate.Height = 27;
            this.dgvinto.Size = new System.Drawing.Size(775, 351);
            this.dgvinto.TabIndex = 1;
            // 
            // butgx
            // 
            this.butgx.Location = new System.Drawing.Point(581, 405);
            this.butgx.Name = "butgx";
            this.butgx.Size = new System.Drawing.Size(80, 33);
            this.butgx.TabIndex = 2;
            this.butgx.Text = "更新";
            this.butgx.UseVisualStyleBackColor = true;
            this.butgx.Click += new System.EventHandler(this.butgx_Click);
            // 
            // butexit
            // 
            this.butexit.Location = new System.Drawing.Point(679, 405);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(77, 33);
            this.butexit.TabIndex = 3;
            this.butexit.Text = "关闭";
            this.butexit.UseVisualStyleBackColor = true;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "学生编号";
            this.StudentId.MinimumWidth = 6;
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "学生姓名";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 125;
            // 
            // IdenCard
            // 
            this.IdenCard.DataPropertyName = "IdenCard";
            this.IdenCard.HeaderText = "身份证号";
            this.IdenCard.MinimumWidth = 6;
            this.IdenCard.Name = "IdenCard";
            this.IdenCard.ReadOnly = true;
            this.IdenCard.Width = 125;
            // 
            // FieId
            // 
            this.FieId.DataPropertyName = "FieId";
            this.FieId.HeaderText = "专业方向";
            this.FieId.MinimumWidth = 6;
            this.FieId.Name = "FieId";
            this.FieId.ReadOnly = true;
            this.FieId.Width = 125;
            // 
            // PicUrl
            // 
            this.PicUrl.DataPropertyName = "PicUrl";
            this.PicUrl.HeaderText = "照片地址";
            this.PicUrl.MinimumWidth = 6;
            this.PicUrl.Name = "PicUrl";
            this.PicUrl.ReadOnly = true;
            this.PicUrl.Width = 125;
            // 
            // EntraTime
            // 
            this.EntraTime.DataPropertyName = "EntraTime";
            this.EntraTime.HeaderText = "入学时间";
            this.EntraTime.MinimumWidth = 6;
            this.EntraTime.Name = "EntraTime";
            this.EntraTime.ReadOnly = true;
            this.EntraTime.Width = 125;
            // 
            // cht
            // 
            this.cht.HeaderText = "小夏春美（防伪标）";
            this.cht.MinimumWidth = 6;
            this.cht.Name = "cht";
            this.cht.ReadOnly = true;
            this.cht.Width = 125;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butgx);
            this.Controls.Add(this.dgvinto);
            this.Controls.Add(this.labstudent);
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询学生信息";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labstudent;
        private System.Windows.Forms.DataGridView dgvinto;
        private System.Windows.Forms.Button butgx;
        private System.Windows.Forms.Button butexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdenCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PicUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntraTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cht;
    }
}
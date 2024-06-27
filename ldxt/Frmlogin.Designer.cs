namespace ldxt
{
    partial class Frmlogin
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
            this.textname = new System.Windows.Forms.TextBox();
            this.textpwd = new System.Windows.Forms.TextBox();
            this.butlogin = new System.Windows.Forms.Button();
            this.butesc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 18F);
            this.label1.Location = new System.Drawing.Point(102, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "灵动人脸识别门禁系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 9F);
            this.label2.Location = new System.Drawing.Point(104, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 9F);
            this.label3.Location = new System.Drawing.Point(104, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码：";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(205, 138);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(210, 25);
            this.textname.TabIndex = 3;
            // 
            // textpwd
            // 
            this.textpwd.Location = new System.Drawing.Point(205, 192);
            this.textpwd.Name = "textpwd";
            this.textpwd.Size = new System.Drawing.Size(210, 25);
            this.textpwd.TabIndex = 4;
            // 
            // butlogin
            // 
            this.butlogin.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butlogin.Location = new System.Drawing.Point(151, 281);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(75, 31);
            this.butlogin.TabIndex = 5;
            this.butlogin.Text = "登录";
            this.butlogin.UseVisualStyleBackColor = true;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // butesc
            // 
            this.butesc.Font = new System.Drawing.Font("黑体", 9F);
            this.butesc.Location = new System.Drawing.Point(286, 281);
            this.butesc.Name = "butesc";
            this.butesc.Size = new System.Drawing.Size(79, 31);
            this.butesc.TabIndex = 6;
            this.butesc.Text = "取消";
            this.butesc.UseVisualStyleBackColor = true;
            this.butesc.Click += new System.EventHandler(this.butesc_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 394);
            this.Controls.Add(this.butesc);
            this.Controls.Add(this.butlogin);
            this.Controls.Add(this.textpwd);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textpwd;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.Button butesc;
    }
}
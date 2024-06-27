namespace ldxt
{
    partial class FrmRevise
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
            this.labpwd = new System.Windows.Forms.Label();
            this.textpwd = new System.Windows.Forms.TextBox();
            this.textnewpwd = new System.Windows.Forms.TextBox();
            this.textqr = new System.Windows.Forms.TextBox();
            this.labnewpwd = new System.Windows.Forms.Label();
            this.labqr = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.butfh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labpwd
            // 
            this.labpwd.AutoSize = true;
            this.labpwd.Location = new System.Drawing.Point(111, 66);
            this.labpwd.Name = "labpwd";
            this.labpwd.Size = new System.Drawing.Size(67, 15);
            this.labpwd.TabIndex = 0;
            this.labpwd.Text = "原密码：";
            // 
            // textpwd
            // 
            this.textpwd.Location = new System.Drawing.Point(223, 63);
            this.textpwd.Name = "textpwd";
            this.textpwd.Size = new System.Drawing.Size(172, 25);
            this.textpwd.TabIndex = 1;
            // 
            // textnewpwd
            // 
            this.textnewpwd.Location = new System.Drawing.Point(223, 145);
            this.textnewpwd.Name = "textnewpwd";
            this.textnewpwd.Size = new System.Drawing.Size(172, 25);
            this.textnewpwd.TabIndex = 2;
            // 
            // textqr
            // 
            this.textqr.Location = new System.Drawing.Point(223, 235);
            this.textqr.Name = "textqr";
            this.textqr.Size = new System.Drawing.Size(172, 25);
            this.textqr.TabIndex = 3;
            // 
            // labnewpwd
            // 
            this.labnewpwd.AutoSize = true;
            this.labnewpwd.Location = new System.Drawing.Point(111, 148);
            this.labnewpwd.Name = "labnewpwd";
            this.labnewpwd.Size = new System.Drawing.Size(67, 15);
            this.labnewpwd.TabIndex = 4;
            this.labnewpwd.Text = "新密码：";
            // 
            // labqr
            // 
            this.labqr.AutoSize = true;
            this.labqr.Location = new System.Drawing.Point(114, 244);
            this.labqr.Name = "labqr";
            this.labqr.Size = new System.Drawing.Size(82, 15);
            this.labqr.TabIndex = 5;
            this.labqr.Text = "确认密码：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butfh
            // 
            this.butfh.Location = new System.Drawing.Point(283, 313);
            this.butfh.Name = "butfh";
            this.butfh.Size = new System.Drawing.Size(89, 33);
            this.butfh.TabIndex = 7;
            this.butfh.Text = "返回";
            this.butfh.UseVisualStyleBackColor = true;
            this.butfh.Click += new System.EventHandler(this.butfh_Click);
            // 
            // FrmRevise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 403);
            this.Controls.Add(this.butfh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labqr);
            this.Controls.Add(this.labnewpwd);
            this.Controls.Add(this.textqr);
            this.Controls.Add(this.textnewpwd);
            this.Controls.Add(this.textpwd);
            this.Controls.Add(this.labpwd);
            this.Name = "FrmRevise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labpwd;
        private System.Windows.Forms.TextBox textpwd;
        private System.Windows.Forms.TextBox textnewpwd;
        private System.Windows.Forms.TextBox textqr;
        private System.Windows.Forms.Label labnewpwd;
        private System.Windows.Forms.Label labqr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butfh;
    }
}
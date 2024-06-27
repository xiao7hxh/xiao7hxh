namespace ldxt
{
    partial class Frmselect
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("教学楼");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("图书馆");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("体育馆");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("宿舍楼");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("餐厅");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("小夏春美（防伪标）");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("所有区域", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.butadd = new System.Windows.Forms.Button();
            this.butbj = new System.Windows.Forms.Button();
            this.butsc = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.dgvinfo = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.启用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "区域列表";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 27);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "教学楼";
            treeNode2.Name = "节点2";
            treeNode2.Text = "图书馆";
            treeNode3.Name = "节点3";
            treeNode3.Text = "体育馆";
            treeNode4.Name = "节点4";
            treeNode4.Text = "宿舍楼";
            treeNode5.Name = "节点5";
            treeNode5.Text = "餐厅";
            treeNode6.Name = "cht";
            treeNode6.Text = "小夏春美（防伪标）";
            treeNode7.Name = "节点0";
            treeNode7.Text = "所有区域";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(204, 500);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "摄像头信息";
            // 
            // butadd
            // 
            this.butadd.Location = new System.Drawing.Point(253, 36);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(66, 45);
            this.butadd.TabIndex = 3;
            this.butadd.Text = "添加";
            this.butadd.UseVisualStyleBackColor = true;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // butbj
            // 
            this.butbj.Location = new System.Drawing.Point(326, 36);
            this.butbj.Name = "butbj";
            this.butbj.Size = new System.Drawing.Size(77, 45);
            this.butbj.TabIndex = 4;
            this.butbj.Text = "编辑";
            this.butbj.UseVisualStyleBackColor = true;
            this.butbj.Click += new System.EventHandler(this.butbj_Click);
            // 
            // butsc
            // 
            this.butsc.Location = new System.Drawing.Point(410, 36);
            this.butsc.Name = "butsc";
            this.butsc.Size = new System.Drawing.Size(73, 45);
            this.butsc.TabIndex = 5;
            this.butsc.Text = "删除";
            this.butsc.UseVisualStyleBackColor = true;
            this.butsc.Click += new System.EventHandler(this.butsc_Click);
            // 
            // butexit
            // 
            this.butexit.Location = new System.Drawing.Point(490, 36);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(73, 45);
            this.butexit.TabIndex = 6;
            this.butexit.Text = "退出";
            this.butexit.UseVisualStyleBackColor = true;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // dgvinfo
            // 
            this.dgvinfo.AllowUserToAddRows = false;
            this.dgvinfo.AllowUserToDeleteRows = false;
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CameraId,
            this.RegionName,
            this.Group,
            this.Model,
            this.IsStart,
            this.Time,
            this.cht});
            this.dgvinfo.Location = new System.Drawing.Point(253, 88);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.ReadOnly = true;
            this.dgvinfo.RowHeadersWidth = 51;
            this.dgvinfo.RowTemplate.Height = 27;
            this.dgvinfo.Size = new System.Drawing.Size(662, 448);
            this.dgvinfo.TabIndex = 7;
            this.dgvinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinfo_CellContentClick);
            this.dgvinfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvinfo_MouseDown_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启用ToolStripMenuItem,
            this.停用ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 启用ToolStripMenuItem
            // 
            this.启用ToolStripMenuItem.Name = "启用ToolStripMenuItem";
            this.启用ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.启用ToolStripMenuItem.Text = "启用";
            this.启用ToolStripMenuItem.Click += new System.EventHandler(this.启用ToolStripMenuItem_Click);
            // 
            // 停用ToolStripMenuItem
            // 
            this.停用ToolStripMenuItem.Name = "停用ToolStripMenuItem";
            this.停用ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.停用ToolStripMenuItem.Text = "停用";
            this.停用ToolStripMenuItem.Click += new System.EventHandler(this.停用ToolStripMenuItem_Click);
            // 
            // CameraId
            // 
            this.CameraId.DataPropertyName = "CameraId";
            this.CameraId.HeaderText = "编号";
            this.CameraId.MinimumWidth = 6;
            this.CameraId.Name = "CameraId";
            this.CameraId.ReadOnly = true;
            this.CameraId.Width = 125;
            // 
            // RegionName
            // 
            this.RegionName.DataPropertyName = "RegionName";
            this.RegionName.HeaderText = "区域名";
            this.RegionName.MinimumWidth = 6;
            this.RegionName.Name = "RegionName";
            this.RegionName.ReadOnly = true;
            this.RegionName.Width = 125;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "组别";
            this.Group.MinimumWidth = 6;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 125;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "型号";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 125;
            // 
            // IsStart
            // 
            this.IsStart.DataPropertyName = "IsStart";
            this.IsStart.HeaderText = "是否开启";
            this.IsStart.MinimumWidth = 6;
            this.IsStart.Name = "IsStart";
            this.IsStart.ReadOnly = true;
            this.IsStart.Width = 125;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "登记时间";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // cht
            // 
            this.cht.HeaderText = "小夏春美（防伪标）";
            this.cht.MinimumWidth = 6;
            this.cht.Name = "cht";
            this.cht.ReadOnly = true;
            this.cht.Width = 125;
            // 
            // Frmselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 548);
            this.Controls.Add(this.dgvinfo);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butsc);
            this.Controls.Add(this.butbj);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Name = "Frmselect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询设备";
            this.Load += new System.EventHandler(this.Frmselect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Button butbj;
        private System.Windows.Forms.Button butsc;
        private System.Windows.Forms.Button butexit;
        private System.Windows.Forms.DataGridView dgvinfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 启用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停用ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn cht;
    }
}
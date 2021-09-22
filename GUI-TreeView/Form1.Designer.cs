
namespace GUI_TreeView
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Khoa công nghệ thông tin");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Khoa lý luận chính trị");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Đại học cộng đồng", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Lớp đại học điện tử", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Khoa cơ khí ", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Đại học xyz", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Đại học GTVT");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvDuLieu = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuThemNut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuaNut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaNut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoRong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuGom = new System.Windows.Forms.ToolStripMenuItem();
            this.lblValue = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDuLieu
            // 
            this.tvDuLieu.ContextMenuStrip = this.contextMenuStrip1;
            this.tvDuLieu.ImageIndex = 0;
            this.tvDuLieu.ImageList = this.imageList1;
            this.tvDuLieu.Location = new System.Drawing.Point(2, 3);
            this.tvDuLieu.Name = "tvDuLieu";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Khoa công nghệ thông tin";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Khoa lý luận chính trị";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Đại học cộng đồng";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "Node6";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Lớp đại học điện tử";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Khoa cơ khí ";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Đại học xyz";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Đại học GTVT";
            this.tvDuLieu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode7});
            this.tvDuLieu.SelectedImageIndex = 3;
            this.tvDuLieu.Size = new System.Drawing.Size(320, 265);
            this.tvDuLieu.TabIndex = 0;
            this.tvDuLieu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDuLieu_AfterSelect);
            this.tvDuLieu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDuLieu_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemNut,
            this.mnuSuaNut,
            this.mnuXoaNut,
            this.mnuMoRong,
            this.mnuThuGom});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 114);
            // 
            // mnuThemNut
            // 
            this.mnuThemNut.Name = "mnuThemNut";
            this.mnuThemNut.Size = new System.Drawing.Size(125, 22);
            this.mnuThemNut.Text = "Thêm nút";
            this.mnuThemNut.Click += new System.EventHandler(this.mnuThemNut_Click);
            // 
            // mnuSuaNut
            // 
            this.mnuSuaNut.Name = "mnuSuaNut";
            this.mnuSuaNut.Size = new System.Drawing.Size(125, 22);
            this.mnuSuaNut.Text = "Sửa nút";
            this.mnuSuaNut.Click += new System.EventHandler(this.mnuSuaNut_Click);
            // 
            // mnuXoaNut
            // 
            this.mnuXoaNut.Name = "mnuXoaNut";
            this.mnuXoaNut.Size = new System.Drawing.Size(125, 22);
            this.mnuXoaNut.Text = "Xóa nút";
            this.mnuXoaNut.Click += new System.EventHandler(this.mnuXoaNut_Click);
            // 
            // mnuMoRong
            // 
            this.mnuMoRong.Name = "mnuMoRong";
            this.mnuMoRong.Size = new System.Drawing.Size(125, 22);
            this.mnuMoRong.Text = "Mở rộng";
            this.mnuMoRong.Click += new System.EventHandler(this.mnuMoRong_Click);
            // 
            // mnuThuGom
            // 
            this.mnuThuGom.Name = "mnuThuGom";
            this.mnuThuGom.Size = new System.Drawing.Size(125, 22);
            this.mnuThuGom.Text = "Thu gom";
            this.mnuThuGom.Click += new System.EventHandler(this.mnuThuGom_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(320, 22);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(76, 25);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "label1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "audiForm.png");
            this.imageList1.Images.SetKeyName(1, "audiTrang.png");
            this.imageList1.Images.SetKeyName(2, "mercHong.png");
            this.imageList1.Images.SetKeyName(3, "mercDen.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 323);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.tvDuLieu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDuLieu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNut;
        private System.Windows.Forms.ToolStripMenuItem mnuSuaNut;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaNut;
        private System.Windows.Forms.ToolStripMenuItem mnuMoRong;
        private System.Windows.Forms.ToolStripMenuItem mnuThuGom;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ImageList imageList1;
    }
}


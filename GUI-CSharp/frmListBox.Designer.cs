
namespace GUI_CSharp
{
    partial class frmListBox
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
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTongDanhSach = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapSo.Location = new System.Drawing.Point(12, 35);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(100, 24);
            this.lblNhapSo.TabIndex = 0;
            this.lblNhapSo.Text = "Nhập số: ";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(118, 38);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(353, 20);
            this.txtSo.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(477, 31);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(105, 33);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 303);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách số";
            // 
            // lstSo
            // 
            this.lstSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 24;
            this.lstSo.Location = new System.Drawing.Point(3, 25);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSo.Size = new System.Drawing.Size(225, 275);
            this.lstSo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLe);
            this.groupBox2.Controls.Add(this.btnBinhPhuong);
            this.groupBox2.Controls.Add(this.btnChan);
            this.groupBox2.Controls.Add(this.btnTang2);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox2.Controls.Add(this.btnTongDanhSach);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(263, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 303);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chức năng";
            // 
            // btnTongDanhSach
            // 
            this.btnTongDanhSach.Location = new System.Drawing.Point(6, 28);
            this.btnTongDanhSach.Name = "btnTongDanhSach";
            this.btnTongDanhSach.Size = new System.Drawing.Size(307, 33);
            this.btnTongDanhSach.TabIndex = 0;
            this.btnTongDanhSach.Text = "Tổng của danh sách";
            this.btnTongDanhSach.UseVisualStyleBackColor = true;
            this.btnTongDanhSach.Click += new System.EventHandler(this.btnTongDanhSach_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(6, 67);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(307, 33);
            this.btnXoaDauCuoi.TabIndex = 0;
            this.btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(6, 106);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(307, 33);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa phần tử đang chọn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(6, 145);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(307, 33);
            this.btnTang2.TabIndex = 0;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(6, 223);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(307, 33);
            this.btnChan.TabIndex = 0;
            this.btnChan.Text = "Chọn số chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(6, 184);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(307, 33);
            this.btnBinhPhuong.TabIndex = 0;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(6, 262);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(307, 33);
            this.btnLe.TabIndex = 0;
            this.btnLe.Text = "Chọn số lẻ";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(15, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(567, 53);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Kết thúc chương trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 461);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblNhapSo);
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTongDanhSach;
        private System.Windows.Forms.Button btnThoat;
    }
}
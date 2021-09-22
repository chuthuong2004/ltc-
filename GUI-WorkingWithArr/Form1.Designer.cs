
namespace GUI_WorkingWithArr
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMangGoc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnXuatMangNgauNhien = new System.Windows.Forms.Button();
            this.btnTinhTongGiaTriMang = new System.Windows.Forms.Button();
            this.btnDemSoPhanTuLe = new System.Windows.Forms.Button();
            this.btnTongGiaTriPhanTuLe = new System.Windows.Forms.Button();
            this.btnTimMoiPhanTuNhoNhat = new System.Windows.Forms.Button();
            this.btnTangMoiPhanTuLen2 = new System.Windows.Forms.Button();
            this.btnSapXepTang = new System.Windows.Forms.Button();
            this.btnSapXepGiam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMangGoc);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(4, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng gốc:";
            // 
            // txtMangGoc
            // 
            this.txtMangGoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMangGoc.Location = new System.Drawing.Point(3, 25);
            this.txtMangGoc.Name = "txtMangGoc";
            this.txtMangGoc.Size = new System.Drawing.Size(605, 29);
            this.txtMangGoc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(4, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKetQua.Location = new System.Drawing.Point(3, 25);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(605, 29);
            this.txtKetQua.TabIndex = 1;
            // 
            // btnXuatMangNgauNhien
            // 
            this.btnXuatMangNgauNhien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatMangNgauNhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatMangNgauNhien.Location = new System.Drawing.Point(12, 198);
            this.btnXuatMangNgauNhien.Name = "btnXuatMangNgauNhien";
            this.btnXuatMangNgauNhien.Size = new System.Drawing.Size(283, 38);
            this.btnXuatMangNgauNhien.TabIndex = 2;
            this.btnXuatMangNgauNhien.Text = "Xuất mảng ngẫu nhiên";
            this.btnXuatMangNgauNhien.UseVisualStyleBackColor = false;
            this.btnXuatMangNgauNhien.Click += new System.EventHandler(this.btnXuatMangNgauNhien_Click);
            // 
            // btnTinhTongGiaTriMang
            // 
            this.btnTinhTongGiaTriMang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTinhTongGiaTriMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTongGiaTriMang.Location = new System.Drawing.Point(12, 242);
            this.btnTinhTongGiaTriMang.Name = "btnTinhTongGiaTriMang";
            this.btnTinhTongGiaTriMang.Size = new System.Drawing.Size(283, 38);
            this.btnTinhTongGiaTriMang.TabIndex = 2;
            this.btnTinhTongGiaTriMang.Text = "Tính tổng giá trị mảng";
            this.btnTinhTongGiaTriMang.UseVisualStyleBackColor = false;
            this.btnTinhTongGiaTriMang.Click += new System.EventHandler(this.btnTinhTongGiaTriMang_Click);
            // 
            // btnDemSoPhanTuLe
            // 
            this.btnDemSoPhanTuLe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDemSoPhanTuLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemSoPhanTuLe.Location = new System.Drawing.Point(12, 286);
            this.btnDemSoPhanTuLe.Name = "btnDemSoPhanTuLe";
            this.btnDemSoPhanTuLe.Size = new System.Drawing.Size(283, 38);
            this.btnDemSoPhanTuLe.TabIndex = 2;
            this.btnDemSoPhanTuLe.Text = "Đếm số phần tử lẻ";
            this.btnDemSoPhanTuLe.UseVisualStyleBackColor = false;
            this.btnDemSoPhanTuLe.Click += new System.EventHandler(this.btnDemSoPhanTuLe_Click);
            // 
            // btnTongGiaTriPhanTuLe
            // 
            this.btnTongGiaTriPhanTuLe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTongGiaTriPhanTuLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongGiaTriPhanTuLe.Location = new System.Drawing.Point(12, 330);
            this.btnTongGiaTriPhanTuLe.Name = "btnTongGiaTriPhanTuLe";
            this.btnTongGiaTriPhanTuLe.Size = new System.Drawing.Size(283, 38);
            this.btnTongGiaTriPhanTuLe.TabIndex = 2;
            this.btnTongGiaTriPhanTuLe.Text = "Tổng giá trị phần tử lẻ";
            this.btnTongGiaTriPhanTuLe.UseVisualStyleBackColor = false;
            this.btnTongGiaTriPhanTuLe.Click += new System.EventHandler(this.btnTongGiaTriPhanTuLe_Click);
            // 
            // btnTimMoiPhanTuNhoNhat
            // 
            this.btnTimMoiPhanTuNhoNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTimMoiPhanTuNhoNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMoiPhanTuNhoNhat.Location = new System.Drawing.Point(321, 198);
            this.btnTimMoiPhanTuNhoNhat.Name = "btnTimMoiPhanTuNhoNhat";
            this.btnTimMoiPhanTuNhoNhat.Size = new System.Drawing.Size(283, 38);
            this.btnTimMoiPhanTuNhoNhat.TabIndex = 2;
            this.btnTimMoiPhanTuNhoNhat.Text = "Tìm mỗi phần tử nhỏ nhất";
            this.btnTimMoiPhanTuNhoNhat.UseVisualStyleBackColor = false;
            this.btnTimMoiPhanTuNhoNhat.Click += new System.EventHandler(this.btnTimMoiPhanTuNhoNhat_Click);
            // 
            // btnTangMoiPhanTuLen2
            // 
            this.btnTangMoiPhanTuLen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTangMoiPhanTuLen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangMoiPhanTuLen2.Location = new System.Drawing.Point(321, 242);
            this.btnTangMoiPhanTuLen2.Name = "btnTangMoiPhanTuLen2";
            this.btnTangMoiPhanTuLen2.Size = new System.Drawing.Size(283, 38);
            this.btnTangMoiPhanTuLen2.TabIndex = 2;
            this.btnTangMoiPhanTuLen2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangMoiPhanTuLen2.UseVisualStyleBackColor = false;
            this.btnTangMoiPhanTuLen2.Click += new System.EventHandler(this.btnTangMoiPhanTuLen2_Click);
            // 
            // btnSapXepTang
            // 
            this.btnSapXepTang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSapXepTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXepTang.Location = new System.Drawing.Point(321, 286);
            this.btnSapXepTang.Name = "btnSapXepTang";
            this.btnSapXepTang.Size = new System.Drawing.Size(283, 38);
            this.btnSapXepTang.TabIndex = 2;
            this.btnSapXepTang.Text = "Sắp xếp mảng tăng";
            this.btnSapXepTang.UseVisualStyleBackColor = false;
            this.btnSapXepTang.Click += new System.EventHandler(this.btnSapXepTang_Click);
            // 
            // btnSapXepGiam
            // 
            this.btnSapXepGiam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSapXepGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXepGiam.Location = new System.Drawing.Point(321, 330);
            this.btnSapXepGiam.Name = "btnSapXepGiam";
            this.btnSapXepGiam.Size = new System.Drawing.Size(283, 38);
            this.btnSapXepGiam.TabIndex = 2;
            this.btnSapXepGiam.Text = "Sắp xếp mảng giảm";
            this.btnSapXepGiam.UseVisualStyleBackColor = false;
            this.btnSapXepGiam.Click += new System.EventHandler(this.btnSapXepGiam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(616, 382);
            this.Controls.Add(this.btnSapXepGiam);
            this.Controls.Add(this.btnTongGiaTriPhanTuLe);
            this.Controls.Add(this.btnSapXepTang);
            this.Controls.Add(this.btnDemSoPhanTuLe);
            this.Controls.Add(this.btnTangMoiPhanTuLen2);
            this.Controls.Add(this.btnTinhTongGiaTriMang);
            this.Controls.Add(this.btnTimMoiPhanTuNhoNhat);
            this.Controls.Add(this.btnXuatMangNgauNhien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm Việc Với Mảng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMangGoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnXuatMangNgauNhien;
        private System.Windows.Forms.Button btnTinhTongGiaTriMang;
        private System.Windows.Forms.Button btnDemSoPhanTuLe;
        private System.Windows.Forms.Button btnTongGiaTriPhanTuLe;
        private System.Windows.Forms.Button btnTimMoiPhanTuNhoNhat;
        private System.Windows.Forms.Button btnTangMoiPhanTuLen2;
        private System.Windows.Forms.Button btnSapXepTang;
        private System.Windows.Forms.Button btnSapXepGiam;
    }
}


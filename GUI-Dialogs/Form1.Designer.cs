
namespace GUI_Dialogs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnChonMotHinh = new System.Windows.Forms.Button();
            this.picOpenFile = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLuu = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnDoimau = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblFont = new System.Windows.Forms.Label();
            this.btnDoiFont = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnLuuthongtin = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenFile)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picOpenFile);
            this.tabPage1.Controls.Add(this.btnChonMotHinh);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Open FileDialogs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.btnLuu);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Save FileDialogs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDoimau);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(861, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Color Dialog";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDoiFont);
            this.tabPage4.Controls.Add(this.lblFont);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(861, 389);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Font Dialog ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnLuuthongtin);
            this.tabPage5.Controls.Add(this.txtPath);
            this.tabPage5.Controls.Add(this.btnChon);
            this.tabPage5.Controls.Add(this.richTextBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(861, 389);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Folder Browser Dialog";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnChonMotHinh
            // 
            this.btnChonMotHinh.Location = new System.Drawing.Point(33, 19);
            this.btnChonMotHinh.Name = "btnChonMotHinh";
            this.btnChonMotHinh.Size = new System.Drawing.Size(256, 36);
            this.btnChonMotHinh.TabIndex = 0;
            this.btnChonMotHinh.Text = "Chọn một hình";
            this.btnChonMotHinh.UseVisualStyleBackColor = true;
            this.btnChonMotHinh.Click += new System.EventHandler(this.btnChonMotHinh_Click);
            // 
            // picOpenFile
            // 
            this.picOpenFile.Location = new System.Drawing.Point(33, 61);
            this.picOpenFile.Name = "picOpenFile";
            this.picOpenFile.Size = new System.Drawing.Size(256, 203);
            this.picOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpenFile.TabIndex = 1;
            this.picOpenFile.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(348, 242);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(145, 45);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(169, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(536, 187);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnDoimau
            // 
            this.btnDoimau.Location = new System.Drawing.Point(239, 44);
            this.btnDoimau.Name = "btnDoimau";
            this.btnDoimau.Size = new System.Drawing.Size(375, 152);
            this.btnDoimau.TabIndex = 0;
            this.btnDoimau.Text = "Đổi màu tui nè";
            this.btnDoimau.UseVisualStyleBackColor = true;
            this.btnDoimau.Click += new System.EventHandler(this.btnDoimau_Click);
            // 
            // lblFont
            // 
            this.lblFont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFont.Location = new System.Drawing.Point(174, 18);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(489, 152);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Vô thường";
            this.lblFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDoiFont
            // 
            this.btnDoiFont.Location = new System.Drawing.Point(355, 213);
            this.btnDoiFont.Name = "btnDoiFont";
            this.btnDoiFont.Size = new System.Drawing.Size(105, 68);
            this.btnDoiFont.TabIndex = 1;
            this.btnDoiFont.Text = "Đổi font";
            this.btnDoiFont.UseVisualStyleBackColor = true;
            this.btnDoiFont.Click += new System.EventHandler(this.btnDoiFont_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(199, 36);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(448, 96);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(706, 203);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(44, 34);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "...";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(21, 209);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(639, 31);
            this.txtPath.TabIndex = 3;
            // 
            // btnLuuthongtin
            // 
            this.btnLuuthongtin.Location = new System.Drawing.Point(236, 280);
            this.btnLuuthongtin.Name = "btnLuuthongtin";
            this.btnLuuthongtin.Size = new System.Drawing.Size(263, 53);
            this.btnLuuthongtin.TabIndex = 4;
            this.btnLuuthongtin.Text = "Lưu thông tin";
            this.btnLuuthongtin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 427);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox picOpenFile;
        private System.Windows.Forms.Button btnChonMotHinh;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDoimau;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnDoiFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnLuuthongtin;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


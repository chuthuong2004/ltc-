﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonMotHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Tất cả|*.*|Tập tin .png|*.png|Tập tin .jpg|*.jpg|Tập tin Bitmap|*.bmp";
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                picOpenFile.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Plain text | *.txt | Tất cả | *.*";
            if (saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show("Bạn muốn lưu nội dung vào: "+saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Bạn không lưu");
            }
        }

        private void btnDoimau_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = btnDoimau.BackColor;
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                btnDoimau.BackColor = colorDialog1.Color;
            }
        }

        private void btnDoiFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = lblFont.Font;
            if (fontDialog1.ShowDialog()== DialogResult.OK)
            {
                lblFont.Font = fontDialog1.Font;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}

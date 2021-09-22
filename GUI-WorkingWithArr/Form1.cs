using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_WorkingWithArr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] M;
        Random random = new Random();

        private void btnXuatMangNgauNhien_Click(object sender, EventArgs e)
        {
            M = new int[10];
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = random.Next(100);
            }
            HienThiMangLenTextBox(M,txtMangGoc);
        }
        void HienThiMangLenTextBox(int []M, TextBox txt)
        {
            txt.Text = "";
            foreach (int x in M)
            {
                txt.Text += x + "  ";
            }
        }

        private void btnTinhTongGiaTriMang_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < M.Length; i++)
            {
                sum += M[i];
            }
            txtKetQua.Text = "Tổng mảng = "+sum;
        }

        private void btnDemSoPhanTuLe_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (int x in M)
            {
                if (x % 2 !=0)
                {
                    count++;
                }
            }
            txtKetQua.Text = "Số phần tử lẻ = " + count;
        }

        private void btnTongGiaTriPhanTuLe_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "";
            int sum = 0;
            foreach (int x in M)
            {
                if (x % 2 != 0)
                {
                    sum+= x;
                }
            }
            txtKetQua.Text = "Tổng số phần tử lẻ = " + sum;
        }

        private void btnTimMoiPhanTuNhoNhat_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "";
            int min = M[0];
            for (int i = 0; i < M.Length; i++)
            {
                if (M[i] < min)
                {
                    min = M[i];
                }
            }
            txtKetQua.Text = "Phần tử nhỏ nhất = " + min;
        }

        private void btnTangMoiPhanTuLen2_Click(object sender, EventArgs e)
        {
            HienThiMangLenTextBox(M, txtMangGoc);
            for (int i = 0; i < M.Length; i++)
            {
                M[i] += 2;
            }
            HienThiMangLenTextBox(M, txtKetQua);
        }

        private void btnSapXepTang_Click(object sender, EventArgs e)
        {
            HienThiMangLenTextBox(M, txtMangGoc);
            Array.Sort(M);
            HienThiMangLenTextBox(M, txtKetQua);
        }

        private void btnSapXepGiam_Click(object sender, EventArgs e)
        {
            HienThiMangLenTextBox(M, txtMangGoc);
            Array.Sort(M);
            Array.Reverse(M);
            HienThiMangLenTextBox(M, txtKetQua);
        }
    }
}

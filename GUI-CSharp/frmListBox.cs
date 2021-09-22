using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CSharp
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtSo.Text);
            lstSo.Items.Add(x);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);

        }

        private void btnTongDanhSach_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                sum += (int)lstSo.Items[i];
            }
            MessageBox.Show("Tổng các phần tử bằng " + sum);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // ta phải luôn luôn kiểm tra  người sd có đang chọn dòng nào hay không
            //if (lstSo.SelectedIndex != -1)
            //{
            //    lstSo.Items.RemoveAt(lstSo.SelectedIndex);
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn phần tử cần xóa");
            //}

            while (lstSo.SelectedIndices.Count >0)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[0]);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                lstSo.Items[i] = (int)lstSo.Items[i] + 2;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                x = x * x;
                lstSo.Items[i] = x;
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1; // bỏ chọn các dòng
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                if ((int)lstSo.Items[i] % 2 == 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1; // bỏ chọn các dòng
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                if ((int)lstSo.Items[i] % 2 != 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

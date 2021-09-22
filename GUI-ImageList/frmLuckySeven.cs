using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ImageList
{
    public partial class frmLuckySeven : Form
    {
        public frmLuckySeven()
        {
            InitializeComponent();
        }
        int tienMay = 100;
        int tienNguoi = 100;
        int count = 0;
        Random ran = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int so1 = ran.Next(9);
            int so2 = ran.Next(10);
            int so3 = ran.Next(11);
            lbl1.Text = so1 + "";
            lbl2.Text = so2 + "";
            lbl3.Text = so3 + "";
            if (count > 50)
            {
                if (so1 == 7)
                {
                    tienNguoi = tienNguoi + 100 + (tienMay / 2);
                    tienMay = tienMay / 2;
                }
                if (so2 == 7)
                {
                    tienNguoi = tienNguoi + 30 + (tienMay / 2);
                    tienMay = tienMay / 2;
                }
                if (so3 == 7)
                    tienNguoi += 10;
                lblTienMay.Text = tienMay + "";
                lblTienNguoiChoi.Text = tienNguoi + "";
                timer1.Stop();
            }
            count++;
        }

        private void btnQuay_Click(object sender, EventArgs e)
        {
            if (tienNguoi < 30)
            {
                MessageBox.Show("Bạn lỗ sấp mặt lợn rồi ! Không được chơi nữa");
                return;
            }
            tienNguoi = tienNguoi - 30;
            tienMay = tienMay + 30;
            count = 0;
            lblTienNguoiChoi.Text = tienNguoi + "";
            lblTienMay.Text = tienMay + "";
            timer1.Start();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            lbl1.Text = 7 + "";
            lbl2.Text = 7 + "";
            lbl3.Text = 7 + "";
            lblTienMay.Text = 100 + "";
            lblTienNguoiChoi.Text = 100 + "";
            tienNguoi = 100;
            tienMay = 100;
        }

        private void frmLuckySeven_Load(object sender, EventArgs e)
        {

        }

        private void frmLuckySeven_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình",
                "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (result == DialogResult.No);
        }
    }
}

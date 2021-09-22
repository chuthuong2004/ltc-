using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DatVeXemPhim
{
    public partial class Form1 : Form
    {
        List<Customer> dsKhachHang = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XuLyVe100GheLenGiaoDien();
        }

        private void XuLyVe100GheLenGiaoDien()
        {
            pnGhe.Controls.Clear();
            int ghe = 1;
            for (int i = 0; i < pnGhe.RowCount; i++)
            {
                for (int j = 0; j < pnGhe.ColumnCount; j++)
                {
                    Label lblGhe = new Label();
                    lblGhe.Text = ghe + "";
                    lblGhe.AutoSize = false;
                    lblGhe.Dock = DockStyle.Fill;
                    lblGhe.TextAlign = ContentAlignment.MiddleCenter;
                    lblGhe.Width = lblGhe.Height = 50;
                    lblGhe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    pnGhe.Controls.Add(lblGhe, j, i);
                    ghe++;
                    lblGhe.Click += LblGhe_Click;
                }
            }
        }

        private void LblGhe_Click(object sender, EventArgs e)
        {
            Label lblGhe = sender as Label;
            if (lblGhe.BackColor == Color.White)
            {
                lblGhe.BackColor = Color.Green;
                lblGhe.ForeColor = Color.White;
                lblGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }
            else if (lblGhe.BackColor == Color.Green)
            {
                lblGhe.BackColor = Color.White;
                lblGhe.ForeColor = Color.Olive;
            }
            else if (lblGhe.BackColor == Color.Yellow)
            {
                DialogResult ret = MessageBox.Show("Ghế số [" + lblGhe.Text + "] đã có người đặt !",
                    "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {

            frmThongTinNguoiDatVe frm = new frmThongTinNguoiDatVe();
            int count = 0;
            for (int j = 0; j < pnGhe.Controls.Count; j++)
            {
                Label lbl = pnGhe.Controls[j] as Label;
                if (lbl.BackColor == Color.Green)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                DialogResult rets = MessageBox.Show("Vui lòng chọn ghế cần đặt !",
               "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Customer cus = new Customer();
                    cus.Name = frm.txtHoTen.Text;
                    cus.Phone = frm.txtPhone.Text;
                    cus.GioDatGhe = DateTime.Now;
                    for (int i = 0; i < pnGhe.Controls.Count; i++)
                    {
                        Label lblGhe = pnGhe.Controls[i] as Label;
                        if (lblGhe.BackColor == Color.Green)
                        {
                            lblGhe.BackColor = Color.Yellow;
                            lblGhe.ForeColor = Color.Black;
                            lblGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            int ghe = int.Parse(lblGhe.Text);
                            cus.Ghes.Add(ghe);
                        }
                    }
                    //lblGiaVe.Text = cus.GiaVe + " VNĐ";
                    lblSoLuong.Text = cus.SoLuong + "";
                    lblThanhTien.Text = cus.TinhTien + ".000 VNĐ";
                    dsKhachHang.Add(cus);
                    HienThiTongTien();
                    HienThiThongTinLenListBox();
                }
            }
        }

        private void HienThiThongTinLenListBox()
        {
            lstKhachHang.Items.Clear();
            foreach (Customer cus in dsKhachHang)
            {
                lstKhachHang.Items.Add(cus);
            }
        }
        private void HienThiTongTien()
        {
            int sum = 0;
            foreach (Customer cus in dsKhachHang)
            {
                sum += cus.TinhTien;
            }
            lblTongThanhTien.Text = sum + ".000 VNĐ";
        }

        private void lstKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKhachHang.SelectedIndex != -1)
            {
                Customer cus = lstKhachHang.SelectedItem as Customer;
                lblThanhTien.Text = cus.TinhTien + ".000 VNĐ";
                lblSoLuong.Text = cus.SoLuong + "";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (lstKhachHang.SelectedIndex != -1)
            {
                Customer cus = lstKhachHang.SelectedItem as Customer;
                DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn hủy đặt vé ?",
                "Xác nhận hủy ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    for (int i = 0; i < pnGhe.Controls.Count; i++)
                    {
                        Label lblGhe = pnGhe.Controls[i] as Label;
                        int maGhe = int.Parse(lblGhe.Text);
                        int co = 0;

                        while (cus.Ghes.Count > 0 && co < cus.Ghes.Count)
                        {
                            int gheDat = cus.Ghes[0];
                            if (maGhe == gheDat)
                            {
                                lblGhe.BackColor = Color.White;
                                lblGhe.ForeColor = Color.Olive;
                                lblGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                cus.Ghes.Remove(maGhe);
                            }
                            co++;
                        }
                    }
                    DialogResult res = MessageBox.Show("Hủy vé thành công !",
                       "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsKhachHang.Remove(cus);
                    HienThiThongTinLenListBox();
                    lblSoLuong.Text = "";
                    lblThanhTien.Text = "0.000 VNĐ";
                    HienThiTongTien();
                }
            }
            else
            {
                DialogResult ret = MessageBox.Show("Vui lòng chọn khách hàng cần hủy ?",
                    "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình ?",
              "Xác nhận thoát ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lstKhachHang_DoubleClick(object sender, EventArgs e)
        {
            Form frmKhachHang = new Form();
            frmKhachHang.Text = "Thông tin chi tiết khách hàng";
            frmKhachHang.Width = frmKhachHang.Height = 500;
            ListBox lstKhachHang = new ListBox();
            frmKhachHang.Controls.Add(lstKhachHang);
            frmKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lstKhachHang.Dock = DockStyle.Fill;
            frmKhachHang.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frmKhachHang.Show();
            lstKhachHang.Items.Clear();
            foreach (Customer cuss in dsKhachHang)
            {
                lstKhachHang.Items.Add("Họ và tên: [ "+cuss.Name +" ] - Số điện thoại: [ "+cuss.Phone+
                    " ] - Thời gian đặt vé: [ "+cuss.GioDatGhe+" ]");
            }
        }
    }
}

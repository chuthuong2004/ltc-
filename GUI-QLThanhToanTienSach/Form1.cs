using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLThanhToanTienSach
{
    public partial class Form1 : Form
    {
        DanhSachKhachHang database = new DanhSachKhachHang();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
           
            if (txtTen.Text != "" && txtSoLuong.Text !="")
            {
                KhachHang kh = new KhachHang();
                kh.TenKhachHang = txtTen.Text;
                kh.SoLuongMua = int.Parse(txtSoLuong.Text);
                kh.LaSinhVien = chkSinhVien.Checked;
                errorProvider1.SetError(txtTen, "");
                database.Mua(kh);
                lblThanhTien.Text = kh.TinhTien + " VNĐ";
            }
            else
            {
                DialogResult ret = MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo lỗi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txtTen, "Vui lòng nhập tên");
                errorProvider1.SetError(txtSoLuong, "Vui lòng nhập số lượng");
            }
            

        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtSoLuong.Text = "";
            chkSinhVien.Checked = false;
            lblThanhTien.Text = "";
            txtTen.Focus();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            txtTongSoKhachHang.Text = database.TongSoKhachHang + "";
            txtTongSoKHSinhVien.Text = database.TongSoKhachHangLaSinhVien + "";
            txtDoanhThu.Text = database.TongDoanhThu + " VNĐ";
        }

        private void txtTongSoKhachHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frmKhachHang = new Form();
            frmKhachHang.Width = frmKhachHang.Height = 300;
            ListBox lstKhachHang = new ListBox();
            frmKhachHang.Controls.Add(lstKhachHang);
            lstKhachHang.Dock = DockStyle.Fill;
            frmKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foreach (KhachHang khach in database.khachs)
            {
                lstKhachHang.Items.Add(khach.TenKhachHang);
            }
            frmKhachHang.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frmKhachHang.Show();
        }

        private void txtTongSoKHSinhVien_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frmKhachHang = new Form();
            frmKhachHang.Width = frmKhachHang.Height = 300;
            ListBox lstKhachHang = new ListBox();
            frmKhachHang.Controls.Add(lstKhachHang);
            frmKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lstKhachHang.Dock = DockStyle.Fill;
            foreach (KhachHang khach in database.khachs)
            {
                if (khach.LaSinhVien == true)
                {
                    lstKhachHang.Items.Add(khach.TenKhachHang);
                }
            }
            frmKhachHang.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frmKhachHang.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có thật sự muốn thoát " +
                "chương trình", "Thông báo thoát", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            Regex regexSoLuong = new Regex("^[0-9]+$");
            bool result = regexSoLuong.IsMatch(txtTen.Text);
            if (result == false)
            {
                errorProvider1.SetError(txtTen, "");
            }
            else
            {
                errorProvider1.SetError(txtTen, "Vui lòng nhập đúng tên của bạn.");
            }
        }
          
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            Regex regexSoLuong = new Regex(@"^\d+$");
            //Regex regexSoLuong = new Regex(@"^03|09\d+$");

            bool result = regexSoLuong.IsMatch(txtSoLuong.Text);
            if (result == true)
            {
                errorProvider1.SetError(txtSoLuong, "");

            }
            else
            {
                errorProvider1.SetError(txtSoLuong, "Vui lòng nhập đúng số lượng.");

            }
        }
    }
}

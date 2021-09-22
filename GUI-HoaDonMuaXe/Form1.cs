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

namespace GUI_HoaDonMuaXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DanhSachKhachHang database = new DanhSachKhachHang();
        static int count = 1;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Regex regexName = new Regex("^[0-9]+$");
            bool resultName = regexName.IsMatch(txtHoTen.Text);
            Regex regexDiaChi = new Regex("^[0-9]+$");
            bool resultDiaChi = regexDiaChi.IsMatch(txtDiaChi.Text);
            Regex regexPhone = new Regex(@"^03|09\d+$");
            bool resultPhone = regexPhone.IsMatch(txtPhone.Text);
            Regex regexSoLuong = new Regex(@"^\d+$");
            bool resultSoLuong = regexSoLuong.IsMatch(txtGiaTien.Text);

            if (txtHoTen.Text == "")
            {
                DialogResult ret = MessageBox.Show("Vui lòng nhập họ tên !", "Thông báo lỗi",
                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập họ tên.");
            }
            else if (txtDiaChi.Text == "")
            {
                DialogResult ret = MessageBox.Show("Vui lòng nhập địa chỉ !", "Thông báo lỗi",
                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txtDiaChi, "Vui lòng nhập địa chỉ.");
            }
            else if (txtPhone.Text == "")
            {
                DialogResult ret = MessageBox.Show("Vui lòng nhập số điện thoại !", "Thông báo lỗi",
                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txtPhone, "Vui lòng nhập số điện thoại.");
            }
            else if (txtGiaTien.Text == "")
            {
                DialogResult ret = MessageBox.Show("Vui lòng nhập giá tiền !", "Thông báo lỗi",
                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txtGiaTien, "Vui lòng nhập giá tiền.");
            }
            else if (radMauDen.Checked == false && radMauKhac.Checked == false)
            {
                DialogResult ret = MessageBox.Show("Vui lòng chọn màu xe !", "Thông báo lỗi",
                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (resultName == false)
                    if (resultDiaChi == false)
                        if (resultPhone == true && txtPhone.Text.Length == 10)
                            if (resultSoLuong == true)
                            {
                                KhachHang kh = new KhachHang();
                                kh.TenKhachHang = txtHoTen.Text;
                                kh.DiaChi = txtDiaChi.Text;
                                kh.SoDienThoai = txtPhone.Text;
                                kh.GiaTien = double.Parse(txtGiaTien.Text);
                                kh.HangXe = cboHangXe.Text;
                                if (radMauDen.Checked == true)
                                {
                                    kh.XeMauDen = radMauDen.Checked;
                                }
                                if (count == 1)
                                {
                                    database.Mua(kh);
                                    DialogResult ret = MessageBox.Show("Thanh toán thành công !", "Thông báo ",
                                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lblThanhTien.Text = kh.ThanhToan + " VNĐ";
                                    count++;
                                }
                                else
                                {
                                    DialogResult ret = MessageBox.Show("Vui lòng nhập thông tin mới !", "Thông báo ",
                                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                DialogResult ret = MessageBox.Show("Vui lòng nhập đúng thông tin !", "Thông báo ",
                                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        else
                        {
                            DialogResult ret = MessageBox.Show("Vui lòng nhập đúng thông tin !", "Thông báo ",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    else
                    {
                        DialogResult ret = MessageBox.Show("Vui lòng nhập đúng thông tin !", "Thông báo ",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                else
                {
                    DialogResult ret = MessageBox.Show("Vui lòng nhập đúng thông tin !", "Thông báo ",
                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            Regex regexName = new Regex("^[0-9]+$");
            bool resultName = regexName.IsMatch(txtHoTen.Text);
            if (resultName == false)
            {
                errorProvider1.SetError(txtHoTen, "");
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập đúng họ và tên.");
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            Regex regexDiaChi = new Regex("^[0-9]+$");
            bool resultDiaChi = regexDiaChi.IsMatch(txtDiaChi.Text);
            if (resultDiaChi == false)
            {
                errorProvider1.SetError(txtDiaChi, "");
            }
            else
            {
                errorProvider1.SetError(txtDiaChi, "Vui lòng nhập đúng địa chỉ.");
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            Regex regexPhone = new Regex(@"^03|09\d+$");
            bool resultPhone = regexPhone.IsMatch(txtPhone.Text);
            if (resultPhone == true && txtPhone.Text.Length == 10)
            {
                errorProvider1.SetError(txtPhone, "");
            }
            else
            {
                errorProvider1.SetError(txtPhone, "Vui lòng nhập đúng số điện thoại ! Chỉ nhận đầu số 03,09");
            }
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            Regex regexSoLuong = new Regex(@"^\d+$");
            bool result = regexSoLuong.IsMatch(txtGiaTien.Text);
            if (result == true)
            {
                errorProvider1.SetError(txtGiaTien, "");
                if (radMauDen.Checked)
                {
                    lblPhuThu.Text = double.Parse(txtGiaTien.Text) * 0.05 + " VNĐ";
                    lblThue.Text = double.Parse(txtGiaTien.Text) * 0.2 + " VNĐ";
                }
                if (radMauKhac.Checked)
                {
                    lblPhuThu.Text = "0 VNĐ";
                    lblThue.Text = double.Parse(txtGiaTien.Text) * 0.2 + " VNĐ";
                }
            }
            else
            {
                errorProvider1.SetError(txtGiaTien, "Vui lòng nhập đúng giá tiền.");
            }
            if (txtGiaTien.Text == "")
            {
                errorProvider1.SetError(txtGiaTien, "");
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            count = 1;
            errorProvider1.Clear();
            errorProvider1.SetError(txtHoTen, "");
            errorProvider1.SetError(txtDiaChi, "");
            errorProvider1.SetError(txtPhone, "");
            errorProvider1.SetError(txtGiaTien, "");
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtPhone.Text = "";
            txtGiaTien.Text = "";
            lblPhuThu.Text = "";
            lblThue.Text = "20%";
            lblThanhTien.Text = "";
            radMauDen.Checked = false;
            radMauKhac.Checked = false;
            txtHoTen.Focus();
        }

        private void radMauDen_Click(object sender, EventArgs e)
        {
            if (cboHangXe.Text == "Toyota")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = true;
                picToyotaTrang.Visible = false;
                picHyundai.Visible = false;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = false;
                picAudi.Visible = false;
                picAudiDen.Visible = false;
                picAudiTrang.Visible = false;
                picMerc.Visible = false;
                picMercTrang.Visible = false;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
            if (cboHangXe.Text == "Hyundai")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = false;
                picAudi.Visible = false;
                picAudiTrang.Visible = false;
                picAudiDen.Visible = false;
                picHyundai.Visible = false;
                picHyundaiTrang.Visible = false;
                picHyundaiDen.Visible = true;
                picMerc.Visible = false;
                picMercTrang.Visible = false;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
            if (cboHangXe.Text == "Audi")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = false;
                picHyundai.Visible = false;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = false;
                picAudi.Visible = false;
                picAudiTrang.Visible = false;
                picAudiDen.Visible = true;
                picMerc.Visible = false;
                picMercTrang.Visible = false;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
            if (cboHangXe.Text == "Mercesdes")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = false;
                picHyundai.Visible = false;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = false;
                picAudi.Visible = false;
                picAudiTrang.Visible = false;
                picAudiDen.Visible = false;
                picMerc.Visible = false;
                picMercTrang.Visible = false;
                picMercDen.Visible = true;
                picForm.Visible = false;
            }
            if (txtGiaTien.Text != "")
            {
                lblPhuThu.Text = double.Parse(txtGiaTien.Text) * 0.05 + " VNĐ";
                lblThue.Text = double.Parse(txtGiaTien.Text) * 0.2 + " VNĐ";
            }
        }

        private void radMauKhac_Click(object sender, EventArgs e)
        {
            if (cboHangXe.Text == "Toyota")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = true;
                picHyundai.Visible = false;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = false;
                picAudi.Visible = false;
                picAudiDen.Visible = false;
                picAudiTrang.Visible = false;
                picMerc.Visible = false;
                picMercTrang.Visible = false;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
            if (cboHangXe.Text == "Hyundai")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = false;
                picHyundai.Visible = false;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = true;
                picAudi.Visible = false;
                picAudiDen.Visible = false;
                picAudiTrang.Visible = false;
                picMerc.Visible = false;
                picMercTrang.Visible = false;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
            if (cboHangXe.Text == "Audi")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = false;
                picHyundai.Visible = false;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = false;
                picAudi.Visible = false;
                picAudiDen.Visible = false;
                picAudiTrang.Visible = true;
                picMerc.Visible = false;
                picMercTrang.Visible = false;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
            if (cboHangXe.Text == "Mercesdes")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = false;
                picHyundai.Visible = false;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = false;
                picAudi.Visible = false;
                picAudiDen.Visible = false;
                picAudiTrang.Visible = false;
                picMerc.Visible = false;
                picMercTrang.Visible = true;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
            if (txtGiaTien.Text != "")
            {
                lblPhuThu.Text = "0 VNĐ";
                lblThue.Text = double.Parse(txtGiaTien.Text) * 0.2 + " VNĐ";
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lblTongKhachHang.Text = database.TongSoKhachHang + "";
            lblTongKhachHangMuaXeDen.Text = database.TongSoKhachHangMuaXeDen + "";
            lblTongDoanhThu.Text = database.TongDoanhThu + " VNĐ";
        }

        private void lblTongKhachHang_Click(object sender, EventArgs e)
        {
            Form frmKhachHang = new Form();
            frmKhachHang.Text = "Thông Tin Khách Hàng";
            frmKhachHang.Width = frmKhachHang.Height = 400;
            ListBox lstKhachHang = new ListBox();
            frmKhachHang.Controls.Add(lstKhachHang);
            frmKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lstKhachHang.Dock = DockStyle.Fill;
            foreach (KhachHang khach in database.khachs)
            {
                lstKhachHang.Items.Add("Họ và tên: [ " + khach.TenKhachHang + " ] " +
                    "- Số điện thoại: [ " + khach.SoDienThoai + " ] - Địa chỉ: [ " + khach.DiaChi + " ] - Hãng xe: [ " + khach.HangXe + " ] - Màu xe: [ " + khach.MauXe + " ]");
            }
            frmKhachHang.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frmKhachHang.ShowDialog();
        }

        private void lblTongKhachHangMuaXeDen_Click(object sender, EventArgs e)
        {
            Form frmKhachHang = new Form();
            frmKhachHang.Text = "Thông Tin Khách Hàng Mua Xe Màu Đen";
            frmKhachHang.Width = frmKhachHang.Height = 400;
            ListBox lstKhachHang = new ListBox();
            frmKhachHang.Controls.Add(lstKhachHang);
            frmKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lstKhachHang.Dock = DockStyle.Fill;
            foreach (KhachHang khach in database.khachs)
            {
                if (khach.XeMauDen == true)
                {
                    lstKhachHang.Items.Add("Họ và tên: [ " + khach.TenKhachHang + " ] " +
                    "- Số điện thoại: [ " + khach.SoDienThoai + " ] - Địa chỉ: [ " + khach.DiaChi + " ] - Hãng xe: [ " + khach.HangXe + " ] - Màu xe: [ " + khach.MauXe + " ]");
                }
            }
            frmKhachHang.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frmKhachHang.ShowDialog();
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

        private void cboHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboHangXe_TextChanged(object sender, EventArgs e)
        {
            if (cboHangXe.Text == "Toyota")
            {
                picToyota.Visible = true;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = false;
                picHyundai.Visible = false;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = false;
                picAudi.Visible = false;
                picAudiDen.Visible = false;
                picAudiTrang.Visible = false;
                picMerc.Visible = false;
                picMercTrang.Visible = false;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
            if (cboHangXe.Text == "Mercesdes")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = false;
                picHyundai.Visible = false;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = false;
                picAudi.Visible = false;
                picAudiDen.Visible = false;
                picAudiTrang.Visible = false;
                picMerc.Visible = true;
                picMercTrang.Visible = false;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
            if (cboHangXe.Text == "Hyundai")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = false;
                picHyundai.Visible = true;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = false;
                picAudi.Visible = false;
                picAudiDen.Visible = false;
                picAudiTrang.Visible = false;
                picMerc.Visible = false;
                picMercTrang.Visible = false;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
            if (cboHangXe.Text == "Audi")
            {
                picToyota.Visible = false;
                picToyotaDen.Visible = false;
                picToyotaTrang.Visible = false;
                picHyundai.Visible = false;
                picHyundaiDen.Visible = false;
                picHyundaiTrang.Visible = false;
                picAudi.Visible = true;
                picAudiDen.Visible = false;
                picAudiTrang.Visible = false;
                picMerc.Visible = false;
                picMercTrang.Visible = false;
                picMercDen.Visible = false;
                picForm.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picHyundai.Visible = false;
            picHyundaiTrang.Visible = false;
            picHyundaiDen.Visible = false;
            picToyota.Visible = false;
            picToyotaTrang.Visible = false;
            picToyotaDen.Visible = false;
            picAudi.Visible = false;
            picAudiTrang.Visible = false;
            picAudiDen.Visible = false;
            picMerc.Visible = false;
            picMercTrang.Visible = false;
            picMercDen.Visible = false;
            picForm.Visible = true;
        }
    }
}


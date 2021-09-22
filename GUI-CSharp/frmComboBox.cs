using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI_CSharp
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            Regex regexName = new Regex("^[0-9]+$");
            bool resultName = regexName.IsMatch(txtTen.Text);
            Regex regexPhone = new Regex(@"^03|09\d+$");
            bool resultPhone = regexPhone.IsMatch(txtPhone.Text);
            errorProvider1.SetError(txtTen, "");
            errorProvider1.SetError(txtPhone, "");
            errorProvider1.SetError(lstSanPham, "");
            errorProvider1.SetError(cboThanhToan, "");
            if (txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Vui lòng nhập tên");
                return;
            }
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Vui lòng nhập số điện thoại");
                return;
            }
            if (lstSanPham.SelectedIndex == -1)
            {
                errorProvider1.SetError(lstSanPham, "Vui lòng chọn sản phẩm");
                return;
            }
            if (cboThanhToan.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboThanhToan, "Vui lòng chọn phương thức thanh toán");
                return;
            }
            string detail = "";
            if (resultName == false)
            {
                if (resultPhone == true && txtPhone.Text.Length == 10)
                {
                    detail += "Thông tin khách hàng:";
                    detail += "\n - Họ và tên: " + txtTen.Text;
                    detail += "\n - Số điện thoại: " + txtPhone.Text;
                    detail += "\n - Đơn hàng: " + lstSanPham.SelectedItem;
                    detail += "\n - Hình thức thanh toán: " + cboThanhToan.SelectedItem;
                    MessageBox.Show("Đặt hàng thành công !");
                    txtChiTiet.Text = detail;
                }
                else
                {
                    errorProvider1.SetError(txtPhone, "Vui lòng nhập đúng số điện thoại ! Chỉ nhận đầu số 03,09");
                }
            }
            else
            {
                errorProvider1.SetError(txtTen, "Vui lòng nhập đúng tên của bạn.");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            Regex regexPhone = new Regex(@"^03|09\d+$");
            bool resultPhone = regexPhone.IsMatch(txtPhone.Text);
            if (resultPhone == true && txtPhone.Text.Length == 10)
            {
                errorProvider1.SetError(txtPhone,"");
            }
            else
            {
                errorProvider1.SetError(txtPhone, "Vui lòng nhập đúng số điện thoại ! Chỉ nhận đầu số 03,09");
            }

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            Regex regexName = new Regex("^[0-9]+$");
            bool resultName = regexName.IsMatch(txtTen.Text);
            if (resultName == false)
            {
                errorProvider1.SetError(txtTen, "");
            }
            else
            {
                errorProvider1.SetError(txtTen, "Vui lòng nhập đúng họ và tên.");
            }
        }
    }
}

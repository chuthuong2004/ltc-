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

namespace GUI_DatVeXemPhim
{
    public partial class frmThongTinNguoiDatVe : Form
    {
        public frmThongTinNguoiDatVe()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Regex regexName = new Regex("^[0-9]+$");
            bool resultName = regexName.IsMatch(txtHoTen.Text);
            Regex regexPhone = new Regex(@"^03|09\d+$");
            bool resultPhone = regexPhone.IsMatch(txtPhone.Text);
            errorProvider1.SetError(txtHoTen, "");
            errorProvider1.SetError(txtPhone, "");
            if (txtHoTen.Text == "" && txtPhone.Text == "")
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập tên");
                errorProvider1.SetError(txtPhone, "Vui lòng nhập số điện thoại");
                DialogResult ret = MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo lỗi", MessageBoxButtons.OK
           , MessageBoxIcon.Exclamation);
                return;
            }
            if (resultName == false)
            {
                if (resultPhone == true && txtPhone.Text.Length == 10)
                {
                    DialogResult ret = MessageBox.Show("Đặt vé thành công !", "Thông báo", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult ret = MessageBox.Show("Đặt vé không thành công ! Vui lòng điền đúng thông tin", "Thông báo", MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                    errorProvider1.SetError(txtPhone, "Vui lòng nhập đúng số điện thoại ! Chỉ nhận đầu số 03,09");
                }
            }
            else
            {
                DialogResult ret = MessageBox.Show("Đặt vé không thành công ! Vui lòng điền đúng thông tin", "Thông báo", MessageBoxButtons.OK
           , MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập đúng tên của bạn.");

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
        }
    }
}

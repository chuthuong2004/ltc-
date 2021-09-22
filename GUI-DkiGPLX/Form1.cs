using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DkiGPLX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtName, "");
            errorProvider1.SetError(txtAge, "");
            errorProvider1.SetError(dtp, "");
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Vui lòng nhập tên");
                return;
            }
            int age = 0;
            if (int.TryParse(txtAge.Text,out age) == false)
            {
                errorProvider1.SetError(txtAge, "Tuổi nhập không đúng");
                return;
            }
            else
            {
                if (age<18)
                {
                    errorProvider1.SetError(txtAge, "Tuổi phải lớn hơn 17");
                    return;
                }
            }
            if (dtp.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                errorProvider1.SetError(dtp, "Không đăng kí vào chủ nhật");
                return;
            }
            MessageBox.Show("Đăng kí thành công");
        }
    }
}

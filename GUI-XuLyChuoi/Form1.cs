using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_XuLyChuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSoKiTuTrongChuoi_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtDuLieuGoc.Text.Length + "";
        }

        private void btnInChuHoa_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtDuLieuGoc.Text.ToUpper();
        }

        private void btnInChuThuong_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtDuLieuGoc.Text.ToLower();
        }

        private void btnDemKiTuHoa_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int count = 0;
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            txtKetQua.Text = "Có " + count + " kí tự in hoa";
        }

        private void btnDemKiTuThuong_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int count = 0;
            foreach (char c in s)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }
            txtKetQua.Text = "Có " + count + " kí tự in thường";
        }

        private void btnDemKiTuSo_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int count = 0;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            txtKetQua.Text = "Có " + count + " kí tự số";
        }

        private void btnDaoChuoi_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            List<char> s2 = s.Reverse().ToList();
            txtKetQua.Text = "";
            foreach (char c in s2)
            {
                txtKetQua.Text += c;
            }

        }

        private void btnToiUuChuoi_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text.Trim();
            string[] arr = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            txtKetQua.Text = "";
            foreach (string word in arr)
            {
                string w = word.ToLower();
                txtKetQua.Text += w + " ";
            }
            txtKetQua.Text = txtKetQua.Text.Trim();
        }

        private void btnTimViTriXuatHienDauTien_Click(object sender, EventArgs e)
        {
            if (txtChuoiTimViTriXuatHienDauTien.Text == "")
            {
                txtKetQua.Text = "Vui lòng nhập chuỗi cần tìm";
            }
            else
            {
                int vitri = txtDuLieuGoc.Text.IndexOf(txtChuoiTimViTriXuatHienDauTien.Text);
                if (vitri == -1)
                {
                    txtKetQua.Text = "Không tìm thấy [" + txtChuoiTimViTriXuatHienDauTien.Text + "] trong chuỗi";
                }
                else
                {
                    txtKetQua.Text = "Tìm thấy [" + txtChuoiTimViTriXuatHienDauTien.Text + "] tại vị trí đầu tiên là " + vitri;
                }
            }

        }

        private void btnTimViTriCuoiCung_Click(object sender, EventArgs e)
        {
            if (txtChuoiTimViTriXuatHienCuoiCung.Text == "")
            {
                txtKetQua.Text = "Vui lòng nhập chuỗi cần tìm";
            }
            else
            {
                int vitri = txtDuLieuGoc.Text.LastIndexOf(txtChuoiTimViTriXuatHienCuoiCung.Text);
                if (vitri == -1)
                {
                    txtKetQua.Text = "Không tìm thấy [" + txtChuoiTimViTriXuatHienCuoiCung.Text + "] trong chuỗi";
                }
                else
                {
                    txtKetQua.Text = "Tìm thấy [" + txtChuoiTimViTriXuatHienCuoiCung.Text + "] tại vị trí đầu tiên là " + vitri;
                }
            }
        }

        private void btnDemSoLanXuatHien_Click(object sender, EventArgs e)
        {
            int count = 0;
            string s = txtDuLieuGoc.Text;
            int vitri = s.IndexOf(txtDemSoLanXuatHien.Text);
            if (vitri == -1)
            {
                txtKetQua.Text = "Không có [" + txtDemSoLanXuatHien.Text + "] trong chuỗi";
            }
            else
            {
                while (vitri != -1)
                {
                    count++;
                    s = s.Substring(vitri + txtDemSoLanXuatHien.Text.Length);
                    vitri = s.IndexOf(txtDemSoLanXuatHien.Text);
                }
                txtKetQua.Text = "Tìm thấy " + count + " lần xuất hiện [" + txtDemSoLanXuatHien.Text + "]";
            }
        }

        private void btnTachTu_Click(object sender, EventArgs e)
        {
            char[] arrKT = txtTachTu.Text.ToCharArray();
            string[] arrWord = txtDuLieuGoc.Text.Split(arrKT);
            txtKetQua.Text = "";
            foreach (string s in arrWord)
            {
                txtKetQua.Text += s + "\r\n";
            }
        }

        private void btnThayDoiChuoiCon_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtDuLieuGoc.Text.Replace(txtChuoiCu.Text, txtThayDoiChuoiCon.Text);

        }

        private void btnXoaChuoiCon_Click(object sender, EventArgs e)
        {
            int vitri = txtDuLieuGoc.Text.IndexOf(txtXoaChuoiCon.Text);
            if (vitri != -1)
            {
                string s = txtDuLieuGoc.Text;
                s = s.Remove(vitri, txtXoaChuoiCon.Text.Length);
                txtKetQua.Text = s;
            }
        }

        private void btnChenChuoi_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            string s2 = s.Insert(int.Parse(txtViTriChen.Text), txtChenChuoi.Text);
            txtKetQua.Text = s2;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình ?"
                , "Thông báo thoát", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            //e.Cancel = (ret == DialogResult.No);
            if (ret == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

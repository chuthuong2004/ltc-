using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_XuLyFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> dsSinhVien = new List<SinhVien>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.Ma = int.Parse(txtMa.Text);
            sinhVien.Ten = txtTen.Text;
            sinhVien.NamSinh = dtpNamSinh.Value;
            dsSinhVien.Add(sinhVien);

            HienThiDanhSachSinhVien();
        }

        private void HienThiDanhSachSinhVien()
        {
            lsbDanhSachSinhVien.Items.Clear();
            foreach (SinhVien sinhVien in dsSinhVien)
            {
                lsbDanhSachSinhVien.Items.Add(sinhVien);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.Ma = int.Parse(txtMa.Text);
                sinhVien.Ten = txtTen.Text;
                sinhVien.NamSinh = dtpNamSinh.Value;
                dsSinhVien.Add(sinhVien);
                string path = Application.StartupPath + "\\csld.txt";
                bool kq = FileFactory.LuuFile(dsSinhVien, path);
                if (kq)
                {
                    MessageBox.Show("Lưu file thành công !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csld.txt";
            if (System.IO.File.Exists(path))
            {
                dsSinhVien = FileFactory.DocFile(path);
                HienThiDanhSachSinhVien();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDoc.PerformClick();
        }
    }
}

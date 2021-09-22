using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_SerializeFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> dsSV = new List<SinhVien>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;
            sv.NamSinh = dtpNamSinh.Value;
            dsSV.Add(sv);
            HienThiSinhVienLenListBox();
        }
        void HienThiSinhVienLenListBox()
        {
            lsbDanhSachSinhVien.Items.Clear();
            foreach (SinhVien sv in dsSV)
            {
                lsbDanhSachSinhVien.Items.Add(sv);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;
            sv.NamSinh = dtpNamSinh.Value;
            dsSV.Add(sv);
            HienThiSinhVienLenListBox();
            string path = Application.StartupPath + "\\csdl.txt";
            bool kt = FileFactory.LuuFile(dsSV, path);
            if (kt = true)
            {
                MessageBox.Show("Lưu thành công");
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.txt";
            dsSV = FileFactory.DocFile(path);
            HienThiSinhVienLenListBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.txt";
            if (System.IO.File.Exists(path))
            {
                dsSV = FileFactory.DocFile(path);
                HienThiSinhVienLenListBox();
            }

        }
    }
}

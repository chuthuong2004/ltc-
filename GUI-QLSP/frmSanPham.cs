using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLSP
{
    public partial class frmSanPham : Form
    {
        public static List<DanhMuc> dsDanhMuc = new List<DanhMuc>();
        List<SanPham> dsSanPham = new List<SanPham>();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDM = new frmDanhMuc();
            frmDanhMuc.CoThayDoi = false;
            if (frmDM.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhMucLenComboBox();
            }
        }

        private void HienThiDanhMucLenComboBox()
        {
            cboDanhMuc.Items.Clear();
            foreach (DanhMuc dm in frmDanhMuc.dsDanhMuc)
            {
                cboDanhMuc.Items.Add(dm);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục !");
                return;
            }
            DanhMuc dm = cboDanhMuc.SelectedItem as DanhMuc;
            SanPham sp = new SanPham();
            sp.MaSanPham = txtMaSanPham.Text;
            sp.TenSanPham = txtTenSanPham.Text;
            sp.DonGia = double.Parse(txtDonGia.Text);
            sp.XuatXu = txtXuatXu.Text;
            sp.HanDung = dtpHanDung.Value;
            dm.ThemSanPham(sp);
            dsSanPham.Add(sp);
            HienThiSanPhamLenListBox();
            XoaTrangChiTietSanPham();
            txtMaSanPham.Focus();
        }
        void XoaTrangChiTietSanPham()
        {
            cboDanhMuc.Text = "";
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtDonGia.Text = "";
            txtXuatXu.Text = "";
            dtpHanDung.Value = DateTime.Now;
        }
        void HienThiSanPhamLenListBox()
        {
            lstSanPham.Items.Clear();
            foreach (SanPham sp in dsSanPham)
            {
                lstSanPham.Items.Add(sp);
            }
        }

        private void lstSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSanPham.SelectedIndex == -1)
            {
                return;
            }
            SanPham sp = lstSanPham.SelectedItem as SanPham;
            cboDanhMuc.Text = sp.Nhom.TenDanhMuc;
            txtMaSanPham.Text = sp.MaSanPham;
            txtTenSanPham.Text = sp.TenSanPham;
            txtDonGia.Text = sp.DonGia + "";
            txtXuatXu.Text = sp.XuatXu;
            dtpHanDung.Value = sp.HanDung;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSanPham.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa !");
            }
            SanPham sp = lstSanPham.SelectedItem as SanPham;
            DialogResult ret = MessageBox.Show($"Bạn có muốn xóa [{sp.TenSanPham}] không ?", "Xóa Sản Phẩm"
                , MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                dsSanPham.Remove(sp);
                HienThiSanPhamLenListBox();
                XoaTrangChiTietSanPham();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

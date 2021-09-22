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
    public partial class frmDanhMuc : Form
    {
        public static bool CoThayDoi = false;
        public static List<DanhMuc> dsDanhMuc = new List<DanhMuc>();
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void btnLuuDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            dm.MaDanhMuc = txtMaDanhMuc.Text;
            dm.TenDanhMuc = txtTenDanhMuc.Text;
            txtMaDanhMuc.Text = "";
            txtTenDanhMuc.Text = "";
            txtMaDanhMuc.Focus();
            frmDanhMuc.dsDanhMuc.Add(dm);
            HienThiDanhMucLenListBox();
            frmDanhMuc.CoThayDoi = true;
        }
        void HienThiDanhMucLenListBox()
        {
            lstDanhMuc.Items.Clear();
            foreach (DanhMuc danhmuc in frmDanhMuc.dsDanhMuc)
            {
                lstDanhMuc.Items.Add(danhmuc);
            }
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                txtMaDanhMuc.Text = dm.MaDanhMuc;
                txtTenDanhMuc.Text = dm.TenDanhMuc;
            }
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                lstDanhMuc.Items.Remove(dm);
                txtMaDanhMuc.Text = "";
                txtTenDanhMuc.Text = "";
                frmDanhMuc.CoThayDoi = true;
            }
        }

        private void btnThoatDanhMuc_Click(object sender, EventArgs e)
        {
            if (CoThayDoi = true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }
    }
}

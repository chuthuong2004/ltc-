using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ListView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<DanhMuc> khoHang = new List<DanhMuc>();
        private void Form2_Load(object sender, EventArgs e)
        {
            DanhMuc bia = new DanhMuc();
            bia.MaDanhMuc = "DM01";
            bia.TenDanhMuc = "Nhóm Bia";
            khoHang.Add(bia);

            SanPham biaKen = new SanPham();
            biaKen.MaSanPham = "SP01";
            biaKen.TenSanPham = "Heneiken";
            biaKen.DonGia = 150;
            bia.ThemSanPham(biaKen);

            SanPham bia333 = new SanPham();
            bia333.MaSanPham = "SP02";
            bia333.TenSanPham = "333";
            bia333.DonGia = 100;
            bia.ThemSanPham(bia333);

            DanhMuc ruou = new DanhMuc();
            ruou.MaDanhMuc = "DM02";
            ruou.TenDanhMuc = "Nhóm Rượu";
            khoHang.Add(ruou);

            SanPham vodka = new SanPham();
            vodka.MaSanPham = "SP03";
            vodka.TenSanPham = "Rượu Vodka Lào";
            vodka.DonGia = 50;
            ruou.ThemSanPham(vodka);

            foreach (DanhMuc dm in khoHang)
            {
                // Tạo nhóm cho list view
                ListViewGroup lvg = new ListViewGroup(dm.TenDanhMuc);
                listView1.Groups.Add(lvg);
                foreach (SanPham sanPham in dm.sanPhams)
                {
                    ListViewItem lvi = new ListViewItem(sanPham.MaSanPham);
                    lvi.SubItems.Add(sanPham.TenSanPham);
                    lvi.SubItems.Add(sanPham.DonGia + "");
                    lvi.Group = lvg;
                    listView1.Items.Add(lvi);
                    if (dm == ruou)
                    {
                        lvi.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}

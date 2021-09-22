﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSanPham.SelectedItems[0];
                string ma = lvi.SubItems[0].Text;
                string ten = lvi.SubItems[1].Text;
                int gia = int.Parse(lvi.SubItems[2].Text);
                txtMa.Text = ma;
                txtTen.Text = ten;
                txtGia.Text = gia + "";
            }
        }

        private void lvSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != -1)
            {
                ColumnHeader col = lvSanPham.Columns[e.Column];
                MessageBox.Show("Bạn click cột " + col.Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // tạo 1 list view item
            ListViewItem lvi = new ListViewItem(txtMa.Text);
            // thêm các cột còn lại
            lvi.SubItems.Add(txtTen.Text);
            lvi.SubItems.Add(txtGia.Text);
            // đưa lvi lên gia diện
            lvSanPham.Items.Add(lvi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                //lvsanpham.items.remove(lvsanpham.selecteditems[0]);
                lvSanPham.Items.RemoveAt(lvSanPham.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Ngu như bò");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSanPham.SelectedItems[0];
                lvi.SubItems[0].Text = txtMa.Text;
                lvi.SubItems[1].Text = txtTen.Text;
                lvi.SubItems[2].Text = txtGia.Text;
            }
            else
            {
                MessageBox.Show("Ngu như bò");
            }
        }
    }
}

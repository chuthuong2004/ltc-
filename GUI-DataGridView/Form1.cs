using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<NhanVien> dsNhanVien = new List<NhanVien>();
            dsNhanVien.Add(new NhanVien() {
                MaNhanVien = 1,
                TenNhanVien = "Đào Văn Thương",
                Phone = "0333729170"
            });
            dsNhanVien.Add(new NhanVien() { 
                MaNhanVien = 2,
                TenNhanVien = "Chu Văn An",
                Phone = "023485297"
            });
            dsNhanVien.Add(new NhanVien() { 
                MaNhanVien = 3,
                TenNhanVien = "Chu Chỉ Nhược",
                Phone = "0923846256"
            });
            dsNhanVien.Add(new NhanVien() { 
                MaNhanVien= 4,
                TenNhanVien = "Trần Chỉ Chuột",
                Phone = "0495728425"
            });
            gvNhanVien.DataSource = dsNhanVien;
        }

        private void gvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1)
            //{
            //    return;
            //}
            //DataGridViewRow row = gvNhanVien.Rows[e.RowIndex];
            //string ten = row.Cells[1].Value + "";
            //MessageBox.Show(ten);



        }

        private void gvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = gvNhanVien.Rows[e.RowIndex];
            string ten = row.Cells[1].Value + "";
            MessageBox.Show(ten);
        }
    }
}

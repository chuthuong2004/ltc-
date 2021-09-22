using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CSharp
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = int.Parse(txtMa.Text);
            sv.FullName = txtName.Text;
            lstSinhVien.Items.Add(sv);

        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex != -1)
            {
                SinhVien sv = lstSinhVien.SelectedItem as SinhVien;
                txtMa.Text = sv.MaSV.ToString();
                txtName.Text = sv.FullName;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (lstSinhVien.SelectedIndices.Count > 0)
            {
                lstSinhVien.Items.RemoveAt(lstSinhVien.SelectedIndices[0]);
                txtMa.Text = "";
                txtName.Text = "";
            }
        }
    }
}

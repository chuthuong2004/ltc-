using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_QLSV.Model;
using GUI_QLSV.IO;

namespace GUI_QLSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Dictionary<string, Khoa> CSDL = new Dictionary<string, Khoa>();
        SinhVien SelectSinhVien = null;

        private void frmMain_Load(object sender, EventArgs e)
        {
            //LamGiaDuLieu();
            //HienThiLenTreView();
            //HienThiKhoaLenComboBox();
        }

        private void HienThiKhoaLenComboBox()
        {
            cboKhoaChuQuan.Items.Clear();
            foreach (KeyValuePair<string, Khoa> itemKhoa in CSDL)
            {
                Khoa khoa = itemKhoa.Value;
                cboKhoaChuQuan.Items.Add(khoa);
            }
        }

        private void HienThiLenTreView()
        {
            tvKhoa.Nodes.Clear();
            foreach (KeyValuePair<string, Khoa> itemKhoa in CSDL)
            {
                Khoa kh = itemKhoa.Value;
                TreeNode nodeKhoa = new TreeNode(kh.TenKhoa);
                nodeKhoa.Tag = kh;
                tvKhoa.Nodes.Add(nodeKhoa);

                foreach (KeyValuePair<string, LopHoc> itemLop in kh.Lops)
                {
                    LopHoc lh = itemLop.Value;
                    TreeNode nodeLop = new TreeNode(lh.TenLopHoc);
                    nodeLop.Tag = lh;
                    nodeKhoa.Nodes.Add(nodeLop);
                }
            }
            tvKhoa.ExpandAll();
        }

        private void LamGiaDuLieu()
        {
            Khoa cntt = new Khoa()
            {
                MaKhoa = "CNTT",
                TenKhoa = "Khoa Công nghệ thông tin",
            };
            Khoa xayDung = new Khoa()
            {
                MaKhoa = "CX",
                TenKhoa = "Khoa Kỹ thuật xây dựng"
            };
            Khoa kinhte = new Khoa()
            {
                MaKhoa = "KTVT",
                TenKhoa = "Khoa Kinh tế vận tải"
            };
            Khoa luat = new Khoa()
            {
                MaKhoa = "Luật",
                TenKhoa = "Khoa Luật"
            };
            CSDL.Add(cntt.MaKhoa, cntt);
            CSDL.Add(xayDung.MaKhoa, xayDung);
            CSDL.Add(kinhte.MaKhoa, kinhte);
            CSDL.Add(luat.MaKhoa, luat);

            // Lớp cnnt
            LopHoc lopcntt1 = new LopHoc()
            {
                MaLopHoc = "CN1",
                TenLopHoc = "CN19CLCA"
            };
            cntt.Lops.Add(lopcntt1.MaLopHoc, lopcntt1);
            lopcntt1.KhoaChuQuan = cntt;

            LopHoc lopcntt2 = new LopHoc()
            {
                MaLopHoc = "CN2",
                TenLopHoc = "CN19CLCB"
            };
            cntt.Lops.Add(lopcntt2.MaLopHoc, lopcntt2);
            lopcntt2.KhoaChuQuan = cntt;
            //==============
            //Lớp Luật
            LopHoc lopLuat1 = new LopHoc()
            {
                MaLopHoc = "UL1",
                TenLopHoc = "UL19CLCA"
            };
            luat.Lops.Add(lopLuat1.MaLopHoc, lopLuat1);
            lopLuat1.KhoaChuQuan = luat;

            LopHoc lopLuat2 = new LopHoc()
            {
                MaLopHoc = "UL2",
                TenLopHoc = "UL19CLCB"
            };
            luat.Lops.Add(lopLuat2.MaLopHoc, lopLuat2);
            lopLuat2.KhoaChuQuan = luat;

            LopHoc lopLuat3 = new LopHoc()
            {
                MaLopHoc = "UL3",
                TenLopHoc = "UL19CLCC"
            };
            luat.Lops.Add(lopLuat3.MaLopHoc, lopLuat3);
            lopLuat3.KhoaChuQuan = luat;
            //================\

            //Lớp kinh tế
            LopHoc lopKinhTe1 = new LopHoc()
            {
                MaLopHoc = "KT1",
                TenLopHoc = "KT19CLCA"
            };
            kinhte.Lops.Add(lopKinhTe1.MaLopHoc, lopKinhTe1);
            lopKinhTe1.KhoaChuQuan = kinhte;

            LopHoc lopKinhTe2 = new LopHoc()
            {
                MaLopHoc = "KT2",
                TenLopHoc = "KT19CLCB"
            };
            kinhte.Lops.Add(lopKinhTe2.MaLopHoc, lopKinhTe2);
            lopKinhTe2.KhoaChuQuan = kinhte;

            LopHoc lopKinhTe3 = new LopHoc()
            {
                MaLopHoc = "QL1",
                TenLopHoc = "QL19CLCA"
            };
            kinhte.Lops.Add(lopKinhTe3.MaLopHoc, lopKinhTe3);
            lopKinhTe3.KhoaChuQuan = kinhte;

            LopHoc lopKinhTe4 = new LopHoc()
            {
                MaLopHoc = "QL2",
                TenLopHoc = "QL19CLCB"
            };
            kinhte.Lops.Add(lopKinhTe4.MaLopHoc, lopKinhTe4);
            lopKinhTe4.KhoaChuQuan = kinhte;
            //===========

            //Lớp xây dựng
            LopHoc lopXayDung1 = new LopHoc()
            {
                MaLopHoc = "CX1",
                TenLopHoc = "CX19CLCA"
            };
            xayDung.Lops.Add(lopXayDung1.MaLopHoc, lopXayDung1);
            lopXayDung1.KhoaChuQuan = xayDung;

            LopHoc lopXayDung2 = new LopHoc()
            {
                MaLopHoc = "CX2",
                TenLopHoc = "CX19CLCB"
            };
            xayDung.Lops.Add(lopXayDung2.MaLopHoc, lopXayDung2);
            lopXayDung2.KhoaChuQuan = xayDung;
            //====================

            // Giả lập sinh viên
            // cntt1
            SinhVien sv1 = new SinhVien()
            {
                MaSinhVien = "19H1120035",
                TenSinhVien = "Đào Văn Thương",
                GioiTinh = false, // là nam
                NamSinh = new DateTime(2001, 04, 20)
            };
            lopcntt1.SinhViens.Add(sv1.MaSinhVien, sv1);
            sv1.LopChuQuan = lopcntt1;

            SinhVien sv2 = new SinhVien()
            {
                MaSinhVien = "19H1120052",
                TenSinhVien = "Nguyễn Việt Long",
                GioiTinh = false, // là nam
                NamSinh = new DateTime(2001, 12, 23)
            };
            lopcntt1.SinhViens.Add(sv2.MaSinhVien, sv2);
            sv2.LopChuQuan = lopcntt1;

            SinhVien sv3 = new SinhVien()
            {
                MaSinhVien = "19H1120064",
                TenSinhVien = "Nguyễn Minh Nhật",
                GioiTinh = false, // là nam
                NamSinh = new DateTime(2001, 5, 13)
            };
            lopcntt1.SinhViens.Add(sv3.MaSinhVien, sv3);
            sv3.LopChuQuan = lopcntt1;
            //====

            //cntt2
            SinhVien sv4 = new SinhVien()
            {
                MaSinhVien = "19H1120023",
                TenSinhVien = "Lê Tuấn Dự",
                GioiTinh = false, // là nam
                NamSinh = new DateTime(2001, 04, 26)
            };
            lopcntt2.SinhViens.Add(sv4.MaSinhVien, sv4);
            sv4.LopChuQuan = lopcntt2;

            SinhVien sv5 = new SinhVien()
            {
                MaSinhVien = "19H1120012",
                TenSinhVien = "Trần Đỗ Việt Hoàng",
                GioiTinh = false, // là nam
                NamSinh = new DateTime(2001, 11, 12)
            };
            lopcntt2.SinhViens.Add(sv5.MaSinhVien, sv5);
            sv5.LopChuQuan = lopcntt2;

            SinhVien sv6 = new SinhVien()
            {
                MaSinhVien = "19H1120066",
                TenSinhVien = "Nguyễn Trung Quốc",
                GioiTinh = false, // là nam
                NamSinh = new DateTime(2001, 02, 27)
            };
            lopcntt2.SinhViens.Add(sv6.MaSinhVien, sv6);
            sv6.LopChuQuan = lopcntt2;
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSinhVien.SelectedItems[0];
            SinhVien sv = lvi.Tag as SinhVien;
            txtMaSV.Text = sv.MaSinhVien;
            txtTenSV.Text = sv.TenSinhVien;
            if (sv.GioiTinh)
                radNu.Checked = true;
            else
                radNam.Checked = true;
            dtp.Value = sv.NamSinh;
            SelectSinhVien = sv;
        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null) // có chọn nút gì đó trên giao diện
            {
                if (e.Node.Level == 1) // đúng là nsd chọn nút lớp học => hiển thị danh sách sv
                {
                    LopHoc lh = e.Node.Tag as LopHoc;
                    HienThiDanhSachSinhVienTheoLop(lh);
                }
                else
                {
                    lvSinhVien.Items.Clear(); // xóa đi vì không xem danh sách sinh viên
                }
            }
        }

        private void HienThiDanhSachSinhVienTheoLop(LopHoc lh)
        {
            lvSinhVien.Items.Clear();
            foreach (KeyValuePair<string, SinhVien> itemSinhVien in lh.SinhViens)
            {
                SinhVien sv = itemSinhVien.Value;
                ListViewItem lvi = new ListViewItem(sv.MaSinhVien);
                lvi.SubItems.Add(sv.TenSinhVien);
                lvi.SubItems.Add(sv.GioiTinh == false ? "Nam" : "Nữ");
                if (sv.NamSinh != null)
                {
                    lvi.SubItems.Add(sv.NamSinh.ToString("dd/MM/yyyy"));
                }
                else
                {
                    lvi.SubItems.Add(sv.NamSinh.ToString("........."));
                }
                lvSinhVien.Items.Add(lvi);
                lvi.Tag = sv;
            }
        }

        private void cboKhoaChuQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoaChuQuan.SelectedIndex == -1) return;
            Khoa kh = cboKhoaChuQuan.SelectedItem as Khoa;
            HienThiLopHocLenComboBox(kh);
        }

        private void HienThiLopHocLenComboBox(Khoa kh)
        {
            cboLopChuQuan.Items.Clear();
            foreach (KeyValuePair<string, LopHoc> itemLop in kh.Lops)
            {
                LopHoc lop = itemLop.Value;
                cboLopChuQuan.Items.Add(lop);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboKhoaChuQuan.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn khoa !");
                return;
            }
            if (cboLopChuQuan.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn lớp !");
                return;
            }
            SinhVien sv = new SinhVien();
            sv.MaSinhVien = txtMaSV.Text;
            sv.TenSinhVien = txtTenSV.Text;
            sv.GioiTinh = radNu.Checked;
            sv.NamSinh = dtp.Value;
            LopHoc lp = cboLopChuQuan.SelectedItem as LopHoc;
            sv.LopChuQuan = lp;
            lp.SinhViens.Add(sv.MaSinhVien, sv);
            MessageBox.Show("Lưu sinh viên thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xử lý xóa
            if (SelectSinhVien != null)
            {
                LopHoc lh = SelectSinhVien.LopChuQuan;
                lh.SinhViens.Remove(SelectSinhVien.MaSinhVien);
                MessageBox.Show("Xóa sinh viên thành công !");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên cần xóa");
            }

        }

        private void mnuHeThongThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?",
                "Xác nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
                //Application.Exit();
            }
        }

        private void mnuHeThongLuuDuLieu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool kt = FileFactory.SaveFile(CSDL, saveFileDialog1.FileName);
                if (kt == true)
                {
                    MessageBox.Show("Lưu tập tin thành công !");
                }

            }
        }

        private void mnuHeThongDocDuLieu_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                CSDL = FileFactory.ReadFile(openFileDialog1.FileName);
                HienThiLenTreView();
            }
        }
    }
}

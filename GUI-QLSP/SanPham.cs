using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QLSP
{
    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public double DonGia { get; set; }
        public string XuatXu { get; set; }
        public DateTime HanDung { get; set; }
        public DanhMuc Nhom { get; set; }
        public override string ToString()
        {
            return this.TenSanPham;
        }
    }
}

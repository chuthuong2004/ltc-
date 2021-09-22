using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_ListView
{
    public class DanhMuc
    {
        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public List<SanPham> sanPhams { get; set; }
        public DanhMuc()
        {
            sanPhams = new List<SanPham>();
        }
        public  void  ThemSanPham(SanPham sanPham)
        {
            sanPhams.Add(sanPham);
            sanPham.Nhom = this;
        }
    }
}

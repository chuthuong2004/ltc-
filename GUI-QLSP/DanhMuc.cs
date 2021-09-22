using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QLSP
{
    public class DanhMuc
    {
        private Dictionary<string, SanPham> dsSanPham = new Dictionary<string, SanPham>();
        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public void ThemSanPham(SanPham sp)
        {
            if (this.dsSanPham.ContainsKey(sp.MaSanPham) == false)
            {
                this.dsSanPham.Add(sp.MaSanPham, sp);
                sp.Nhom = this;
            }
        }
        public Dictionary<string, SanPham> SanPhams
        {
            get
            {
                return this.dsSanPham;
            }
            set
            {
                this.dsSanPham = value;
            }
        }
        public override string ToString()
        {
            return this.TenDanhMuc;
        }

    }
}

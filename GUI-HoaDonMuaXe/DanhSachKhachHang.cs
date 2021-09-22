using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_HoaDonMuaXe
{
    public class DanhSachKhachHang
    {
        List<KhachHang> dsKhachHang = new List<KhachHang>();
        public List<KhachHang> khachs
        {
            get
            {
                return dsKhachHang;
            }
        }
        public void Mua(KhachHang kh)
        {
            dsKhachHang.Add(kh);
        }
        public int TongSoKhachHang
        {
            get
            {
                return dsKhachHang.Count;
            }
        }
        public int TongSoKhachHangMuaXeDen
        {
            get
            {
                int soXeMauDen = 0;
                foreach (KhachHang kh in dsKhachHang)
                {
                    if (kh.XeMauDen == true)
                    {
                        soXeMauDen++;
                    }
                }
                return soXeMauDen;
            }
        }
        public double TongDoanhThu
        {
            get
            {
                double sum = 0;
                foreach (KhachHang kh in dsKhachHang)
                {
                    sum += kh.ThanhToan;
                }
                return sum;
            }
        }
    }

}

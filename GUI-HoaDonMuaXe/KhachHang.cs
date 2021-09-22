using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_HoaDonMuaXe
{
    public class KhachHang
    {
        public double GiaTien { get; set; }
        public double PhuThu
        {
            get
            {
                return GiaTien * 0.05;
            }
        }
        public double Thue
        {
            get
            {
                return GiaTien * 0.2;
            }
        }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public bool XeMauDen { get; set; }
        public string HangXe { get; set; }
        public string MauXe
        {
            get
            {
                string mauXe = "";
                if (XeMauDen)
                {
                     mauXe = "Màu Đen";
                }
                else
                {
                    mauXe = "Màu Trắng";
                }
                return mauXe;
            }
        }
        public double ThanhToan
        {
            get
            {
                if (XeMauDen == true)
                {
                    return GiaTien + PhuThu + Thue;
                }
                else
                {
                    return GiaTien + Thue;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_DatVeXemPhim
{
    public class Customer
    {
        public Customer()
        {
            Ghes = new List<int>();
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public  List<int> Ghes { get; set; }
        public DateTime GioDatGhe { get; set; }
        public int GiaVe
        {
            get
            {
                return 100;
            }
        }
        public int TinhTien
        {
            get
            {
                return Ghes.Count * GiaVe;
            }
        }
        public int SoLuong
        {
            get
            {
                return Ghes.Count;
            }
        }
        public override string ToString()
        {
            return this.Name + " - " + this.Phone;
        }
    }
}

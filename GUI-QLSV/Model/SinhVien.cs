using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QLSV.Model
{
    [Serializable]
    public class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public DateTime NamSinh { get; set; }
        public bool GioiTinh { get; set; }
        public LopHoc LopChuQuan { get; set; }
        public override string ToString()
        {
            return TenSinhVien;
        }
    }
}

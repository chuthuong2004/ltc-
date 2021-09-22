using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QLSV.Model
{
    [Serializable]
    public class LopHoc
    {
        public string MaLopHoc { get; set; }
        public string TenLopHoc { get; set; }
        public string GiaoVienCoVan { get; set; }
        public Dictionary<string, SinhVien> SinhViens { get; set; }
        public LopHoc()
        {
            SinhViens = new Dictionary<string, SinhVien>();
        }
        public override string ToString()
        {
            return TenLopHoc;
        }
        public Khoa KhoaChuQuan { get; set; }

    }

}

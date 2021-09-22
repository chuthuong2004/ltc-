using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp
{
    public class SinhVien
    {
        public int MaSV { get; set; }
        public string FullName { get; set; }
        public override string ToString()
        {
            return this.MaSV +" - "+this.FullName;
        }
    }
}

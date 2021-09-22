using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace GUI_XuLyFile
{
    public class FileFactory
    {
        public static bool LuuFile(List<SinhVien> dsSV, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (SinhVien sv in dsSV)
                {
                    string line = sv.Ma + ";" + sv.Ten + ";" + sv.NamSinh.ToString("dd/MM/yyyy");
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<SinhVien> DocFile(string path)
        {
            List<SinhVien> sinhViens = new List<SinhVien>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 3)
                    {
                        SinhVien sv = new SinhVien();
                        sv.Ma = int.Parse(arr[0]);
                        sv.Ten = arr[1];
                        sv.NamSinh = DateTime.Parse(arr[2]);
                        sinhViens.Add(sv);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sinhViens;
        }
    }
}

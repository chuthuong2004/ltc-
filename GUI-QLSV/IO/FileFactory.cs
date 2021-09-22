using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_QLSV.Model;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace GUI_QLSV.IO
{
    public class FileFactory
    {
        public static bool SaveFile(Dictionary<string, Khoa> CSDL, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, CSDL);
                fs.Close();

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static Dictionary<string, Khoa> ReadFile(string path)
        {
            Dictionary<string, Khoa> CSDL = new Dictionary<string, Khoa>();
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                CSDL = data as Dictionary<string, Khoa>;
                fs.Close();
                return CSDL;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

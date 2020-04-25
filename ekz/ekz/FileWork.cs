using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace ekz
{
    public class FileWork
    {
        public static string FilePath;

        public static List<string> ReadLines()
        {
            {
                return File.ReadAllLines(FilePath).ToList();
            }
        }
        public static void SaveFile(List<string> ist)
        {
            File.WriteAllLines(FilePath, ist.ToArray());
        }
        public static string ReadLine(int id)
        {
            List<string> ist = ReadLines();
            string st = "";
            foreach (string s in ist)
            {
                if (s.StartsWith(id.ToString() + ";"))
                {
                    st = s;
                    break;
                }
            }
            return st;
        }
        public static DataTable ReadTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Направление поездки");
            dt.Columns.Add("Продолжительность");
            dt.Columns.Add("Цена");
            dt.Columns.Add("Номер телефона");
            dt.Columns.Add("Email");
            dt.Columns.Add("Адрес проживания");
            List<string> ist = ReadLines();
            foreach (string s in ist)
            {
                string[] ss = s.Split(';');
                dt.Rows.Add(ss[0], ss[1], ss[2], ss[3]);
            }
            return dt;
        }

    }
}

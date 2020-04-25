﻿using System;
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
        public static void AddUpdate(int id, string Napravlenie, string Prodolzitelnost, string Cena)
        {
            List<string> ist = ReadLines();
            if (id == 0)
            {
                foreach (string s in ist)
                {
                    string[] ss = s.Split(';');
                    if (Convert.ToInt32(ss[0]) > id)
                    {
                        id = Convert.ToInt32(ss[0]);
                    }
                }
                id++;
                string st = id.ToString() + ";"
                    + Napravlenie + ";" + Prodolzitelnost + ";" + Cena;
                ist.Add(st);
            }
            else
            {
                for (int i = 0; i < ist.Count; i++)
                {
                    if (ist[i].StartsWith(id.ToString() + ";"))
                    {
                        ist[i] = id.ToString() + ";"
                    + Napravlenie + ";" + Prodolzitelnost + ";" + Cena;
                        break;
                    }
                }
            }
            SaveFile(ist);
        }
        public static DataTable ReadTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Направление поездки");
            dt.Columns.Add("Продолжительность");
            dt.Columns.Add("Цена");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace ekz
{
    class Tour
    {

        public string Napravlenie;
        public string Prodolzitelnost;
        public string Cena;

        public Tour(int id)
        {
            string st = FileWork.ReadLine(id);
            string[] ss = st.Split(';');
            id = Convert.ToInt32(ss[0]);
            Napravlenie = ss[1];
            Prodolzitelnost = ss[2];
            Cena = ss[3];
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// -127      A
// 128 - 191 B
// 192 - 223 C
namespace IpCimek
{
    class IP
    {
        private int elso;
        private int masodik;
        private int harmadik;
        private int negyedik;

        public IP(string cim)
        {
            string[] oktett = new string[4];
            oktett = cim.Split('.');
            elso = Convert.ToInt32(oktett[0]);
            masodik = Convert.ToInt32(oktett[1]);
            harmadik = Convert.ToInt32(oktett[2]);
            negyedik = Convert.ToInt32(oktett[3]);
        }

        public string Osztaly() 
        {
            if (elso < 128)
            {
                return "A";
            }
            else if (elso < 192)
            {
                return "B";
            }
            else
            {
                return "C";
            }
        }
    }
}

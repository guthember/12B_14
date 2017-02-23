using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpCimek
{
    class Program
    {
        static void Main()
        {
            IP cim = new IP("192.168.11.10");
            Console.WriteLine(cim.Osztaly());

            Console.ReadKey();
        }
    }
}

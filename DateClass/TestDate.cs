using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateClass
{
    internal class TestDate
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(31, 6, 2023);
            //d1.setDay(-5);
            Console.WriteLine("Den: " + d1.getDay() + " Měsíc: " + d1.getMonth() + " Rok: " + d1.getYear());

            Console.WriteLine(d1.ToString());
        }
    }
}

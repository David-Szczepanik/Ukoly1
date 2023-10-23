using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClass
{
    internal class TestTime
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(1, 10, 0);
            Console.WriteLine(t1.ToString());

            t1.SetTime(3, 15, 59);
            Console.WriteLine(t1.ToString());

            t1.SetTime(0, 15, 60);
            Console.WriteLine(t1.ToString());

            t1.nextSecond();
            Console.WriteLine(t1.ToString());

            t1.previousSecond();
            t1.previousSecond();
            Console.WriteLine(t1.ToString());

        }
    }
}

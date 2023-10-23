using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol1_CircleClass
{
    class TestCircle
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("The circle has radius of " + c1.getRadius() + " and area of " + c1.getArea());

            Circle c2 = new Circle(2.0);
            Console.WriteLine("The circle has radius of " + c2.getRadius() + " and area of " + c2.getArea() + " and color " + c2.getColor());

            Circle c3 = new Circle(3.0, "blue");
            Console.WriteLine("The circle has radius of " + c3.getRadius() + " and area of " + c3.getArea() + " and color " + c3.getColor());

            //Console.WriteLine(c1.radius); Private
            Console.WriteLine(c1.getRadius());

            Circle c4 = new Circle();
            c4.setRadius(5.0);
            Console.WriteLine("radius is: " + c4.getRadius());

            c4.setColor("blue");
            Console.WriteLine("color is: " + c4.getColor());

            Circle c5 = new Circle(5.0);
            Console.WriteLine(c5.ToString());

            Circle c6 = new Circle(1.2);
            Console.WriteLine(c6.ToString());
            Console.WriteLine(c6);
            Console.WriteLine("Operator '+' invokes toString() too: " + c6);

        }
    }
}

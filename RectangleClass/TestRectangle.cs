using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleClass
{
    class TestRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("The rectangle has length of " + r1.getLength() + " and width of " + r1.getWidth() + " and area of " + r1.getArea());

            Rectangle r2 = new Rectangle(10.0f, 5.0f);
            Console.WriteLine("The rectangle has length of " + r2.getLength() + " and width of " + r2.getWidth() + " and area of " + r2.getArea());

            Rectangle r3 = new Rectangle(5.0f, 3.0f);
            //getLength
            Console.WriteLine(r3.getLength());
            //getWidth
            Console.WriteLine(r3.getWidth());

            //setLength
            Rectangle r4 = new Rectangle();
            r4.setLength(5.0f);
            Console.WriteLine("Length is: " + r4.getLength());

            //setWidth
            Rectangle r5 = new Rectangle();
            r5.setWidth(5.0f);
            Console.WriteLine("Width is: " + r5.getWidth());

            Rectangle r7 = new Rectangle(5.0f, 3.0f);
            //getArea
            Console.WriteLine("The area is: " + r7.getArea());
            //getPerimeter
            Console.WriteLine("The perimeter is: " + r7.getPerimeter());

            Console.WriteLine(r7.ToString());

        }
    }
}

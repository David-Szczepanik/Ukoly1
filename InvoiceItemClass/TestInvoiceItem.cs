using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceItemClass
{
    class TestInvoiceItem
    {
        static void Main(string[] args)
        {
            InvoiceItem i1 = new InvoiceItem("0", "description #1", 5, 10);
            Console.WriteLine("ID: " + i1.getId() + " Decription: " + i1.getDesc() + " Quantity: " + i1.Qty + " Unit Price: " + i1.UnitPrice);

            Console.WriteLine(i1.GetTotal());

            Console.WriteLine(i1.ToString());
        }
    }
}

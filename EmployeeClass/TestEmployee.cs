using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(0, "Jan", "Novák", 10000);
            Console.WriteLine("Zaměstnanec ID: " + e1.getId() + " Jméno: " + e1.getName() + " Plat: " + e1.Salary + " Roční plat: " + e1.getAnnualSalary());

            Employee e2 = new Employee(1, "Jan", "Novák", 10000);
            e2.Salary = 15000;
            Console.WriteLine("Plat: " + e2.Salary);

            Employee e3 = new Employee(2, "Petr", "Novák", 10000);
            e3.raiseSalary(20);
            Console.WriteLine("Zvýšený plat: " + e3.Salary);

            Console.WriteLine(e3.ToString());
        }
    }
}

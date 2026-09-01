using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class IndexerExample
    {
        public static void Main()
        {
            Employee emp = new Employee(1311, "Kiran K", "Delivery", "Developer", 25000.00);
            Console.WriteLine("Employee Info:");
            Console.WriteLine("Employee code: " + emp[1]);
            Console.WriteLine("Employee Name: " + emp[2]);
            Console.WriteLine("Employee Department: " + emp[3]);
            Console.WriteLine("Employee Designation: " + emp[4]);
            Console.WriteLine("Employee Salary: " + emp[5]);

            Console.ReadKey();

        }

    }
}

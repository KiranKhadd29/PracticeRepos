using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class Employee
    {
        int empCode;
        string empName, dept, designation;
        double salary;

        public Employee(int EmpCode, string EmpName, string Department, string Designation, double Salary)
        {
            empCode = EmpCode;
            empName = EmpName;
            dept = Department;
            designation = Designation;
            salary = Salary;
        }

        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return empCode;
                if (index == 2)
                    return empName;
                if (index == 3)
                    return dept;
                if (index == 4)
                    return designation;
                if (index == 5)
                    return salary;

                return null;
            }


        }

    }
}

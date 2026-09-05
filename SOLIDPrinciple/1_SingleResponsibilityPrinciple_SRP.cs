using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple
{
    class SingleResponsibilityPrinciple_SRP: WrongApproch_Employee
    {
        public static void Main()
        {
            SingleResponsibilityPrinciple_SRP srp = new SingleResponsibilityPrinciple_SRP();
            srp.Name = "Kiran Khadd";
            srp.Salary = 25000;
            Console.WriteLine("---- Wrong Approach ----");
            srp.CalculateSalary();
            srp.GenerateReport();

            Console.WriteLine("---- Correct Approach ----");
            SalaryCalculation sal = new SalaryCalculation();
            sal._Name = "John K";
            sal._Salary = 10000;
            sal.Salary();

            ReportGeneration rep = new ReportGeneration();
            rep._Name = "Donald KT";
            rep._Salary = 110000;
            rep.Report();

            Console.ReadLine();
        }
    }

    //Violation of SRP
    class WrongApproch_Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public void CalculateSalary()
        {
            Console.WriteLine("{0} has credited {1} salary", Name, Salary);
        }

        public void GenerateReport()
        {
            Console.WriteLine("{0} has generated the report.", Name);
        }
    }

    //Solution - SRP

    class Correct__Employee
    {
        public string _Name { get; set; }
        public double _Salary { get; set; }
        
    }

    class SalaryCalculation : Correct__Employee
    {
        public void Salary()
        {
            Console.WriteLine("{0} has credited {1} salary", _Name, _Salary);
        }
    }

    class ReportGeneration : Correct__Employee
    {
        public void Report()
        {
            Console.WriteLine("{0} has generated the report.", _Name);
        }
        
    }
}

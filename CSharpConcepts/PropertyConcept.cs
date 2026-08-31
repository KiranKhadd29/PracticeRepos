using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class PropertyConcept
    {
        public static void Main()
        {
            Customer cust = new Customer(10, false, "Kiran", 500);

            if (cust.Status == false)
            {
                Console.WriteLine($"Hi {cust.CustName} ({cust.CustId}), Your account is inactive. Please do the re-KYC. otherwise account will become dormaint ");
            }

            if (cust.Balance <= 500)
            {
                Console.WriteLine($"Hi {cust.CustName} ({cust.CustId}), Your balance is low. Please maintain sufficient balance in account! ");
            }
            else
            {
                Console.WriteLine("Customer Info:");
                //cust.custId = 99; -- Only get{} applied - Readonly
                Console.WriteLine("Customer Id: " + cust.CustId);
                Console.WriteLine("Customer Name: " + cust.CustName);
                cust.CustName = "Kiran Khadd";
                Console.WriteLine("Modified Customer Name: " + cust.CustName);
                Console.WriteLine("Customer Status: " + cust.Status);
                Console.WriteLine("Customer Balance: " + cust.Balance);
            }


            Console.ReadKey();
            
        }

    }

    class Customer
    {
        int _custId;
        bool _status;
        string _custName;
        double _balance;
        //Cities _cities;

        public Customer(int CustId, bool Status, string CustName, double Balance)
        {
            _custId = CustId;
            _status = Status;
            _custName = CustName;
            _balance = Balance;
            //_cities = City;
        }

        public int CustId
        {
            get { return _custId; }
        }

        public bool Status
        {
            get { return _status; }
            set 
            {
                if (_balance >= 500)
                {
                    _status = true;
                }
                else
                {
                    _status = false;
                }
            }
        }

        public string CustName
        {
            get { return _custName; }
            set {
                if (_status == true)
                _custName = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { if (_status == true) _balance = value; }
        }

        //public Cities City
        //{
        //    get { return _cities; }
        //    set
        //    {
        //        if (_status == true)
        //            _cities = value;
        //    }
        //}


    }

    

}

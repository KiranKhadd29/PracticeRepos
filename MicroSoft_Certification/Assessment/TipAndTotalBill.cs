using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class TipAndTotalBill
    {
        public static void Main()
        {
            Console.WriteLine("Enter bill amount");
            Console.Write("Bill amount: ");
            decimal billAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Tip Percent");
            Console.Write("Tip Percent: ");
            decimal tipPercentage = Convert.ToDecimal(Console.ReadLine());
            // Display details
            Console.WriteLine("Bill details:");
            Console.WriteLine($"  Bill amount:    ${billAmount}");
            Console.WriteLine($"  Tip percentage: {tipPercentage}%");
            // Calculate the tip and total
            decimal tipAmount = billAmount * (tipPercentage / 100);
            decimal totalAmount = billAmount + tipAmount;
            //Result
            Console.WriteLine($"\nTip amount:   ${tipAmount}");
            Console.WriteLine($"Total amount: ${totalAmount}");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class SubscriptionRenewal
    {
        public static void Main()
        {
            Random random = new Random();
            int expDate = random.Next(12);
            int discount = 0;

            if (expDate == 0)
            {
                Console.WriteLine("Your subscrption has expired. Please recharge!");
            }
            else if (expDate == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discount = 20;
            }
            else if (expDate <= 5)
            {
                Console.WriteLine($"Your subscription expires in {expDate} days.");
                discount = 10;

            }
            else if (expDate <=10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }

            // Display a discount message if a discount applies
            if (discount > 0)
            {
                Console.WriteLine($"Renew now and save {discount}%.");
            }

            Console.ReadLine();
        }
        
    }
}

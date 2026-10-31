using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class HeadsAndTails
    {
        public static void Main()
        {
            Random coin = new Random();
            int coinToss = coin.Next(0, 12);

            //for (int i=1; i>12; i++)
            //{
                string res = coinToss % 2 == 0 ? "Heads" : "Tails";
                Console.WriteLine("Count of Heads and Tails :" + res);

            //}
            Console.ReadLine();
        }
    }
}

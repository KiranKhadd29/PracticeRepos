using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    public class SwapNumbers
    {
        public void SwapNumbersWithThirdVariable ()
        {
            int num1 = 10, num2 = 20, temp;
            Console.WriteLine($"Before swap => num1 = {num1}  num2 = {num2}");
            temp = num2;
            num2 = num1;
            num1 = temp;
            Console.WriteLine($"After swap => num1 = {num1}  num2 = {num2}");
        }

        public void SwapNumbersWithoutThirdVariable()
        {
            int num1 = 10, num2 = 20;
            Console.WriteLine($"Before swap => num1 = {num1}  num2 = {num2}");
            num1 = num1 + num2; // 30
            num2 = num1 - num2; //10
            num1 = num1 - num2; //20
            Console.WriteLine($"After swap => num1 = {num1}  num2 = {num2}");
        }

        public void SwapNumbersWithoutThirdVariable2()
        {
            int num1 = 10, num2 = 20;
            Console.WriteLine($"Before swap => num1 = {num1}  num2 = {num2}");
            num1 = num1 ^ num2; // 30
            num2 = num1 ^ num2; //10
            num1 = num1 ^ num2; //20
            Console.WriteLine($"After swap => num1 = {num1}  num2 = {num2}");
        }
    }
}

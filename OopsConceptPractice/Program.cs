using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr =
               {
                {
                   {1,2,3},
                   {4,5,6},
                   {7,8,9}
                }
               };

            int[] result = {};

            //Console.WriteLine(arr[0, 1, 0]);


            result[0] = arr[0, 0, 0] + arr[0, 0, 1] + arr[0, 0, 2];
            result[1] = arr[0, 1, 0] + arr[0, 1, 1] + arr[0, 1, 2];
            result[2] = arr[0, 2, 0] + arr[0, 2, 1] + arr[0, 2, 2];

            Console.WriteLine(result);
            //int[] arr = { 1, 2, 3, 4, 5 };

            //foreach (int number in arr)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("Enter the first number: \n");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: \n");
            //int num2 = int.Parse(Console.ReadLine());
            //int result = 0;
            //Console.WriteLine("Choose an operation : Addition, Substraction, Multiplication or Division ?");
            //string userInput = Console.ReadLine();
            //if (userInput == "Addition")
            //{
            //    result = num1 + num2;
            //    Console.WriteLine($"{num1} + {num2} = {result} ");
            //}
            //if (userInput == "Substraction")
            //{
            //    result = num1 - num2;
            //    Console.WriteLine($"{num1} - {num2} = {result} ");
            //}
            //if (userInput == "Multiplication")
            //{
            //    result = num1 * num2;
            //    Console.WriteLine($"{num1} * {num2} = {result} ");
            //}
            //if (userInput == "Division")
            //{
            //    if (num2 == 0)
            //    {
            //        Console.WriteLine("Divider can not be zero");
            //    }
            //    result = num1 / num2;
            //    Console.WriteLine($"{num1} / {num2} = ", result);
            //}
            Console.ReadKey();
        }
    }
}

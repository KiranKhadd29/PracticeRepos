using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    internal class ArrayProgram
    {
        internal void simpleArrayProgram()
        {
            Console.WriteLine("Please enter size of Array!");
            int size = int.Parse(Console.ReadLine());
            int[] num = new int[size];

            for(int i=0; i<num.Length; i++)
            {
                Console.WriteLine($"Enter {i} th index");
                num[i] = int.Parse(Console.ReadLine());
            }

            foreach (int item in num)
            {
                Console.WriteLine($"{item}");
            }

        }

        internal void MaxAndMinValueInArray()
        {
            Console.WriteLine("Please enter size of Array!");
            int size = int.Parse(Console.ReadLine());
            int[] num = new int[size];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Enter {i} th index");
                num[i] = int.Parse(Console.ReadLine());
            }

            int max = 0;
            int min = num[0];
            foreach (int item in num)
            {
                if (item > max)
                {
                    max = item;
                }

                if (item < min)
                {
                    min = item;
                }

            }

            Console.WriteLine($"Max number is {max} and Min number is {min}");

        }

        internal void multiDimArray()
        {
            int[,] multDim = { {1,2,3 }, {8,9,10} };

            for (int i=0; i<2; i++)
            {
                int rowSum = 0;
                for (int j=0; j<3; j++)
                {
                    rowSum += multDim[i, j];
                    Console.Write(multDim[i, j] + " ");
                }
                Console.WriteLine($"Sum of row {i} : {rowSum}");
            }
        }

        internal void MultiDimArrayMultiplication()
        {
            int[,] firstArr = { {1,2 }, {4,5} };
            int[,] secondArr = { {10,20 }, {40,50} };
            /*********************
             * 1 2   10 20
             * 4 5   40 50
             * *******************/
            int[,] multArr = new int[2, 2];
            /***************************
             * [1*10+2*40]  [1*20+2*50]
             * [4*10+5*40]  [4*20+5*50]
             * *************************
             * output
             * 90  120
             * 240 330
             * **********************/

            for (int i=0; i< 2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k <2; k++)
                    {
                        sum += firstArr[i, k] * secondArr[k, j];
                    }

                    multArr[i, j] = sum;
                    Console.Write(multArr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        internal void JaggedArray ()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[5] { 1, 2, 3, 5, 6};
            arr[1] = new int[1] { 11 };
            arr[2] = new int[3] {77,88,99};

            for (int i=0; i<arr.Length; i++)
            {
                for (int j=0; j<arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

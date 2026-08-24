using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    internal class ArraySortPrograms
    {
        internal void SelectionSort()
        {
            int[] num = { 11, 896, 1, 6, 08, 00, 14, 99, 100 };
            int[] sortedNum = new int [num.Length];
            Console.WriteLine($"Before sort : {string.Join(",", num)}");

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i+1; j < num.Length; j++)
                {
                    if (num[i]>num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }  
                }

            }
            Console.WriteLine($"After sort : {string.Join(",", num)}");

        }

        internal void BubbleSort()
        {

        }
    }
}

using System;
using System.Linq;

namespace CSharpConcepts
{
    class LinqStudy
    {
        public static void Main()
        {
            Console.WriteLine("Array ex");
            LinqStudy sd = new LinqStudy();
            //sd.SimpleArrEx();
            sd.UsingLinq();
            Console.ReadLine();
        }

        public void SimpleArrEx()
        {
            try 
            {
                int[] arr = { 1, 45, 09, 789, 365, 12, 56, 40, 89, 99, 83, 38, 28, 19, 20, 46, 58 };
                int arrLen = arr.Length;
                Console.WriteLine("Array arr length = " + arrLen);
                int count = 0;
                for (int i = 0; i < arrLen; i++)
                {
                    if (arr[i] > 40)
                    {
                        count++;
                    }
                }
                foreach (int ar in arr)
                    Console.Write(ar + " ");
                Console.WriteLine("\n**********************");
                int brrLen = 0;
                int[] brr = new int[count];
                for (int i = 0; i < arrLen; i++)
                {
                    if (arr[i] > 40)
                    {
                        brr[brrLen] = arr[i];
                        brrLen += 1;
                    }
                }
                Array.Sort(brr);
                Array.Reverse(brr);
                Console.WriteLine("Array brr length = " + brr.Length);
                foreach(int br in brr)
                    Console.Write(br + " ");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UsingLinq()
        {
            try
            {
                int[] arr = { 1, 45, 09, 789, 365, 12, 56, 40, 89, 99, 83, 38, 28, 19, 20, 46, 58 };
                int arrLen = arr.Length;
                Console.WriteLine("Array arr length = " + arrLen);

                var brr = from i in arr 
                          where i > 40 
                          orderby i 
                          descending 
                          select i;
                
                //Console.WriteLine("Array brr length = " + brr.Length);
                foreach (int br in brr)
                    Console.Write(br + " ");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}

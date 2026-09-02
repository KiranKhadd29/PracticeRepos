using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    static class ExtensionMethodNewCodeChange
    {
        public static void Test2(this ExtensionMethodTest e)
        {
            Console.WriteLine("Method 2 excecution Skipped!!!");
        }
        public static void Test3(this ExtensionMethodTest e)
        {
            Console.WriteLine("Method 3 excecution successfull without touching origianl method/class!");
        }

        public static void Test4(this ExtensionMethodTest e, int i)
        {
            Console.WriteLine("Para Method 4 excecution successful  without touching origianl method/class!");
        }

        public static long Factorial(this Int32 i)
        {
            if (i == 1)
                return 1;
            if (i == 2)
                return 2;
            else
                return i * (Factorial(i - 1));
        }

        public static string ToProper(this String oldStr)
        {
            if (oldStr.Trim().Length>0)
            {
                string newStr = string.Empty;
                oldStr = oldStr.ToLower();
                string[] sarr = oldStr.Split(' ');
                foreach(string str in sarr)
                {
                    char[] carr = str.ToCharArray();
                    carr[0] = char.ToUpper(carr[0]);
                    if (newStr == string.Empty)
                    {
                        newStr = new string(carr);
                    }
                    else
                    {
                        newStr += " " + new string(carr);
                    }   
                }
                return newStr;
            }

            return oldStr;
        }
    }
}

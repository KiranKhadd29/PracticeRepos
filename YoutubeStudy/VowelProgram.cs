using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    public class VowelProgram
    {
        public void FindVowelUsingSwitch ()
        {
            char ch;
            Console.WriteLine("Enter Char");
            string enter = Console.ReadLine().ToLower();
            while (enter.Length > 1)
            {
                Console.WriteLine("Supported only Charactor");
                Console.WriteLine("Enter Char again");
                enter = Console.ReadLine().ToLower();
            }
            ch = Convert.ToChar(enter);

            switch(ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break;
            }
        }

        public void VowelUsingArray()
        {
            Console.WriteLine("Please enter your name.");
            string myName = Console.ReadLine();
            string enter = myName.ToLower();
            char[] arr = enter.ToCharArray();

            int vowelCount = 0;
            int consonentCnt = 0;

            foreach (char ch in arr)
            {
                switch (ch)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCount++;
                        break;
                    default:
                        consonentCnt++;
                        break;
                }

            }

            Console.WriteLine($"Your name contains {vowelCount} vowels and {consonentCnt} consonents."); 
        }
    }
}

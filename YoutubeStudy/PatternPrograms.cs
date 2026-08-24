using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    public class PatternPrograms
    {
        //Output target
        /************************
         * 
         * *
         * * *
         * * * *
         * * * * *
         **************************/
        public void Ladder()
        {
            for (int col=1; col<=6; col++)
            {
                for (int row=0; row<col -1; row++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //Output target
        /************************
         * * * * *
         * * * *
         * * *
         * * 
         * 
         
         **************************/
        public void ReverseLadder()
        {
            for (int col = 6; col >= 1; col--)
            {
                for (int row = 0; row < col - 1; row++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //Output target
        /************************
                    *
                   * *
                 *  *  *
               *  * * *  *
              * * * * * *  *
         **************************/
        public void Mountain()
        {
            int target = 6;
            for (int col = 1; col <= target; col++)
            {
                for (int spaceIndex = 1; spaceIndex <= target - col; spaceIndex++)
                {
                    Console.Write(" ");
                }
                for (int row = 0; row < col; row++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }

        //Output target
        /************************
                    *
                   * *
                 *  *  *
               *  * * *  *
              * * * * * *  *
         **************************/
        public void Diamond()
        {
            int target = 6;
            for (int col = 1; col <= target; col++)
            {
                for (int spaceIndex = 1; spaceIndex <= target - col; spaceIndex++)
                {
                    Console.Write(" ");
                }
                for (int row = 0; row < col; row++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            int revTarget = 1;
            for (int col = 6; col >= revTarget; col--) //5
            {
                for (int spaceIndex = 1; spaceIndex <=target-col; spaceIndex++)
                {
                    Console.Write(" ");
                }
                for (int row = 0; row < col; row++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}

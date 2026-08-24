using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    internal class FloorNumberDisplay
    {
        internal void FloorNumberDisplayUsingWhile ()
        {
            int floor = 0;
            while (floor <= 10)
            {
                if (floor <= 5)
                {
                    Console.WriteLine("Floor " + floor);
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Floor " + (11 - floor));
                    Thread.Sleep(2000);

                }
                floor++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    //Supported - byte, int, short, long, uint, ushort, ulong, sbyte
    enum WeekDays
    {
        Monday, Tuesday, Wednsday, Thursday, Friday
    }
    class EnumConcept
    {
        public static WeekDays Meeting { get; set; } = WeekDays.Monday;
        public static void Main()
        {
            //Creating variable
            WeekDays wd = WeekDays.Monday;
            Console.WriteLine(wd);

            Console.WriteLine("Using foreach - GetValues");
            foreach (int i in Enum.GetValues(typeof(WeekDays)))
                Console.WriteLine(i);

            Console.WriteLine("Using foreach - GetNames");
            foreach (string s in Enum.GetNames(typeof(WeekDays)))
                Console.WriteLine(s);

            Console.WriteLine("Using get set method");
            Meeting = WeekDays.Friday;
            Console.WriteLine(Meeting);

            Console.ReadKey();
        }
    }
}

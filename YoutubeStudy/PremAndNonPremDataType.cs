using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    class PremAndNonPremDataType
    {
        internal void PremitiveDataType ()
        {
            // mostly written in camal
            // stores in stack memory==> value type data type
            int i = 10;
            string s = "Test";
            char c = 'c';
            float f = 123.4f;
            double d = 1333.1234566667;
            bool b = true;

            Console.WriteLine($"Premitive DataType \n i = {i}\t" + 
                $"s = {s}\t" +
                $"c = {c}\t" +
                $"f = {f}\t" +
                $"d = {d}\t" +
                $"b = {b}\t");
        }

        internal void NonPremitiveDataType()
        {
            //mostly written in Pascal
            // stores in Heap memory ==> non value type data type
            Int32 i32 = 10;
            Int64 i64 = 11214568770;
            Double D = 1333.1234566667;
            Boolean Bool = true;
            object obj = 11;
            String Str = "Kiran";
            Char Ch = 'C';

            Console.WriteLine($"Non Premitive DataType \n i32 = {i32}\t" +
                $"i64 = {i64}\t" +
                $"D = {D}\t" +
                $"Bool = {Bool}\t" +
                $"obj = {obj}\t" +
                $"Str = {Str}\t" +
                $"Ch = {Ch}\t");


        }

        internal void BoxingUnboxing()
        {
            //Boxing -> implicite conversion
            int a = 10;
            object obj;
            obj = a;

            Console.WriteLine($"Boxing => obj \n  = {obj}\t");

            //Un-Boxing -> Explicite conversion
            int b = 10000;
            b = (int)obj;  // Explicite conversion

            Console.WriteLine($"Boxing => b \n  = {b}\t");


        }

        internal void ExplicitConvert()
        {
            string s = "123";
            Console.WriteLine($"s = {s}\n");

            int i32 = Convert.ToInt32(s);
            Console.WriteLine($"a32 = {i32}\n");

            float f = Convert.ToSingle(s);
            Console.WriteLine($"f = {f}\n");

            double d = Convert.ToDouble(s);
            Console.WriteLine($"d = {d}\n");

        }
    }
}

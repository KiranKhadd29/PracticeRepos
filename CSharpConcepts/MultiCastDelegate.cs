using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public delegate void RectangleCal(double Width, Double Height);
    class MultiCastDelegate
    {
        public void GetArea(double wd, double ht)
        {
            Console.WriteLine("Area of Rectangle = " + wd * ht);
        }

        public void GetPerimeter(double wd, double ht)
        {
            Console.WriteLine("Perimeter of Reactangle = " +2*(wd + ht));
        }

        public static void Main()
        {
            MultiCastDelegate mul = new MultiCastDelegate();
            //First way
            RectangleCal rectArea = new RectangleCal(mul.GetArea);
            rectArea(12.56, 13.1);

            RectangleCal rectPeri = new RectangleCal(mul.GetPerimeter);
            rectPeri(12.56, 13.1);

            Console.WriteLine("New");
            rectArea(11.11, 33.33);
            rectPeri(11.11, 33.33);

            Console.ReadKey();

            //Second way
            //RectangleCal obj = mul.GetArea;
            //obj += mul.GetPerimeter;

            //obj.Invoke(12, 13);


        }
    }
}

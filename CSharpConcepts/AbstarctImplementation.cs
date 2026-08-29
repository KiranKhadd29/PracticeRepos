using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class AbstarctImplementation
    {
        public static void Main()
        {
            Circle cir = new Circle(12.5);
            Console.WriteLine("Area of Circle = " + cir.GetArea());

            Rectangle rect = new Rectangle(10.100, 15);
            Console.WriteLine("Area of Rectangle = " + rect.GetArea());

            Console.ReadKey();

        }
    }

    abstract class Figure
    {
        public double Ht, Wd, Rd;
        public const float Pi = 3.14f;

        public abstract double GetArea();
    }

    class Circle : Figure
    {
        public Circle(Double Radius)
        {
            this.Rd = Radius;
        }
        public override double GetArea()
        {
            return Pi * Rd * Rd;
        }
        
    }

    class Rectangle : Figure
    {
        public Rectangle(Double Width, Double Height)
        {
            this.Wd = Width;
            this.Ht = Height;
        }
        public override double GetArea()
        {
            return Wd * Ht;
        }
    }


}

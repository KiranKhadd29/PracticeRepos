using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple
{
    class OpenClosedPrinciple_OCP
    {
        public static void Main()
        {
            WrongApproch_Rectangle area = new WrongApproch_Rectangle();
            area.Height = 10;
            area.Radius = 12;
            area.Width = 9;
            Console.WriteLine("---- Wrong Approach ----");
            area.AreaCalculate();

            Console.WriteLine("---- Correct Approach ----");
            Reactangle recta = new Reactangle();
            recta.Height = 10;
            recta.Width = 20;
            recta.AreaCalculator();

            Circle cir = new Circle();
            cir.Height = 10;
            cir.AreaCalculator();
            Console.ReadLine();
        }
    }

    class WrongApproch_Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }

        public void AreaCalculate()
        {
            double CalculateArea(WrongApproch_Rectangle rect)
            {
                double areaOfRect = rect.Height * rect.Width;
                Console.WriteLine("Area of Reactangle = " + areaOfRect);
                return areaOfRect;
            }

            double CalculateAreaCircle(WrongApproch_Rectangle rect)
            {
                double areaOfCirle = Math.PI * rect.Radius * rect.Radius;
                Console.WriteLine("Area of Reactangle = " + areaOfCirle);
                return areaOfCirle;
            }

            CalculateArea(this);
            CalculateAreaCircle(this);
        }
    }
    
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
        public abstract double AreaCalculator();
    }

    public class Reactangle : Shape
    {
        public override double AreaCalculator()
        {
            double areaOfRect = Height * Width;
            Console.WriteLine("Area of Reactangle = " + areaOfRect);
            return areaOfRect;
        }
    }

    public class Circle : Shape
    {
        public override double AreaCalculator()
        {
            double areaOfCirle = Math.PI * Radius * Radius;
            Console.WriteLine("Area of Reactangle = " + areaOfCirle);
            return areaOfCirle;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple
{
    class InterfaceSegregationPrinciple_ISP
    {
        public static void Main()
        {
            Console.WriteLine("---- Wrong Approach ----");
            Robot robo = new Robot();
            robo.Name = "Robo-FGY_002";
            robo.Work();
            //robo.Eat(); //Not implemenyted

            Console.WriteLine("---- Correct Approach ----");
            Robots rb = new Robots();
            rb.Name = "Robo-XFGFG123";
            rb.Work();

            Human hum = new Human();
            hum.Name = "KiranK";
            hum.Work();
            hum.Eat();

            Console.ReadLine();
        }
    }

    public interface IWorker_WrongApproch
    {
        string Name { get; set; }
        void Work();
        void Eat();
    }

    public class Robot : IWorker_WrongApproch
    {
        public string Name { get; set; }
        public void Work()
        {
            Console.WriteLine("{0} can work", Name);
        }

        public void Eat()
        {
            throw new NotImplementedException($"{Name} can't eat.");
        }
    }

    // Correct Approch /////////

    public interface IWork_CorrectApproch
    {
        string Name { get; set; }
        void Work();
    }

    public interface IEat_CorrectApproch
    {
        string Name { get; set; }
        void Eat();
    }

    public class Human : IWork_CorrectApproch, IEat_CorrectApproch
    {
        public string Name { get; set; }
        public void Work()
        {
            Console.WriteLine("{0} can work", Name);
        }
        public void Eat()
        {
            Console.WriteLine("{0} can eat", Name);
        }
    }

    public class Robots : IWork_CorrectApproch
    {
        public string Name { get; set; }

        public void Work()
        {
            Console.WriteLine("{0} can work", Name);
        }
    }
}

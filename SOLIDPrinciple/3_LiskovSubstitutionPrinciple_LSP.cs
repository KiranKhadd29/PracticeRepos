using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple
{
    class LiskovSubstitutionPrinciple_LSP
    {
        public static void Main()
        {
            

            Console.WriteLine("---- Wrong Approach ----");
            WrongApproach_Bird bird = new WrongApproach_Bird();
            bird.Fly("Parrot");
            Orchid orc= new Orchid();
            //orc.Fly("Orchid");//This is not implemented method

            Console.WriteLine("---- Correct Approach ----");
            FlyingBird par = new FlyingBird();
            par.BirdName = "Parrot";
            par.Fly();

            NonFlyingBird orch = new NonFlyingBird();
            orch.BirdName = "Orchids";
            orch.NonFly();

            Console.ReadLine();

        }
        
    }

    public class WrongApproach_Bird
    {
        public virtual void Fly(string BirdName)
        {
            Console.WriteLine("{0} can fly in air nicely.", BirdName);
        }
    }

    public class Orchid : WrongApproach_Bird
    {
        public override void Fly(string BirdName)
        {
            throw new NotImplementedException($"{BirdName} can't fly.");
        }
    }

    public abstract class CorrectApproach_Bird
    {
        public string BirdName { get; set; }

    }

    public class FlyingBird : CorrectApproach_Bird
    {
        
        public virtual void Fly()
        {
            Console.WriteLine("{0} can fly in air nicely.", BirdName);
        }

    }

    public class NonFlyingBird : CorrectApproach_Bird
    {
        public virtual void NonFly()
        {
            Console.WriteLine("{0} can not fly in air.", BirdName);
        }

    }

    //public class Parrots : FlyingBird
    //{
    //    public override void Fly()
    //    {
    //        Console.WriteLine("{0} can fly in air nicely.", BirdName);
    //    }
    //}

    //public class Orchids : NonFlyingBird
    //{
    //    public override void NonFly()
    //    {
    //        Console.WriteLine("{0} can not fly in air.", BirdName);
    //    }
    //}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple
{
    class DependencyInversionPrinciple_DIP
    {
        public static void Main()
        {
            Console.WriteLine("---- Wrong Approach ----");
            LightBuld_WrongApproach lb = new LightBuld_WrongApproach();
            LightBuld_WrongApproach.Switch sw = new LightBuld_WrongApproach.Switch(lb);
            lb.TurnOn();

            Console.WriteLine("---- Correct Approach ----");
            LightBuld_CorrectApproach lb2 = new LightBuld_CorrectApproach();
            lb2.TurnOff();

            Console.ReadLine();
        }
    }

    public class LightBuld_WrongApproach
    {
        public void TurnOn()
        {
            Console.WriteLine("Bulb is Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Bulb is Turned Off");
        }

        public class Switch
        {
            LightBuld_WrongApproach _LB;

            public Switch(LightBuld_WrongApproach lb)
            {
                _LB = lb;
            }

            public void Operate()
            {
                _LB.TurnOn();
            }
            
        }
    }

    //Correct approach
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }

    public class LightBuld_CorrectApproach:IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Bulb is Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Bulb is Turned Off");
        }
    }

    public class Switch_Correct
    {
        IDevice _device;

        public Switch_Correct(IDevice device)
        {
            _device = device;
        }

        public void Operate()
        {
            _device.TurnOn();
        }

    }
}

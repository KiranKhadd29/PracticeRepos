using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class Program
    {
        int x; bool y;
        static void Main(string[] args)
        {
            //Default or Implicit constructor
            Console.WriteLine("Default or Implicit constructor");
            Program p = new Program();
            Console.WriteLine("Value of x:" + p.x);
            Console.WriteLine("Value of y:" + p.y);

            /********** output **************
             * Value of x:0
             * Value of y:False
             * *******************************/
            //--------------------End of topic----------------------------------------------//
            ExplicitConstructor ex = new ExplicitConstructor();
            /********** output **************
             * Constuctor called!!!
             * Value of num:0
             * *******************************/
            ExplicitConstructor paraConstr = new ExplicitConstructor(500);
            /********** output **************
             * Para Constuctor called!!!
             * Value of num:500
             * *******************************/
            ExplicitConstructor copyConstr = new ExplicitConstructor(paraConstr);
            /********** output **************
             * Copy Constuctor called!!!
             * Value of num:500
             * *******************************/
            //--------------------End of topic----------------------------------------------//
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class Program
    {
        //int x; bool y;

        private void test1()
        {
            Console.WriteLine("Private - Within class");
        }
        public void test2()
        {
            Console.WriteLine("public - Within class");
        }
        internal void test3()
        {
            Console.WriteLine("internal - Within class");
        }
        protected void test4()
        {
            Console.WriteLine("protected - Within class");
        }
        protected internal void test5()
        {
            Console.WriteLine("protected internal- Within class");
        }
        public static void Main(string[] args)
        {
            //Default or Implicit constructor
            //Console.WriteLine("Default or Implicit constructor");
            //Program p = new Program();
            //Console.WriteLine("Value of x:" + p.x);
            //Console.WriteLine("Value of y:" + p.y);

            /********** output **************
             * Value of x:0
             * Value of y:False
             * *******************************/
            //--------------------End of topic----------------------------------------------//
            // Every time will print this -> static Constuctor called!!!
            //ExplicitConstructor ex = new ExplicitConstructor();
            /********** output **************
             * Constuctor called!!!
             * Value of num:0
             * *******************************/
            //ExplicitConstructor paraConstr = new ExplicitConstructor(500);
            /********** output **************
             * Para Constuctor called!!!
             * Value of num:500
             * *******************************/
            //ExplicitConstructor copyConstr = new ExplicitConstructor(paraConstr);
            /********** output **************
             * Copy Constuctor called!!!
             * Value of num:500
             * *******************************/
            //--------------------End of topic----------------------------------------------//
            Program p = new Program();
            p.test1();
            p.test2();
            p.test3();
            p.test4();
            p.test5();

            /********** output **************
             * Private - Within class
             * public - Within class
             * internal - Within class
             * protected - Within class
             * protected internal- Within class
             * *******************************/
            AccessModifierOutsideClass outside = new AccessModifierOutsideClass();
            //outside.test1();
            outside.test2();
            outside.test3();
            //outside.test4();
            outside.test5();

            /********** output **************
             * Private - outside class ->Not Accessible
             * public - outside class
             * internal - outside class
             * protected - outside class  -> Not Accessible
             * protected internal- outside class
             * *******************************/

            Console.ReadKey();

        }
    }
}

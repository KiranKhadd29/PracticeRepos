using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class AccessModifierOutsideClass
    {
        private void test1()
        {
            Console.WriteLine("Private - outside class");
        }
        public void test2()
        {
            Console.WriteLine("public - outside class");
        }
        internal void test3()
        {
            Console.WriteLine("internal - outside class");
        }
        protected void test4()
        {
            Console.WriteLine("protected - outside class");
        }
        protected internal void test5()
        {
            Console.WriteLine("protected internal- outside class");
        }
    }
}

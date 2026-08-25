using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class ProgramClassChild : Program
    {
        static void Main()
        {
            ProgramClassChild pro = new ProgramClassChild();
            //pro.test1();
            pro.test2();
            pro.test3();
            pro.test4();
            pro.test5();
            Console.ReadKey();

            /********** output **************
             * Private - Child class ->Not Accessible
             * public - Child class
             * internal - Child class
             * protected - Child class
             * protected internal- Child class
             * *******************************/

        }
    }

    
}

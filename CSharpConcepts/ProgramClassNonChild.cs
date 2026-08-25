using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class ProgramClassNonChild
    {
        void Main()
        {
            Program pro = new Program();
            //pro.test1();
            pro.test2();
            pro.test3();
            //pro.test4();
            pro.test5();
            Console.ReadKey();

            /********** output **************
             * Private - Non Child class ->Not Accessible
             * public - Non Child class
             * internal - Non  Child class
             * protected - Non Child class ->Not Accessible
             * protected internal- Non Child class
             * *******************************/
        }
    }
}

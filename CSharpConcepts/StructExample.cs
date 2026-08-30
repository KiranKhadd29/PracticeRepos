using System;
namespace CSharpConcepts
{
    struct StructConcept
    {
        int i;

        public StructConcept(int num)
        {
            this.i = num;
            Console.WriteLine("Exp Para Constructor called with para - " + num);
        }
        static void Main()
        {
            //First appr - Constructor created
            StructConcept str1 = new StructConcept();
            Console.WriteLine("First appr : " + str1.i);

            //Second appr
            StructConcept str2;
            str2.i = 10;
            Console.WriteLine("Second appr : " + str2.i);

            //Third appr - Constructor created
            StructConcept str3 = new StructConcept(100);
            Console.WriteLine("Third appr : " + str3.i);

            Console.ReadKey();

        }
    }
}
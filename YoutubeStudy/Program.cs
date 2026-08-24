using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    class Program
    {
        static Program()
        {
            Console.WriteLine("This is a static contructor runs before main method");
        }
        
        static void Main(string[] args)
        {
            SwapNumbers sw = new SwapNumbers();
            //sw.SwapNumbersWithThirdVariable();
            //sw.SwapNumbersWithoutThirdVariable();
            //sw.SwapNumbersWithoutThirdVariable2();

            AdditionProgram ap = new AdditionProgram();
            //ap.AdditionWithoutPlusSign();

            PremAndNonPremDataType prem = new PremAndNonPremDataType();
            //prem.PremitiveDataType();
            //prem.NonPremitiveDataType();
            //prem.BoxingUnboxing();
            //prem.ExplicitConvert();

            OperatorPractice op = new OperatorPractice();
            //op.IncrementDecrementPrg();
            //op.TernaryOperator();

            VowelProgram vow = new VowelProgram();
            //vow.FindVowelUsingSwitch();
            //vow.VowelUsingArray();

            PatternPrograms pattern = new PatternPrograms();
            //Console.WriteLine("Ladder");
            //pattern.Ladder();
            //Console.WriteLine("");
            //Console.WriteLine("ReverseLadder");
            //pattern.ReverseLadder();
            //Console.WriteLine("");
            //Console.WriteLine("Mountain");
            //pattern.Mountain();
            //Console.WriteLine("");
            //Console.WriteLine("Diamond");
            //pattern.Diamond();

            FloorNumberDisplay floor = new FloorNumberDisplay();
            //floor.FloorNumberDisplayUsingWhile();

            ArrayProgram array = new ArrayProgram();
            //array.simpleArrayProgram();
            //array.MaxAndMinValueInArray();
            //array.multiDimArray();
            //array.MultiDimArrayMultiplication();
            //array.JaggedArray();

            ArraySortPrograms arrSort = new ArraySortPrograms();
            //arrSort.SelectionSort();

            //ConstructorExamples constr = new ConstructorExamples();
            //constr.Addition();

            //ConstructorExamples constr2 = new ConstructorExamples(500,600);
            //constr2.Addition();

            //ConstructorExamples constr3 = new ConstructorExamples(constr2);
            //constr3.Addition();

            PropertyEx proEx = new PropertyEx();
            Console.WriteLine(proEx.X);
            proEx.X = 1;
            Console.WriteLine(proEx.X);

            Console.ReadKey();
        }
    }
}

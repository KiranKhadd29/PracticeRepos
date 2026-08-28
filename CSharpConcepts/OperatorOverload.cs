using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class OperatorOverload
    {
        public static void Main()
        {
            Matrix mat1 = new Matrix(1,2,3,4);
            Matrix mat2 = new Matrix(10, 20, 30, 40);
            Matrix mat3 = mat1 + mat2;
            Console.WriteLine("Enter First Matrix");
            Console.WriteLine(mat1);
            Console.WriteLine("Enter Second Matrix");
            Console.WriteLine(mat2);
            Console.WriteLine("Addition of First and Second Matrix");
            Console.WriteLine(mat3);
            Console.ReadLine();
        }
    }

    //Overrided concept used here
    class Matrix : Object
    {
        int num1, num2, num3, num4;
        public Matrix(int a, int b, int c, int d)
        {
            this.num1 = a;
            this.num2 = b;
            this.num3 = c;
            this.num4 = d;
        }

        // This is explicit op overloading
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(
                obj1.num1 + obj2.num1,
                obj1.num2 + obj2.num2,
                obj1.num3 + obj2.num3,
                obj1.num4 + obj2.num4);
            return obj;
        }

        //here object's fun/method is overrided
        public override string ToString()
        {
            return 
                num1 + " " + num2+ "\n" +
                num3 + " " + num4 + " ";
        }

    }
}

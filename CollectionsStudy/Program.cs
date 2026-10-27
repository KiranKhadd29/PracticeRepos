using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();// by default length will 4
            ArrayList al = new ArrayList(2);
            Console.WriteLine(al.Capacity);
            al.Add(100);
            al.Add(200);
            Console.WriteLine(al.Capacity);
            al.Add(400);
            Console.WriteLine(al.Capacity);
            al.Add(500);
            al.Add(600);
            al.Add(1000);
            Console.WriteLine(al.Capacity);

            foreach(object obj in al)
                Console.Write(obj + " ");

            al.Insert(2, 300);
            Console.WriteLine();

            foreach (object obj in al)
                Console.Write(obj + " ");

             al.Insert(6, 700);
             al.Insert(7, 800);
             al.Insert(8, 900);
            Console.WriteLine();

            foreach (object obj in al)
                Console.Write(obj + " ");

            al.Remove(500);
            al.RemoveAt(2);
            al.RemoveAt(3);
            al.Remove(600);
            Console.WriteLine();

            foreach (object obj in al)
                Console.Write(obj + " ");

            Console.ReadLine();

        }
    }
}

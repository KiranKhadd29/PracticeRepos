using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class ParentLoad
    {
        internal void Load()
        {
            Console.WriteLine("Parent Loaded.");
        }

        internal void Show()
        {
            Console.WriteLine("Parent Show.");
        }

        public virtual void Test() //Overridble
        {
            Console.WriteLine("Parent testing for overriding.");
        }

        internal void OverHinding ()
        {
            Console.WriteLine("Parent testing for overhiding.");
        }
    }

    class ChildLoad : ParentLoad
    {
        //Method overloading
        void Show(string s)
        {
            Console.WriteLine("Child Show.");
        }

        //Mehod overriding
        public override void Test()
        {
            Console.WriteLine("Child is overrided the Parent.");
        }

        //Method Overhiding
        public new void OverHinding()
        {
            Console.WriteLine("Child is overhided the Parent.");
        }

        public void ParentAccessWithoutObjInChild ()
        {
            base.Test();
            base.OverHinding();
        }
        public static void Main()
        {
            ChildLoad child = new ChildLoad();
            //child.Load();
            //child.Show();
            //child.Show("k");
            //child.Test();
            //child.OverHinding();

            ParentLoad parent;
            parent = child;
            parent.Test();
            parent.OverHinding();

            //Accessing the Parent from child even its overrided/hided
            child.ParentAccessWithoutObjInChild();

            Console.ReadKey();
        }
        
        
    }
}

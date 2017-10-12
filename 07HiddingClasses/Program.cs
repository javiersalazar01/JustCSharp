using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07HiddingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
            ChildClass2 cc2 = new ChildClass2();
            ParentClass pc = new ParentClass();

            //cc.MyMethod();
            
            ((ParentClass)cc).MyMethod();
            ((ParentClass)cc2).MyMethod();
            pc.MyMethod();

            Console.ReadLine();
        }
    }

    public class ParentClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Parent Class");
        }
    }

    public class ChildClass : ParentClass
    {
        //use new to indicate that here is a new class
        public override void MyMethod()
        {
            Console.WriteLine("Child Class 1");
        }
    }

    public class ChildClass2 : ParentClass
    {
        //use new to indicate that here is a new class
        public override void MyMethod()
        {
            Console.WriteLine("Child Class 2");
        }
    }
}

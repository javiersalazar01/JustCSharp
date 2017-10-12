using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();

            c.MyMethod();
        }
    }

    interface MyInterface1
    {
        void MyMethod();
    }

    interface MyInterface2
    {
        void MyMethod();
    }

    class MyClass : MyInterface1, MyInterface2
    {
        public void MyMethod()
        {
            Console.WriteLine("Hola mundo");
        }
        
        void MyInterface1.MyMethod()
        {
            
        }
    }
}

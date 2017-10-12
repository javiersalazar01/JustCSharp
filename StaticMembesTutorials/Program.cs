using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembesTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass c = new SomeClass("super value");
            c.saySomething();
            Console.ReadKey();

            c = new SomeClass("martin");
        }
    }

    class SomeClass
    {
        private string field;
        public static string staticField;

        //First Constructor call at the beggining of the execuion f the class.
        static SomeClass()
        {
            staticField = "some value";
            Console.WriteLine("Static Constructor Called");

        }

        public SomeClass(string value)
        {
            this.field = value;
        }

        ~SomeClass()
        {
            Console.WriteLine("Destructor Called");
        }

        public static void staticMethod()
        {
            Console.WriteLine("some static method");
        }

        public void saySomething()
        {
            Console.WriteLine("Hi this is something");
        }
    }
}

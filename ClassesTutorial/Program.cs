using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("miguel","rodrigues");

            c1.sayHi();

            Customer c2 = new Customer();

            c2.sayHi();

            Console.ReadLine();
        }
    }

    class Customer
    {

        public static string staticField;

        public string _firstName;
        public string _lastName;

        static Customer()
        {
            Console.WriteLine();
            staticField = "some Static Value";
        }
        public Customer() : this("juan","estrada")
        {

        }

        public Customer (string firstName, string lastName)
        {
            this._lastName = lastName;
            this._firstName = firstName;
        }

        ~Customer()
        {
            Console.WriteLine("Destructor Called");
        }

        public void sayHi()
        {
            Console.WriteLine($"Hi I am {_firstName} {_lastName}");
        }

        
    }
}

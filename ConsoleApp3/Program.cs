using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            methodsWithReferences(ref i);

            Console.WriteLine(i);
            Console.WriteLine("================================");


            int suma;
            int resta;

            methodsWithOut(2,3, out suma,out resta);

            Console.WriteLine($"sum: {suma} rest: {resta}");
            Console.WriteLine("================================");

            methodWithParams(2,3,1,2,3,1);

            Console.ReadLine();
        }

        static void methodsWithReferences(ref int number)
        {
            number = 123;
        }

        static int methodsWithOut(int numberA, int numberB, out int suma, out int rest)
        {
            int sum = numberA + numberB;
            int resta = numberA - numberB;
            rest = resta;

            suma = sum;
            return sum;
        }
        static void methodWithParams(int x, params int[] numbers)
        {
            
            Console.WriteLine(String.Join(",",numbers));
        }
    }
}

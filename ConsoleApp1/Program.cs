using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7 };

            int result = sumArray(myArray);

            Console.WriteLine(result);

            Console.WriteLine("Second Exercise");

            int res = sumPrimes(5);
            Console.WriteLine(res);

            Console.WriteLine("Third Exercise");

            string line = "5155,16";

            string[] splited = line.Split(new char[] { ',' });

            int x = Convert.ToInt32(splited[0]);
            int n = Convert.ToInt32(splited[1]);

            int multiple = 0;
            int i = 1;
            while (multiple < x)
            {
                multiple = n * i;
                i++;
            }

            Console.WriteLine(multiple);

            Console.ReadLine();
        }

        static int sumArray(int[] sum)
        {
            int res = 0;
            foreach (int item in sum)
            {
                res += item;
            }

            return res;
        }
        
        /*
            bool myBool = true;

            byte myByte = 255;
            sbyte MySbyte = 127;

            short myShort = -16000;
            ushort myUShort = 12352;

            int myInt = 23;
            uint MyUint = 23;
            
            float myFloat = 2323.343f;
            decimal myDecimal = 2323.232M; 

            
            
         */

        static int sumPrimes(int numberToSum)
        {
            int primesCounter = 0;
            int sum = 0;

            for (int i = 2; primesCounter < numberToSum; i++)
            {
                if (isPrime2(i))
                {
                    sum += i;
                    primesCounter++;
                }
            }


            return sum;
        }

        static bool isPrime(int number)
        {

            if (number == 2)
            {
                return true;
            }

            bool isPrime = number == 1 ? false : true;

            for (int i = number - 1; i > 1; i--)
            {

                if (number % i == 0)
                {
                    isPrime = false;
                    return isPrime;
                }
            }

            return isPrime;
        }
        
        static bool isPrime2(int number)
        {
            bool isPrime = true;
            if (number == 2 || number == 3 || number == 5 || number == 7)
            {
                return true;
            }
            if (number % 2 == 0 ||
                number % 3 == 0 ||
                number % 4 == 0 ||
                number % 5 == 0 ||
                number % 6 == 0 ||
                number % 7 == 0 ||
                number % 8 == 0 ||
                number % 9 == 0 )
            {
                isPrime = false;
            }
            return isPrime;
        }
    }
}

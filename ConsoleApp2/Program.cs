using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000;
            
            Start:
            Console.Write("Welcome to the ATM System what would you like to do: \n" +
                              "1 - Check Balance.\n" +
                              "2 - Withdraw\n" +
                              "3 - Add Money\n" +
                              "4 - Exit\n" +
                              "========>");

            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine($"\nyour Balance is: {balance}\n");
                    goto Start;
                case 2:
                    Console.Write("How Much would you like to Withdraw:\n" +
                        "1 - 500\n" +
                        "2 - 1000\n" +
                        "3 - 2000\n" +
                        "4 - 5000\n" +
                        "======>");
                    int selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            balance -= 500;
                            break;
                        case 2:
                            balance -= 1000;
                            break;
                        case 3:
                            balance -= 2000;
                            break;
                        case 4:
                            balance -= 5000;
                            break;

                    }
                    Console.WriteLine($"\nYour new balance: {balance}\n");
                    goto Start;
                case 3:
                    Console.Write("How Much would you like to Add:\n" +
                        "1 - 500\n" +
                        "2 - 1000\n" +
                        "3 - 2000\n" +
                        "4 - 5000\n" +
                        "======>");
                    int selection3 = Convert.ToInt32(Console.ReadLine());
                    switch (selection3)
                    {
                        case 1:
                            balance += 500;
                            break;
                        case 2:
                            balance += 1000;
                            break;
                        case 3:
                            balance += 2000;
                            break;
                        case 4:
                            balance += 5000;
                            break;

                    }
                    Console.WriteLine($"\nYour new balance: {balance}\n");
                    goto Start;
                case 4:
                    Console.WriteLine("\nPrograma Finalizado");
                    break;
            }
            Console.ReadLine();
        }
    }
}

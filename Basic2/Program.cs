using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice,c=1;
            while (c==1)
            {

                Console.WriteLine("Welcome");
                Console.Write("1.SwapTwoNumbers \n2.Fibonacci \n3.prime number \n4..Reverse number ");
                Console.WriteLine("Enter any choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                switch (choice)
                {
                    case 1:

                    SwapTwoNumber swapTwoNumber = new SwapTwoNumber();
                    swapTwoNumber.SwapNumbers();
                    break;

                    case 2:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.FibonacciSeries();
                    break;

                    case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Prime();
                    break;

                    case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.FindReverseofNumber();
                    break;

                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;

                }
                Console.WriteLine("\n press 1 to continue and press any for exit");
                c = Convert.ToInt32(Console.ReadLine());

            }

            Console.Read();
        }
    }
}

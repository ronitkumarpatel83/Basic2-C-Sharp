using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic2
{
    internal class Fibonacci
    {
        public void FibonacciSeries()
        {
            int first = 0, second = 1, res = 0;
            int length = 0;
            Console.WriteLine("Please enter n value to generate number");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(length+" Fibonacci series are: ");
            Console.WriteLine(" " + res);
            Console.WriteLine(first + "" + second);

            for (int i = 0; i < length; i++)
            {
                first = second;
                second = res;
                res = first + second;
                Console.Write(" " + res);
            }
        }
    }
}

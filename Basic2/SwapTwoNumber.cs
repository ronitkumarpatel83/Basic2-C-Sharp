using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic2
{
    internal class SwapTwoNumber
    {
        public int first, second, temp;

        public void SwapNumbers()
        {
            Console.WriteLine("Enter first number : ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapped");
            Console.WriteLine("Enter First number"+first+" Enter Second number "+second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After swapping");
            Console.WriteLine("Enter First number" + first + " Enter Second number " + second);
        }
    }
}

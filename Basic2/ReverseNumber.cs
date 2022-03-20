using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic2
{
    class ReverseNumber
    {
        public int no, reverse = 0, actualno;

        public void FindReverseofNumber()
        {
            Console.WriteLine("Enter any number : ");
            no = Convert.ToInt32(Console.ReadLine());
            actualno = no;
            while (no > 0)
            {
                reverse = (reverse * 10);
                reverse = reverse + (no % 10);
                no = no / 10;
            }
            Console.WriteLine($"The reverse of {actualno} is : {reverse}");
        }
    }
}
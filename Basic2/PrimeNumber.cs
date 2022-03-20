using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic2
{
	internal class PrimeNumber
	{
		public int prime = 0, no;
		public void Prime()
		{
			Console.WriteLine("Enter any number : ");
			no = Convert.ToInt32(Console.ReadLine());

			if (no == 0 || no == 1)
			{
				Console.WriteLine($"{no} is not async Prime Number");
			}
			else
			{
				for (int i = 2; i < no; i++)
				{
					if ((no % i) == 0)
					{ prime = 0; }
					else { prime = 1; }
				}

				if (prime == 1)
				{
					Console.WriteLine($"{no} is a Prime Number");
				}
				else
				{
					Console.WriteLine($"{no} is not a Prime Number");
				}
			}
		}


	}
}
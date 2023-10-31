using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._1
{
	class Print
	{
		public void PrintOf(List<int> number) 
		{
			int i = 1;
			foreach (int numbers in number) 
			{
                Console.WriteLine($"{i} - {numbers}");
				i++;
				
            }
		}
	}
}

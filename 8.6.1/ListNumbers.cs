using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._1
{
	class ListNumbers
	{
		public List<int> NumberList()
		{

			List<int> ints = new List<int>();

			Random rnd = new Random();
			for (int i = 0; i<100; i++)
			{
				ints.Add(rnd.Next(0, 100));
			}
			return ints;
		}
	}
}

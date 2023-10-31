using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ListNumbers listNumbers = new ListNumbers();
			List<int> numbers = listNumbers.NumberList();
            Console.WriteLine("Список из 100 чисел");
            Print print = new Print();
			print.PrintOf(numbers);
			Console.ReadLine();

			ModifyListNumber modifyListNumber = new ModifyListNumber();
			List<int> modifyList = modifyListNumber.ModifyList(numbers);
            Console.WriteLine("Измененный список чисел");
            print.PrintOf(modifyList);
			Console.ReadLine();
		}
	}
}

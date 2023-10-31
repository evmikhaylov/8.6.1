using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._1
{
	class ModifyListNumber
	{
		public List <int> ModifyList(List<int> numberList)
		{
			List<int> modifyList = numberList;
			modifyList.RemoveAll(item => item > 25 && item < 50);
            return modifyList;
		}
	}
}

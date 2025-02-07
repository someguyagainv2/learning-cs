using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] list = {1, 3, 5, 9, 12};

			Console.WriteLine(list[2]);
			list[2] = 9;
			Console.WriteLine(list[2]);

		}
	}
}

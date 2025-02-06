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
			int valueInt = 5;
			string valueConverted = Convert.ToString(valueInt);
			string valueConvertedWithoutVariable = Convert.ToString(9);
			Console.WriteLine(valueConverted);
			Console.WriteLine(valueConvertedWithoutVariable);
		}
	}
}

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
			string usernameInserted = "someone", password = "password";

			if (usernameInserted == "someone" && password == "password") {
				Console.WriteLine("Correct login");
			}
			else {
				Console.WriteLine("Incorrect login");
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
	internal class ClassGen
	{
		public static int Generaitor()
		{
			string construct = "";
			string[] index = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
			var a = new Random();
			for (int i = 0; i < 8; i++)
			{
				int run = a.Next(index.Length);
				construct += Convert.ToString(index[run]);
			}
			Console.WriteLine(construct);
			return 0;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise02
	{
		// Даны два целых числа A и В . 
		// Выведите все числа от A до B включительно, 
		// в порядке возрастания, если A < B, 
		// или в порядке убывания в противном случае.
		public static string Run(int a, int b)
		{
            if (a == b)
                return a.ToString();
            if (a < b)
                return Run(a, b - 1) + " " + b.ToString();
            if (a > b)
                return Run(a, b + 1) + " " + b.ToString();
            return "";
		}
	}
}

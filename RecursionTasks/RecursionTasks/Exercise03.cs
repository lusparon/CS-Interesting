using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise03
	{
		// Даны два целых числа A и В . 
		// Выведите все числа от A до B включительно, 
		// всегда в порядке возрастания.
		public static string Run(int a, int b)
		{
            int min = a;
            int max = b;
            if (min > max)
            {
                int t = min;
                min = max;
                max = t;
            }

            if (min == max)
                return a.ToString();
            if (min < max)
                return Run(min, max - 1) + " " + max.ToString();
            return "";
        }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
    public class Exercise01
	{
		// Дано целое число n. Выведите все числа от 1 до n.
		public static string Run(int n)
		{
            if (n <= 0)
                return "";
            if (n == 1)
                return "1";
            if (n > 1)
                return Run(n - 1) + " " +n.ToString();
            return "";
		}
	}
}

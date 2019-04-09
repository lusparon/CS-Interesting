using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise07
	{
		// Дано целое число N. Выведите все его цифры по одной, 
		// в обратном порядке, разделяя их пробелами.
		// При решении этой задачи нельзя использовать строки, списки, 
		// массивы и циклы. Разрешена только рекурсия и целочисленная арифметика.
		public static string Run(Int64 n)
		{
            n = Math.Abs(n);
            if (n / 10 == 0)
                return n.ToString();
            return (n%10).ToString() + " " + Run(n / 10);
        }
	}
}

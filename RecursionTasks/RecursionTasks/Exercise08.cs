using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise08
	{
		// Дано целое число N. Выведите все его цифры по одной, 
		//  в обычном порядке, разделяя их пробелами.
		// При решении этой задачи нельзя использовать строки, списки, 
		// массивы и циклы. Разрешена только рекурсия и целочисленная арифметика.
		public static string Run(Int64 n)
		{
            n = Math.Abs(n);
            if (n / 10 == 0)
                return n.ToString();
            return Run(n / 10) + " " + (n % 10).ToString();
        }
	}
}

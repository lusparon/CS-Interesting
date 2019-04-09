using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise11
	{
		// Дано число n, цифры которого не содержат нулей. 
		// Получите число, записанное теми же цифрами, 
		// но в противоположном порядке.
		// При решении этой задачи нельзя использовать циклы, строки, списки, массивы, 
		// разрешается только рекурсия и целочисленная арифметика.
		public static long Run(int n)
		{
			return RunInternal(n, 0);
		}

		private static int RunInternal(int n, int i)
		{
            if (n / 10 == 0)
                return n;
            return 0;
		}
	}
}

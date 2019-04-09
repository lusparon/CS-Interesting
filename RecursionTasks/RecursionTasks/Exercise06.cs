using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise06
	{
		// Дано целое число N. Вычислите сумму его цифр.
		// При решении этой задачи нельзя использовать строки, списки, массивы и циклы.
		public static Int64 Run(Int64 n)
		{
            n = Math.Abs(n);
            if (n / 10 == 0)
                return n;
            return n % 10 + Run(n/10);
		}
	}
}

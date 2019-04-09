using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise05
	{
		// Дано целое число N. 
		// Верните true, если число N является точной степенью двойки, или false в противном случае.
		// Операцией возведения в степень пользоваться нельзя!
		public static bool Run(int n)
		{
            if (n == 0)
                return false;
            if (n == 1)
                return true;
            if (n % 2 == 0)
                return Run(n / 2);
            else return false;
		}
	}
}

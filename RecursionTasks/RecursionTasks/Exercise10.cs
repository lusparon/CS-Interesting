using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise10
	{
		// Даны числа a и b. Определите, сколько существует последовательностей 
		// из a нулей и b единиц, в которых никакие два нуля не стоят рядом.
		public static int Run(int a, int b)
		{
            if (a > b && a - b >= 2)
                return 0;
            return 0;
		}
	}
}

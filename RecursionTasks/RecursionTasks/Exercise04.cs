using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise04
	{
		// В теории вычислимости важную роль играет функция Аккермана A(m,n), 
		// определенная следующим образом:
		// https://wikimedia.org/api/rest_v1/media/math/render/svg/c8c2aa0b20532014ea35c4a09c2380a01b3d1423
		// Даны два целых неотрицательных числа m и n. Выведите A(m,n).
		public static int Run(int m, int n)
		{
            int res = 0;
            if (m == 0)
                res =  n + 1;
            else
                if (m > 0 && n == 0)
                    res = Run(m - 1, 1);
            else
                if (m > 0 && n > 0)
                    res =Run(m-1 , Run(m,n-1));
            return res;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise09
	{
		// Дано слово, состоящее только из строчных латинских букв. 
		// Проверьте, является ли это слово палиндромом. 
		// При решении этой задачи нельзя пользоваться циклами.
		public static bool Run(string s)
		{
            s = s.ToLower();
            if (s == "")
                return true;
            if (s.Length == 1)
                return true;
            if (s.Length == 2 && s.First() == s.Last())
                return true;
            if (s.First() == s.Last())
                return Run(s.Substring(1,s.Length-2));
            return false;
		}
	}
}

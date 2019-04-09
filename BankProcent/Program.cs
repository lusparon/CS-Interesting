using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProcent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры : ");
            string s = Console.ReadLine();
            Console.WriteLine("Накопившаяся сумма на момент окончания вклада : " + Calculate(s));
        }

        public static double Calculate(string userInput)
        {
            string[] s1= userInput.Split(' ');
            double sum = double.Parse(s1[0]);
            double procent = Convert.ToDouble(s1[1]);
            int months = Convert.ToInt32(s1[2]);
            return sum*Math.Pow((1+procent/1200),months*1.0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixFunctionCode
{
    class Task
    {
        public static int Power(int number, int exponent)
        {
            int result = 1;
            for (int i = 1; i <= exponent; i++)
            {
                result = result * number;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine(n + "^" + e + "=" + Task.Power(n, e));
            Console.ReadKey();
        }
    }
}
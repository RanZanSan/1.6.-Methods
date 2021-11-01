using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterTheReturnValue
{
    class Program
    {
        static int GetNumber(int n)
        {
            if (n < 0)
            {
                return 0;
            }

            if (n % 2 == 1)
            {
                return 2 * n;
            }

            return n;
        }

        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetNumber(num));
            Console.ReadKey();
        }
    }
}
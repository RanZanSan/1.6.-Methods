using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betweenMethods
{
    class Program
    {
        static int GetNumber1(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            if (n == 0)
            {
                return 0;
            }

            return 1;
        }

        static int GetNumber2(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetNumber1(number));
            Console.WriteLine(GetNumber2(number));
            Console.ReadKey();
        }
    }
}
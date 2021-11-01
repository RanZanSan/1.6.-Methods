using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixTheError
{
    class Task
    {
        internal static void Average(double a, double b)
        {
            Console.WriteLine((a + b) / 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task.Average(5, 7);
            Console.ReadKey();
        }
    }
}
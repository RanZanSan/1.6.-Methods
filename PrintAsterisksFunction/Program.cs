using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAsterisksFunction
{
    class Task
    {
        public static void PrintAsterisks (int asterisk)
        {
            for (int i = 0; i < asterisk; i++)
            {
                Console.Write('*');
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task.PrintAsterisks(10);
            Console.ReadKey();
        }
    }
}
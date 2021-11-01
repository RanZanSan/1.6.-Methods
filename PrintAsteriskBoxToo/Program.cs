using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAsteriskBoxToo
{
    class Task
    {
        public static void PrintAsterisks(int lineLength)
        {
            for (int i = 0; i < lineLength; i++)
            {
                Console.Write('*');
            }
        }

        public static void PrintAsteriskBox(int lineLength, int paragraphLine)
        {
            for (int i = 0; i < paragraphLine; i++)
            {
                PrintAsterisks(lineLength);
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task.PrintAsteriskBox(5, 3);
            Console.ReadKey();
        }
    }
}
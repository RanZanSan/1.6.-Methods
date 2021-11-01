using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAsteriskBoxFunction
{
    class Task
    {
        public static void PrintAsteriskBox(int lineLength, int paragraphLine)
        {
            for (int i = 0; i < paragraphLine; i++)
            {
                for (int j = 0; j < lineLength; j++)
                {
                    Console.Write('*');
                }
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
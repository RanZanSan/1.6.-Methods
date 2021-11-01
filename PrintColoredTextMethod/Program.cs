using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintColoredTextMethod
{
    class Task
    {
        public static void PrintColoredText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Применим наш метод, чтобы вывести строки красного и желтого цвета.
            // Аналогично проверь, что метод работает для других цветов и текста
            Task.PrintColoredText("This text should be red", ConsoleColor.Red);
            Task.PrintColoredText("This text should be yellow", ConsoleColor.Yellow);
            Console.ReadKey();
        }
    }
}
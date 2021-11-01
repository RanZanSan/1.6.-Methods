using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPairsFunction
{
    class Task
    {
        public static void CheckPairs(string stringCheck, char charFirst, char charSecond)
        {
            string answer = String.Empty;
            int countOpeningBracket = 0;
            int countClosingBrace = 0;

            int countIndex = 0;
            for (int index = 0; index < stringCheck.Length; index++)
            {
                if (stringCheck[index] == charFirst)
                {
                    countOpeningBracket++;
                    countIndex++;
                }
                else if (stringCheck[index] == charSecond)
                {
                    countClosingBrace++;
                    countIndex--;
                }

                if (countIndex < 0)
                    break;
            }
            if ((countOpeningBracket == countClosingBrace) && (countIndex == 0))
                answer = "Все в порядке";
            else
                answer = "Найдены ошибки";

            Console.WriteLine(answer);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task.CheckPairs("graphics = e.Graphics;graphics.SmoothingMode = SmoothingMode.AntiAlias;graphics.Clear(Color.FromArgb(0x44444400));DrawCar(carX, 200);", '(', ')'); /* Все в порядке */
            Console.ReadKey();
        }
    }
}
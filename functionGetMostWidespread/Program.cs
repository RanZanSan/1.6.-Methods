using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionGetMostWidespread
{
    class Task
    {
        public static string GetMostWidespread(string[] stringsPenguins)
        {
            string answer = string.Empty;
            int countEmperorPenguins = 0;
            int countLittlePenguins = 0;
            int countMacaroniPenguins = 0;

            for (int index = 0; index < stringsPenguins.Length; index++)
            {
                if (stringsPenguins[index] == "Emperor Penguin")
                    countEmperorPenguins++;
                else if (stringsPenguins[index] == "Little Penguin")
                    countLittlePenguins++;
                else if (stringsPenguins[index] == "Macaroni Penguin")
                    countMacaroniPenguins++;
            }

            if (countEmperorPenguins >= countLittlePenguins && countEmperorPenguins >= countMacaroniPenguins)
                answer = "Emperor Penguin";
            else if (countLittlePenguins >= countEmperorPenguins && countLittlePenguins >= countMacaroniPenguins)
                answer = "Little Penguin";
            else if (countMacaroniPenguins >= countEmperorPenguins && countMacaroniPenguins >= countLittlePenguins)
                answer = "Macaroni Penguin";

            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string mostWidespread = Task.GetMostWidespread(new[] { "Emperor Penguin", "Macaroni Penguin", "Emperor Penguin", "Little Penguin" });
            Console.WriteLine(mostWidespread); // Emperor Penguin
            Console.ReadKey();
        }
    }
}
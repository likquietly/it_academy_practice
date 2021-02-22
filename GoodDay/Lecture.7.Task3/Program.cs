using System;

namespace Lecture._7.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userArr = new int[13];

            Random rnd = new Random();

            for (int i = 0; i < userArr.Length; i++)
            {
                userArr[i] = rnd.Next(13);
                Console.Write(userArr[i] + " ");
            }

            Array.Sort(userArr);
            int maxValue = userArr[userArr.Length - 1];
            Console.WriteLine("Max value is: " + maxValue);
        }
    }
}

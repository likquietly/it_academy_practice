using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            short count = 0;

            Console.WriteLine("Enter your text: ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'A' || str[i] == 'а' || str[i] == 'А')
                {
                    count++;
                }
            }

            Console.WriteLine($"The number of a or A is: {count}");
        }
    }
}
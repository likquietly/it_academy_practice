using System;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
                if (DateTime.Now.Hour > 8 & DateTime.Now.Hour < 12)
                {
                    Console.WriteLine("Good morning, guys");
                }
                else if (DateTime.Now.Hour > 11 & DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("Good day, guys");
                }
                else if (DateTime.Now.Hour > 14 & DateTime.Now.Hour < 23)
                {
                    Console.WriteLine("Good evening, guys");
                }
                else
                {

                }
            }
        }
    }
}

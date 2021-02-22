using System;

namespace Lecture._7.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] userArr = new object[3];
            int numm = 13;
            string str = "Hello";
            char chr = 'A';

            userArr[0] = numm;
            userArr[1] = chr;
            userArr[2] = str;

            foreach (var item in userArr)
            {
                Console.WriteLine(item);
            }

            userArr[0] = userArr[0] + 10;
            userArr[3] += ",guys";

            foreach (var item in userArr)
            {
                Console.WriteLine(item);
            }
        }
    }
    }

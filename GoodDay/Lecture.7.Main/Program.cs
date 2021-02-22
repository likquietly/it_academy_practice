using System;

namespace Lecture._7.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            ZeroArr();
            UsArray();
            MaxValArr();
            BoxUnBox();

        }

        public static void ZeroArr()
        {
            int[] nullArr = new int[0];
        }
       
        public static void UsArray()
        {
            object[] userArr = new object[3];
            int numm = 13;
            string str = "Hello";
            char chr = 'A';

            userArr[0] = numm;
            userArr[1] = chr;
            userArr[2] = str;

            foreach (object item in userArr)
            {
                Console.WriteLine(item);
            }

            userArr[0] = (int)userArr[0] + 10;
            userArr[2] = (string)userArr[2] + " ,guys";

            foreach (object item in userArr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static void MaxValArr()
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

        public static void BoxUnBox()
        {
            //boxing for short
            short shr = 7;
            object obj = shr;

            Console.WriteLine($"{shr.GetType()} {obj.GetType()}");

            //unboxing
            sbyte sbt = 100;
            object obj1 = sbt;
            sbyte unboxSbt = (sbyte)obj1;

            Console.WriteLine($"{sbt.GetType()} {obj1.GetType()} {unboxSbt.GetType()}");
        }
    }
}

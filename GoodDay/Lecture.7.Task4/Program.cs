using System;

namespace Lecture._7.Task4
{
    class Program
    {
        static void Main(string[] args)
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
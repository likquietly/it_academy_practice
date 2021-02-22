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

            //unboxing
            sbyte sbt = 100;
            object obj1 = sbt;
            sbyte unboxSbt = (sbyte)obj1;
        }
    }
}
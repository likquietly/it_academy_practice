using System;

namespace Lecture._7.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing for short
            short shr = 777;
            object obj = shr;

            //unboxing
            object obj2 = 123;
            sbyte sbt = (sbyte)obj2;

            
        }
    }
}

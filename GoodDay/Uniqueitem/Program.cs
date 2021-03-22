using System;

namespace Uniqueitem
{
    class Program
    {
        static void Main(string[] args)
        {
            Uniqueitem item1 = new();
            Console.WriteLine(Uniqueitem.id);  //1

            Uniqueitem item2 = new();
            Console.WriteLine(Uniqueitem.id);  //2

            Uniqueitem item3 = new(1000);
            Console.WriteLine(Uniqueitem.id);  //1001

            Uniqueitem item4 = new();
            Console.WriteLine(Uniqueitem.id);  //1002

            Uniqueitem.id = 2000;
            Uniqueitem item5 = new();
            Console.WriteLine(Uniqueitem.id);  //2001
        }
    }
}
using System;

namespace Uniqueitem
{
    class Program
    {
        static void Main(string[] args)
        {
            Uniqueitem item1 = new(1000);
            Console.WriteLine(Uniqueitem.id);

            Uniqueitem item2 = new();
            Console.WriteLine(Uniqueitem.id);

            Uniqueitem item3 = new();
            Console.WriteLine(Uniqueitem.id);
        }
    }
}

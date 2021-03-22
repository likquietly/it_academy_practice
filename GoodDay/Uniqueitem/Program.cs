using System;

namespace Uniqueitem
{
    class Program
    {
        static void Main(string[] args)
        {
            Uniqueitem item1 = new();
            Console.WriteLine("new id" + " " + Uniqueitem.Id.ToString());  //1

            Uniqueitem item2 = new();
            Console.WriteLine("new id" + " " + Uniqueitem.Id.ToString());  //2

            Uniqueitem item3 = new(1000);
            Console.WriteLine("new id" + " " + Uniqueitem.Id.ToString());  //1001

            Uniqueitem item4 = new();
            Console.WriteLine("new id" + " " + Uniqueitem.Id.ToString());  //1002

            Uniqueitem item5 = new();
            Console.WriteLine("new id" + " " + Uniqueitem.Id.ToString());  //1003

            Console.Write("Enter the id: ");
            int id;
            while(!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Enter correct number!");
            }

            Uniqueitem item6 = new(id);
            Console.WriteLine("new id" + " " + Uniqueitem.Id.ToString());
        }
    }
}
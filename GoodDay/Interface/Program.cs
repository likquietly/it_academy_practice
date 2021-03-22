using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new(10);
            Circle circle2 = new(15);
            Square square = new(14.0);
            Triangle triangle = new(5, 8);
            Triangle triangle2 = new(6, 9);

            List<Object> listObj = new List<Object>();
            listObj.Add(circle);
            listObj.Add(circle2);
            listObj.Add(square);
            listObj.Add(triangle);
            listObj.Add(triangle2);

            foreach (var item in listObj)
            {
                Type type = item.GetType();
                if (type == typeof(Circle))
                {
                    Circle tmp = (Circle)item;
                    double areaTemp = tmp.Area();
                    Console.WriteLine($"CLR Type is {tmp} Area is {areaTemp}");
                }

                if (type == typeof(Square))
                {
                    Square tmp = (Square)item;
                    double areaTemp = tmp.Area();
                    Console.WriteLine($"CLR Type is {tmp} Area is {areaTemp}");
                }

                if (type == typeof(Triangle))
                {
                    Triangle tmp = (Triangle)item;
                    double areaTemp = tmp.Area();
                    Console.WriteLine($"CLR Type is {tmp} Area is {areaTemp}");
                }
            }
        }
    }
}
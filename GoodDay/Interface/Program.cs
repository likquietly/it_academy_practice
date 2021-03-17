using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new(10);
            double circleArea = circle.Area();

            Circle circle2 = new(15);
            double circle2Area = circle2.Area();

            Square square = new(14.0);
            double squareArea = square.Area();

            Triangle triangle = new(5, 8);
            double triangleArea = triangle.Area();

            Triangle triangle2 = new(6, 9);
            double triangle2Area = triangle2.Area();


            List<Object> listObj = new List<Object>();
            listObj.Add(circle);
            listObj.Add(circle2);
            listObj.Add(square);
            listObj.Add(triangle);
            listObj.Add(triangle2);

            foreach (var item in listObj)
            {
                Console.WriteLine($"CLR Type is {item.GetType}");
            }
        }
    }
}
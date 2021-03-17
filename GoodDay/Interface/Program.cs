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

            object[] mass = new object[5];
            mass[0] = circle;
            mass[1] = circle2;
            mass[2] = square;
            mass[3] = triangle;
            mass[4] = triangle2;

            foreach (var item in mass)
            {
                Console.WriteLine(Convert.ToDouble(item.Area));
            }
        }
    }
}
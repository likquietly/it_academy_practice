using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new(10);
            circle.Area();

            Circle circle2 = new(15);
            circle2.Area();

            Square square = new(14.0);
            square.Area();

            Triangle triangle = new(5, 8);
            triangle.Area();

            Triangle triangle2 = new(6, 9);
            triangle2.Area();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Triangle : Figure
    {
        public double Side { get; set; }
        public double Height { get; set; }

        public Triangle(double side, double height)
        {
            Side = side;
            Height = height;
        }

        public override double Area()
        {
            return 1 / 2 * Side * Height;
        }
    }
}

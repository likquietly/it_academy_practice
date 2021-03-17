using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Circle : Figure
    {
        public double Radius { get; set; }
        public double MyArea { get; set; }


        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return MyArea = Math.PI * Radius;
        }
    }
}

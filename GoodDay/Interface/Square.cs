using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Square : Figure
    {
        public double Side { get; set; }
        public double MyArea { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return MyArea = Side * Side;
        }
    }
}

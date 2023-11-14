using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    class Rectangle : Shape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }

        public Rectangle(Location c,double side1,double side2):base(c)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return 2*(side1 + side2);
        }


        public override string ToString()
        {
            return $"Location: {c} , Area: {Area()}, Perimeter: {Perimeter()}";
        }
    }
}

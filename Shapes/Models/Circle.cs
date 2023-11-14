using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    class Circle:Shape
    {
        public double radius { get; set; }
        public Circle(Location c, double radius):base(c)
        {
            this.radius = radius;
        }

        public override double Area()
        {
           return Math.PI*Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
            return Math.PI*radius*2;
        }

        public override string ToString()
        {
            return $"Location: {c} , Area: {Area()}, Perimeter: {Perimeter()}";
        }
    }
}

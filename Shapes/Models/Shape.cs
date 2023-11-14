using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    abstract class Shape
    {
        public Location c { get; set; }

        public Shape(Location c)
        {
            this.c = c;
        }

        public abstract double Area();

        public abstract double Perimeter();

        public abstract new string ToString();
    }
}

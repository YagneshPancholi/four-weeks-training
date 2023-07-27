using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Circle
    {
        // Implement the Circle class here
        public double radius = 0.0;
        public Circle(double radius) 
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public double GetCircumference() 
        {
            return 2 * 3.14 * radius; 
        }
    }
}

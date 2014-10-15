using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    class Rectangle : Shape
    {
        public double Area
        {
            get
            {
                return (Length * Width);
            }            
        }

        public double Perimeter
        {
            get 
            {
                return ((2 * Length) + (2 * Width));
            }
        }

        public Rectangle(double length, double width)
            :base(length, width)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    public abstract class Shape
    {

        private double _length;
        private double _width;

        public abstract double Area
        { get { return (_length* _width); } }

        public double Length
        { get; set; }

        public abstract double Perimeter
        { get; }

        public double Width
        { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    enum ShapeType
    {
        Ellipse,
        Rectangle
    }

    public abstract class Shape
    {
        // De två privata fälten representerande längd respektive bredd. 
        private double _length;
        private double _width;

        // Publik abstrakt egenskap av typen double som representerar en figurs area. 
        public abstract double Area
        { get; }

        // Publik egenskap av typen double som kapslar in fältet _length.
        public double Length
        {
            get { return _length; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Längden kan inte vara mindre än noll!");
                }
                _length = value;
            } 
        }

        // Publik abstrakt egenskap som representerar en figurs omkrets. 
        public abstract double Perimeter
        { get; }

        // Publik egenskap som av typen double som kaplsar in fältet _width.
        public double Width
        {
            get { return _width; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bredden kan inte vara mindre än noll!");
                }
                _width = value;
            }
        }

        // Kontruktorn som ansvarar för att fälten via egenskaperna tilldelas de värden skonstruktorns parametrar har.
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Publik metod som överskuggar metoden ToSTring() i basklassen Object.
        public override string ToString()
        {
            return String.Format("Längd  : \t{0}\nBredd  : \t{1}\nOmkrets: \t{2}\nArea   : \t{3}", Length, Width, Perimeter, Area);
        }
    }
}

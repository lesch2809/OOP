using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rect
{
    public class Rechteck
    {
        public double height;
        public double lenght;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Lentgh
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public double GetArea(double height, double length)
        {
            return height * length;
        }
    }
}

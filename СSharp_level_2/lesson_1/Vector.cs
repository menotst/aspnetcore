using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Vector
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Vector()
        {
            X = Y = 0;
        }
        public Vector(double x,double y)
        {
            X = x;
            Y = y;
        }

    }
}

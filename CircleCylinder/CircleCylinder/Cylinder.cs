using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleCylinder
{
    class Cylinder : Circle
    {
        double H;
        double S;
        public Cylinder(double q, double e)
            : base(e)
        {
            H = q;
            S = e;
        }
        public double V()
        {
            return S * H;
        }
    }
}

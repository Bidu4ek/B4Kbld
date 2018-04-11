using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CircleCylinder
{
    class Circle
    {
        protected double R;
        public Circle(double e)
        {
            R = e;
        }
        public virtual double S()       //вычисление площади окружности
        {

            return R * R * Math.PI;

        }
        public double L()               //вычисление длины окружности
        {
            return R * (2 * Math.PI);
        }
    }
}


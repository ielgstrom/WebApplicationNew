using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationNew.Clases
{
    class Circulo : Forma2D
    {
        double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override double getArea()
        {
            return Math.Pow(radio, 2) * Math.PI;
        }
        public override double getPerimeter()
        {
            return Math.PI * 2 * radio;
        }
    }
}
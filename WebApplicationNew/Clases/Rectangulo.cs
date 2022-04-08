using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationNew.Clases
{
    class Rectangulo : Poligono
    {
        double lado1;
        double lado2;
        public Rectangulo(double lado1, double lado2) : base(4)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;

        }
        public override double getArea()
        {
            return lado1 * lado2;
        }

        public override double getPerimeter()
        {
            return 2 * (lado1 + lado2);
        }
    }
}
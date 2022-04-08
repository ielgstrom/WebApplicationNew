using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationNew.Clases
{
    abstract class Poligono : Forma2D
    {
        int numlados;
        public Poligono(int numlados)
        {
            this.numlados = numlados;
        }
        public abstract override double getArea();
        public abstract override double getPerimeter();

    }
}
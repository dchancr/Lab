﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    class Paralelogramo
    {
        double LadoA;
        double Area;
        double Perimetro;
        double Altura;

        public void setLadoA(double medida)
        {
            LadoA = medida;
        }
        public void setArea(double medida)
        {
            Area = medida;
        }
        public void setPerimetro(double medida)
        {
            Perimetro = medida;
        }
        public void setAltura(double medida)
        {
            Altura = medida;
        }
        public double getLadoA()
        {
            return LadoA;
        }
        public double getArea()
        {
            return Area;
        }
        public double getPerimetro()
        {
            return Perimetro;
        }
        public double getAltura()
        {
            return Altura;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
   public class Rombo
    {
        double Lado;
        double Area;
        double Perimetro;
        double Diagonal;
        double DiagonalM;

        public void setLado(double medida)
        {
            Lado = medida;
        }
        public void setArea(double medida)
        {
            Area = medida;
        }
        public void setPerimetro(double medida)
        {
            Perimetro = medida;
        }
        public void setDiagonal(double medida)
        {
            Diagonal = medida;
        }
        public void setDiagonalM(double medida)
        {
            DiagonalM = medida;
        }
        public double getLado()
        {
            return Lado;
        }
        public double getArea()
        {
            return Area;
        }
        public double getPerimetro()
        {
            return Perimetro;
        }
        public double getDiagonal()
        {
            return Diagonal;
        }
        public double getDiagonalM()
        {
            return DiagonalM;
        }
    }
}

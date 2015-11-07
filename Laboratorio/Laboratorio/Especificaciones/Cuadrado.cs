using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
   public class Cuadrado
    {
        double Lado;
        double Area;
        double Perimetro;
        double NumeroLados;

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
        public void setNumeroLados(double medida)
        {
            NumeroLados = medida;
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
        public double getNumeroLados()
        {
            return NumeroLados;
        }
    }
}

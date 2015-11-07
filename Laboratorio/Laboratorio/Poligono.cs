using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    class Poligono
    {
        double Lado;
        double NumeroLado;
        double Area;
        double Perimetro;
        double Altura;
        double Angulo;
        double Apotema;


        public void setLadoA(double medida)
        {
            Lado = medida;
        }
        public void setNumeroLados(double medida)
        {
            NumeroLado = medida;
        }
        public void setArea(double medida)
        {
            Area = medida;
        }
        public void setAngulo(double medida)
        {
            Angulo = medida;
        }
        public void setApotema(double medida)
        {
            Apotema = medida;
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
            return Lado;
        }
        public double getNumeroLado()
        {
            return NumeroLado;
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
        public double getApotema()
        {
            return Apotema;
        }
        public double getAngulo()
        {
            return Angulo;
        }
    }
}

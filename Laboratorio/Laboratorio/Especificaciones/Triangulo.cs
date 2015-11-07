using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class Triangulo
    {
        double LadoA;
        double LadoB;
        double LadoC;
        double Area;
        double Perimetro;
        double Altura;
        public void setLados(double A, double B, double C)
        {
            setLadoA(A);
            setLadoB(B);
            setLadoC(C);

        }
        public void setLadoA(double medida) {
            LadoA = medida;
        }
        public void setLadoB(double medida)
        {
            LadoB = medida;
        }
        public void setLadoC(double medida)
        {
            LadoC = medida;
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
        public double getLadoB()
        {
            return LadoB;
        }
        public double getLadoc()
        {
            return LadoC;
        }
        public double getArea()
        {
            return Area;
        }
        public double getPerimetro()
        {
            return Perimetro;
        }
        public double getAltura(double medida)
        {
            return Altura;
        }
    }
}

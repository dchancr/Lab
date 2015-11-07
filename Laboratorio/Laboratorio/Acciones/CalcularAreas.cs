using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Acciones
{
    public class CalcularAreas
    {
        public void CalcularAreasTriagulos(Triangulo triangulo)
        {
            if (triangulo.getPerimetro() == 0)
            {
                CalcularPerimetros Perimetro = new CalcularPerimetros();
                Perimetro.CalcularPerimetroTriagulos(triangulo);
                double semi = (triangulo.getPerimetro() / 2);
                triangulo.setArea(Math.Sqrt(semi * (semi - triangulo.getLadoA()) * (semi - triangulo.getLadoB()) * (semi - triangulo.getLadoc())));
            }
            else
            {
                double semi = (triangulo.getPerimetro() / 2);
                triangulo.setArea(Math.Sqrt(semi * (semi - triangulo.getLadoA()) * (semi - triangulo.getLadoB()) * (semi - triangulo.getLadoc())));
            }
        }
        public void CalcularAreasCuadrado(Cuadrado cuadrado)
        {
            cuadrado.setArea(cuadrado.getLado() * cuadrado.getLado());
        }
        public void CalcularAreasParalelogramo(Paralelogramo paralelogramo)
        {
            paralelogramo.setArea(paralelogramo.getLado() * paralelogramo.getAltura());
        }
        public void CalcularAreasRombo(Rombo rombo)
        {
            rombo.setArea(rombo.getDiagonalM() * rombo.getDiagonal());
        }
        public void CalcularAreasRectangulo(Rectangulo rectangulo)
        {
            rectangulo.setArea(rectangulo.getLadoA() * rectangulo.getLadoB());
        }
        public void CalcularAreasRomboide(Romboide romboide)
        {
            if (romboide.getLadoB() > romboide.getLadoA())
            {
                romboide.setArea(romboide.getAltura() * romboide.getLadoB());
            }
            else {
                romboide.setArea(romboide.getAltura() * romboide.getLadoA());
            }
        }
        public void CalcularAreasTrapecio(Trapecio trapecio)
        {
            trapecio.setArea(trapecio.getAltura() * ((trapecio.getLadoB()+ trapecio.getLadoA())/2));
        }
        public void CalcularAreasPoligono(Poligono poligono)
        {
            poligono.setArea((poligono.getNumeroLado()* poligono.getLadoA()* poligono.getApotema())/2);
        }

    }
}

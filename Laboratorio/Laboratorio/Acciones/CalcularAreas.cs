using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Acciones
{
    public class CalcularAreas
    {
        public void CalcularAreasTriagulos(Triangulo triangulo) {
            if (triangulo.getPerimetro() == 0)
            {
                CalcularPerimetros Perimetro = new CalcularPerimetros();
                Perimetro.CalcularPerimetroTriagulos(triangulo);
                double semi=(triangulo.getPerimetro()/2);
                triangulo.setArea(Math.Sqrt(semi*(semi - triangulo.getLadoA()) * (semi - triangulo.getLadoB()) * (semi - triangulo.getLadoc())));
            }
            else {
                double semi = (triangulo.getPerimetro() / 2);
                triangulo.setArea(Math.Sqrt(semi * (semi - triangulo.getLadoA()) * (semi - triangulo.getLadoB()) * (semi - triangulo.getLadoc())));
            }

        }
    }
}

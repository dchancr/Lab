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

            }
            else {

            }
        }
        public
    }
}

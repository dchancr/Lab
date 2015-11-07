using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Acciones
{
    public class CalcularPerimetros
    {
        public void CalcularPerimetroTriagulos(Triangulo triangulo)
        {
            triangulo.setPerimetro(triangulo.getLadoA() + triangulo.getLadoB() + triangulo.getLadoc());
        }
    }
}

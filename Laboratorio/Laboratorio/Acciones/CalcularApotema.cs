using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Acciones
{
   public class CalcularApotema
    {
        public void CalcularApotemaPoligono(Poligono poligono) {
            poligono.setAngulo(360 / poligono.getNumeroLado());
            poligono.setApotema(poligono.getLadoA()/ (2 * Math.Tan(poligono.getAngulo() / 2)));
        }
    }
}

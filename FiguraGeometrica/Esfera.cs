using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Esfera:Figura
    {
        public Esfera(float radio)
        {
            Lado1 = radio;
        }

        public override float area()
        {
            return 4 * 3.1416F * Lado1 * Lado1;
        }

        public override float perimetro()
        {
            throw new NotImplementedException();
        }

        public override float volumen()
        {
            return (4 * (3.1416F * (Lado1 * Lado1 * Lado1)))/3;
        }
    }
}

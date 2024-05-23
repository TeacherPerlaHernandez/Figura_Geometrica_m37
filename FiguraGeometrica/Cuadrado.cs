using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Cuadrado:Figura //CLASE HIJA DE FIGURA
    {
        //usamos el constructor de la clase padre
        public Cuadrado(float lado)
        { //radio se va a leer de la caja de texto con
            //usando el boton guardar
            Lado1 = lado;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area()
        {
            return Lado1 * Lado1;
        }

        public override float perimetro()
        {
            return Lado1 + Lado1 + Lado1 + Lado1;
        }

        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}

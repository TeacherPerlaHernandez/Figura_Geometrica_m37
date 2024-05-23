using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Circulo:Figura //esta es una clase hija de figura
    {
        //usamos el constructor de la clase padre
        public Circulo(float radio)
        { //radio se va a leer de la caja de texto con
            //usando el boton guardar
            Lado1 = radio;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area()
        {
            return 3.1416F * Lado1 * Lado1;
            //AGREGAMOS F AL FINAL DE UN NUMERO CUANDO
            //ES UNA CONSTANTE NO DEFINIDA EN UNA VARIABLE
            //PREVIAMENTE, ASI EL PROGRAMA SABE QUE ES UN #
        }

        public override float perimetro()
        {
            return 3.1416F * 2 * Lado1;
        }

        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}

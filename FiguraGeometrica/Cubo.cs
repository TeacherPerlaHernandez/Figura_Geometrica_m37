using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Cubo:Figura
    {
        //usamos el constructor de la clase padre
        public Cubo(float arista)
        { //radio se va a leer de la caja de texto con
            //usando el boton guardar
            Lado1 = arista;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area()
        {
            return 6*(Lado1 * Lado1);
            
        }

        public override float perimetro()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }

        public override float volumen()
        {
            return Lado1 * Lado1 * Lado1;  
        }
    }
}

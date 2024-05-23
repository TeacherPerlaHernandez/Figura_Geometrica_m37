using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    abstract class Figura //clase padre
    {
        /*clase que permite el ingreso
         * de un lado, para poder crear una
         * nueva figura geometrica
         * recuerda que una figura para
         * existir requiere minimo un lado
         esta clase es un molde*/

        /*declaramos las variables que
         * se va a pasar a las clases hijas
         * nos serviran para guardar en caja
         * de memoria el valor del primer lado
         */

        //la variable sera privada
        private float lado1; //permite decimales

        //creamos atributos o propiedades
        //definimos el constructor
        public float Lado1
        {
            /* METODO O MODIFICADOR 
             * PARA PONER EL
             * VALOR (#) EN LA CAJA DE 
             * MEMEMORIA*/
            set //poner valor
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado1 = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    lado1 = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return lado1; //regresa o cacha el valor de la variable lado1
            }
        }
        //defino métodos, funciones, operaciones de la clase padre que tambien van a tener los hijos
        //metodos de tipo publico para que todos los usen
        //metodos abstractos van vacios ya que cada hijo definira sus operaciones
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();
    }
}

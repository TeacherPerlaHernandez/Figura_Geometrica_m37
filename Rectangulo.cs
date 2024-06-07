using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Rectangulo:Figura //CLASE HIJA DE FIGURA
    {
        //esta clase requiere dos lados para funcionar
        //creamos el lado2
        private float lado2;
        //crear un constructor para regtangulo
        public float Lado2
        {
            set
            { 
                //pregunta si el lado <0
                if (value< 0)
                {
                    lado2 = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    lado2 = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return lado2; //regresa o cacha el valor de la variable lado1
            }
        }

        //usamos el constructor de la clase padre
        public Rectangulo(float lado1, float lado2)
        { //radio se va a leer de la caja de texto con
            //usando el boton guardar
            this.Lado1 = lado1; //hace que unicamente el valor la cantidad del lado sea disponible
            //para la clase rectangulo, cuando no se use rectangulo la variable sera =0
            this.Lado2 = lado2;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area()
        {
            return Lado1 * Lado2;       
        }

        public override float perimetro()
        {
            return (2 * Lado1) + (2 * Lado2);
        }

        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}

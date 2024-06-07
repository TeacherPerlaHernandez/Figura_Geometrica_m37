using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Triangulo : Figura
    {
        //esta clase requiere dos lados para funcionar
        //base que ser+a el lado que traemos de la clase padre figura
        //y la altura que la vamoa a crear acontinuación
        private float altura;
        //crear un constructor para regtangulo
        public float Altura
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    altura = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    altura = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return altura; //regresa o cacha el valor de la variable lado1
            }
        }

        //usamos el constructor de la clase padre
        public Triangulo(float lado1, float altura)
        { //radio se va a leer de la caja de texto con
            //usando el boton guardar
            this.Lado1 = lado1; //hace que unicamente el valor la cantidad del lado sea disponible
            //para la clase rectangulo, cuando no se use rectangulo la variable sera =0
            this.Altura = altura;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area()
        {
            //     base * altura 
            return (Lado1 * Altura)/2;
        }

        public override float perimetro()
        {
            //caso triangulo con 3 lados iguales
            return 3*Lado1;
        }

        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}

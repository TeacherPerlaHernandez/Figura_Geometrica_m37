using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Prisma:Figura
    {
        private float lado2;
        private float lado3;
        //crear un constructor para los nuevos lados
        public float Lado2 //area de una cara
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
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

        public float Lado3 //area total
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado3 = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    lado3 = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return lado3; //regresa o cacha el valor de la variable lado1
            }
        }

        public Prisma(float lado1, float lado2, float lado3)
        {
           this.Lado1 = lado1;
           this.Lado2 = lado2;
           this.Lado3 = lado3;
        }

        public override float area()
        {
            return (2 * Lado1 * Lado2) + (2 * Lado1 * Lado3) + (2 * Lado2 * Lado3);
        }

        public override float perimetro()
        {
            return (4 * Lado1) + (4 * Lado2) + (4 * Lado3);
        }

        public override float volumen()
        {
            return Lado1 * Lado2 * Lado3;
        }
    }
}

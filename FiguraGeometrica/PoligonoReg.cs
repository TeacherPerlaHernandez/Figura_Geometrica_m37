using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class PoligonoReg:Figura 
    { 
    //declar dos valores float para guardar numero de lados
        //y el apotema privados para usarse solo en esta clase
        private float apo, n;

        public float Apo //validar apotema existente o real
        {
            set
            {
                //pregunta si el apotema (es el # del centro del poligono) <0
                if (value <= 0)
                {
                    apo = 0; //manda el valor a 0
                } //NO EXISTEN apotemas NEGATIVOS
                else
                {
                    apo = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return apo; //regresa o cacha el valor de la variable lado1
            }
        }

        public float N //validar el numero de lados >5
        {
            set
            {
                //pregunta si el # de lados (n) >5 
                if (value < 5)
                {
                    n = 5; //manda el valor a 0
                } //NO EXISTEN apotemas NEGATIVOS
                else
                {
                    n = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return n; //regresa o cacha el valor de la variable lado1
            }
        }

        //usamos el constructor de la clase poligono regular
        public PoligonoReg(float lado,float apo, float n)
        { //radio se va a leer de la caja de texto con
            //usando el boton guardar
            Lado1 = lado;
            Apo = apo;
            N = n;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public float area(float peri) //medoto sobrecargado que recibe el perimetro y lo utiliza
        {
            return (peri * apo) / 2;
        }

        public override float perimetro() //metodo con variable de paso que guardar el perimetro
        {
            float peri;
            peri = n * Lado1;
            return peri;
        }

        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }

        public override float area()//calculo de area clase papa
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}

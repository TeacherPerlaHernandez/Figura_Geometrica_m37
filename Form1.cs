using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//BIBLIOTECA QUE PERMITE USAR EL BUFFER DE ESCRITURA Y LECTURA


namespace FiguraGeometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            INFORMACION.Clear();
            IMAGEN.Image = (FiguraGeometrica.Properties.Resources.fig_portada);
            DATOS.Clear();
            CUADRADO.Checked = false;
            TRIANGULO.Checked = false;
            RECTANGULO.Checked = false;
            ESFERA.Checked = false;
            CIRCULO.Checked = false;
            CUBO.Checked = false;
            PRISMA.Checked = false;
            POLIIRREC.Checked = false;
            POLIREG.Checked = false;
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DUBUJAR_Click(object sender, EventArgs e)
        {
           
            if (CUADRADO.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.fig_portada);
            }
            else if (TRIANGULO.Checked)
            {
               IMAGEN.Image = (FiguraGeometrica.Properties.Resources.triangulo);
            }
            else if (RECTANGULO.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.rectangulo);
            }
            else if (POLIREG.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.pentagono);
            }
            else if (POLIIRREC.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.rombo);
            }
            else if (CIRCULO.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.circulo);
            }
            else if (CUBO.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.cubo);
            }
            else if (PRISMA.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.prisma);
            }
            else if (ESFERA.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.esfera);
            }
        }

        private void INFO_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Cuadrado, " + "\n"+
                    "Sus datos son:" + "\n"+
                    "Longitud del lado: "
                    + DATOS.Text;
            }
            else if (TRIANGULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Triangulo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (RECTANGULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Rectangulo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (POLIREG.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Poligono Regular, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (POLIIRREC.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Poligono Irregular, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (CIRCULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Círculo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (CUBO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Cubo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (PRISMA.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Prisma, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (ESFERA.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Esfera, " +
                    "Sus datos son:"
                    + DATOS.Text;
            } 
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DATOS GUARDOS" + DATOS.Text, "Datos de alumno",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EXPORT_Click(object sender, EventArgs e)
        {
            try //EXCEPCIÓN
            {
                string fileName =
                    @"D:\Ejercicios POO\Figura_Geometrica_m37-main\Figura_Geometrica_m37-main\FiguraGeometrica\datos_export\datos.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //  writer.WriteLine("Este es un dato nuevo desde guardar");
                writer.WriteLine("Datos: " + INFORMACION.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar Datos en el Archivo", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CALC_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (TRIANGULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (RECTANGULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                      + "\n";
            }
            else if (POLIREG.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (POLIIRREC.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (CIRCULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (CUBO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                   + "\n";
            }
            else if (PRISMA.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                  + "\n";
            }
            else if (ESFERA.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                   + "\n";
            }
        }
    }
    
}

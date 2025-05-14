using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_Generacion_de_figuras_Grupo3
{
    public partial class GeneracionFiguras : Form
    {
        public GeneracionFiguras()
        {
            InitializeComponent();
        }

        private void GeneracionFiguras_Load(object sender, EventArgs e)
        {

        }

        // FUNCIONES PARA DIBUJAR Y GENERAR CÓDIGO
        // Dibuja una figura 8x8 en pantalla a partir de una matriz de cadenas binarias
        private void DibujarFiguraDesdeCadena(string[] matriz)
        {   // Obtiene el objeto Graphics del formulario para dibujar
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black); // Limpia el área de dibujo con fondo negro
            Brush brush = Brushes.Red; // Define el color del "pixel" (puedes cambiarlo)

            int tam = 30; // Tamaño de cada celda en la cuadrícula
                        
            for (int y = 0; y < 8; y++)  // Recorre las 8 filas (Y)
            {
                for (int x = 0; x < 8; x++) // Recorre las 8 columnas (X)
                {
                    // Si en la posición hay un '1', se dibuja un cuadrado
                    if (matriz[y][x] == '1')

                    {  // Dibuja un pequeño rectángulo (un "LED encendido")
                        g.FillRectangle(brush, x * tam, y * tam + 100, tam - 2, tam - 2);
                    }
                }
            }
        }
        // Convierte la figura en una cadena de código para usar en Arduino
        private string GenerarCodigoArduino(string[] matriz)
        {
            List<string> lineas = new List<string>();
            // Recorre cada fila y le agrega la letra 'B' para indicar binario en Arduino
            foreach (var fila in matriz)  
            {
                lineas.Add("B" + fila);
            }
            // Une todas las líneas en un arreglo de tipo byte que Arduino puede interpretar
            return "byte figura[] = {\r\n  " + string.Join(",\r\n  ", lineas) + "\r\n};";
        }

        // // Evento del botón que genera la figura
        private void btnCrearCorazon_Click(object sender, EventArgs e)
        {
            string[] corazon = new string[]
            {
                "01100110",
                "11111111",
                "11111111",
                "11111111",
                "01111110",
                "00111100",
                "00011000",
                "00000000"
            };

            DibujarFiguraDesdeCadena(corazon); // Dibuja la figura en el formulario

            string codigo = GenerarCodigoArduino(corazon);// Genera y muestra el código Arduino equivalente
            MessageBox.Show(codigo, "Código para Arduino");
        }
        // Evento del botón que genera la figura
        private void btnCrearTriangulo_Click(object sender, EventArgs e)
        {
            string[] triangulo = new string[]

            {  "00011000",
               "00111100",
               "01111110",
               "11111111",
               "00011000",
               "00011000",
               "00011000",
               "00000000"
            };
            DibujarFiguraDesdeCadena(triangulo);  // Dibuja la figura en el formulario
            string codigo = GenerarCodigoArduino(triangulo); // Genera y muestra el código Arduino equivalente
            MessageBox.Show(codigo, "codigo para arduino");


        }
        // Evento del botón que genera la figura
        private void btnCrearCuadrado_Click(object sender, EventArgs e)
        {
            string[] cuadrado = new string[]
            {
               "11111111",
               "10000001",
               "10000001",
               "10000001",
               "10000001",
               "10000001",
               "11111111",
               "00000000"
             };
            DibujarFiguraDesdeCadena(cuadrado);  // Dibuja la figura en el formulario
            string codigo = GenerarCodigoArduino(cuadrado); // Genera y muestra el código Arduino equivalente
            MessageBox.Show(codigo, "codigo para arduino");
        }
        // Evento del botón que genera la figura
        private void btnCrearGato_Click(object sender, EventArgs e)
        {
            string[] creargato = new string[]
            {

             "10000001",
             "01000010",
             "10100101",
             "10000001",
             "11111111",
             "10100101",
             "10011001",
             "00000000"
            };
            DibujarFiguraDesdeCadena(creargato);  // Dibuja la figura en el formulario
            string codigo = GenerarCodigoArduino(creargato); // Genera y muestra el código Arduino equivalente
            MessageBox.Show(codigo, "codigo para el arduino");

        }
        // Evento del botón que genera la figura
        private void btnCrearHi_Click(object sender, EventArgs e)
        {
            string[] crearhi = new string[]
            {

              "10000001",
              "10000001",
              "11111111",
              "00011000",
              "00011000",
              "00000000",
              "01111110",
              "00000000"
            };
            DibujarFiguraDesdeCadena(crearhi);  // Dibuja la figura en el formulario
            string codigo = GenerarCodigoArduino(crearhi); // Genera y muestra el código Arduino equivalente
            MessageBox.Show(codigo, "codigo para el arduino");
        }
        // Evento del botón que genera la figura
        private void btnCrearCruz_Click(object sender, EventArgs e)
        {
            string[] crearcruz = new string[]
            {
                 "00011000",
                 "00011000",
                 "00011000",
                 "11111111",
                 "00011000",
                 "00011000",
                 "00011000",
                 "00000000"
            };
            DibujarFiguraDesdeCadena(crearcruz);  // Dibuja la figura en el formulario
            string codigo = GenerarCodigoArduino(crearcruz); // Genera y muestra el código Arduino equivalente
            MessageBox.Show(codigo, "codigo para el arduino :)");
        }  

        /*
        
        Utilizar las cadenas que genere de 01 de generar figura 

         */
    }
}


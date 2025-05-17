using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
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
        {
            // Validar entrada
            if (matriz == null || matriz.Length != 8 || matriz.Any(fila => fila.Length != 8))
            {
                MessageBox.Show("La matriz debe ser de 8x8 caracteres (1s y 0s)", "Error");
                return;
            }

            // Crear objeto Graphics y limpiar el área
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(Color.Black);
                Brush brush = Brushes.Red;
                int tam = 30; // Tamaño de cada celda

                for (int y = 0; y < 8; y++)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        if (matriz[y][x] == '1')
                        {
                            g.FillRectangle(brush, x * tam, y * tam + 100, tam - 2, tam - 2);
                        }
                    }
                }
            } // El using asegura que 'g' se libere automáticamente
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
                "00011000"
            };

            EnviarFiguraALedMatrix(corazon , false);

        }
        // Evento del botón que genera la figura
        private void btnCrearTriangulo_Click(object sender, EventArgs e)
        {
            string[] triangulo = new string[]
            {  
               "00000000",
               "00011000",
               "00111100",
               "01111110",
               "11111111",
               "11111111",
               "00000000",
               "00000000"
            };

            EnviarFiguraALedMatrix(triangulo , false);

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
               "10000001",
               "11111111"
             };

            EnviarFiguraALedMatrix(cuadrado , false);
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

            EnviarFiguraALedMatrix(creargato, false);

        }
        // Evento del botón que genera la figura
        private void btnCrearHi_Click(object sender, EventArgs e)
        {
            string[] crearhi = new string[]
            {

              "11000011",
              "11111111",
              "11111111",
              "11000011",
              "00000000",
              "11111111",
              "00011000",
              "11111111"
            };

            EnviarFiguraALedMatrix(crearhi, false);
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
                 "11111111",
                 "00011000",
                 "00011000",
                 "00011000"
            };
            EnviarFiguraALedMatrix(crearcruz, false);
        }

        private void EnviarFiguraALedMatrix(string[] figura, bool esModoPingPong)
        {
            // Validación de la figura (8x8)
            if (figura.Length != 8 || figura.Any(fila => fila.Length != 8))
            {
                MessageBox.Show("La figura debe ser de 8x8 caracteres", "Error");
                return;
            }

            string datosParaArduino = string.Join("", figura);
            
            using (SerialPort serial = new SerialPort("COM5", 9600))
            {
                try
                {
                    serial.Open();
                    // Envía 'P' o 'F' antes de los datos
                    char comando = esModoPingPong ? 'P' : 'F';
                    serial.Write(comando.ToString());
                    serial.WriteLine(datosParaArduino);
                    MessageBox.Show("Datos enviados al Arduino!", "Éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}\nVerifica el puerto COM", "Error");
                }
            }
        }

    }
}

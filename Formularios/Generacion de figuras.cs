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
using MatrizLED;

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


        // Evento del botón que genera la figura de corzazon
        private void btnCrearCorazon_Click(object sender, EventArgs e)
        {
            //Array para guardar los valores de encendido y apagado de leds
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
        // Evento del botón que genera la figura de triangulo
        private void btnCrearTriangulo_Click(object sender, EventArgs e)
        {
            //Array para guardar los valores de encendido y apagado de leds
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
        // Evento del botón que genera la figura de cuadrado
        private void btnCrearCuadrado_Click(object sender, EventArgs e)
        {
            //Array para guardar los valores de encendido y apagado de leds
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
        // Evento del botón que genera la figura de gato
        private void btnCrearGato_Click(object sender, EventArgs e)
        {
            //Array para guardar los valores de encendido y apagado de leds
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
        // Evento del botón que genera la figura de HI
        private void btnCrearHi_Click(object sender, EventArgs e)
        {
            //Array para guardar los valores de encendido y apagado de leds
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

        // Evento del botón que genera la figura de cruz
        private void btnCrearCruz_Click(object sender, EventArgs e)
        {
            //Array para guardar los valores de encendido y apagado de leds
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

            //Concatena la figura
            string datosParaArduino = string.Join("", figura);
            
            //Se hace uso del puerto donde esta conectado el arduino para la comunicacion
            using (SerialPort serial = new SerialPort("COM5", 9600))
            {
                try
                {
                    serial.Open();
                    // Envía 'P' o 'F' antes de los datos para que se seleccione el modo del arduino
                    char comando = esModoPingPong ? 'P' : 'F';
                    //Se envia el modo
                    serial.Write(comando.ToString());
                    //Se envia la figura el arduino
                    serial.WriteLine(datosParaArduino);
                    MessageBox.Show("Datos enviados al Arduino!", "Éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}\nVerifica el puerto COM", "Error");
                }
            }
        }

        //Evento para regresar al menu
        private void brnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearNuevaFigura crear = new CrearNuevaFigura();
            crear.Show();

        }
    }
}

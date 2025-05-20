using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_Generacion_de_figuras_Grupo3.Formularios
{
    public partial class OpcionesProyecto : Form
    {
        public OpcionesProyecto()
        {
            InitializeComponent();
        }

        
        int intensidad = 0; //Declaracion de la variable de intensidad

        private void lbMatriz_Click(object sender, EventArgs e)
        {

        }

        private void tckbarBrillo_Scroll(object sender, EventArgs e)
        {
            //Asiganacion del valor de la trackbar a la variable brillo
            intensidad = tckbarBrillo.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Método para enviar el comando de intensidad al Arduino
        private void EnviarComandoIntensidad(int intensidad)
        {
            //Se usa el puerto donde esta el arduino
            using (SerialPort serial = new SerialPort("COM5", 9600))
            {
                //Se usa try para controlar errores
                try
                {
                    //Se abre la conexion
                    serial.Open();
                    //Se envia la intensidad al serial
                    serial.WriteLine($"INTENSIDAD,{intensidad}"); // Formato: "INTENSIDAD,5"
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error");
                }
            }
        }

        //Metodo para enviar el brillo al arduino con el metodo anterior
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EnviarComandoIntensidad(intensidad);
            MessageBox.Show("Configuración guardada y enviada al Arduino", "Éxito");
        }

        private void OpcionesProyecto_Load(object sender, EventArgs e)
        {

        }

        //Evento para regresar al menu
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();

        }
    }
}

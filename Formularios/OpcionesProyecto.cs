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

        // Declaracion de variables
        Color colorSeleccionado = Color.Red; // Color por defecto 
        int intensidad = 0; //Intensidad por defecto

        private void lbMatriz_Click(object sender, EventArgs e)
        {

        }

        private void tckbarBrillo_Scroll(object sender, EventArgs e)
        {
            intensidad = tckbarBrillo.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Método para enviar el comando de intensidad al Arduino
        private void EnviarComandoIntensidad(int intensidad)
        {
            using (SerialPort serial = new SerialPort("COM5", 9600))
            {
                try
                {
                    serial.Open();
                    serial.WriteLine($"INTENSIDAD,{intensidad}"); // Formato: "INTENSIDAD,5"
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EnviarComandoIntensidad(intensidad);
            MessageBox.Show("Configuración guardada y enviada al Arduino", "Éxito");
        }

        private void OpcionesProyecto_Load(object sender, EventArgs e)
        {

        }
    }
}

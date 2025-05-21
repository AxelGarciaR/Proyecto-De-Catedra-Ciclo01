using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using PingPong_Generacion_de_figuras_Grupo3;

namespace MatrizLED
{
    public partial class CrearNuevaFigura : Form
    {
        // Matriz para almacenar las referencias de los checkboxs y poder trabajar con los leds
        private CheckBox[,] ledCheckBoxes = new CheckBox[8, 8];

        private SerialPort arduinoPort;

        public CrearNuevaFigura()
        {
            InitializeComponent();
            ConfigmatrizLED();
            InitializeSerialPort();
        }

        private void ConfigmatrizLED()
        {
            // Buscamos el tablelayoutpanel
            TableLayoutPanel tlp = this.Controls.Find("TableLayoutPanel1", true)[0] as TableLayoutPanel;

            foreach (Control control in tlp.Controls)
            {
                // Verificamos si el control actual es un checkbox
                if (control is CheckBox currentCheckBox)
                {
                    string name = currentCheckBox.Name;
                    string[] parts = name.Split('_');

                    if (parts.Length == 3 && parts[0] == "check")
                    {
                        if (int.TryParse(parts[1], out int row) && int.TryParse(parts[2], out int col))
                        {
                            ledCheckBoxes[row, col] = currentCheckBox;
                            // aqui asignamos el evento "click"
                            currentCheckBox.Click += new EventHandler(LED_Click);
                        }
                    }
                }
            }
        }

        private void LED_Click(object sender, EventArgs e)
        {
            // obtiene el checkbox seleccionado con click
            CheckBox clickedCheckBox = (CheckBox)sender;

            // El estado Checked del CheckBox ya se actualiza automáticamente con el evento click.
            // Por lo tanto, solo necesitamos actualizar el color basándonos en su estado actual.

            // cambia el color de los seleccionados como indicador visual
            if (clickedCheckBox.Checked)
            {
                clickedCheckBox.BackColor = Color.Green; // si esta marcado se pone verde
            }
            else
            {
                clickedCheckBox.BackColor = Color.White; // si esta desmarcado se mantiene en blanco
            }
        }

        private void CrearNuevaFigura_Load(object sender, EventArgs e)
        {

        }

        // aqui le diremos al programa que hacer al darle al boton de crear figura y como interpretar la figura en el arduino
        private void btnCrearFigura_Click(object sender, EventArgs e) 
        {
            // verificamos si el puerto está configurado y abierto.
            if (arduinoPort != null && arduinoPort.IsOpen)
            {
                // este string es para almacenar los valores como patron de 0 y 1
                // 0 = apagado y 1 = encendido
                string patrondeLEDs = "";

                // recorre las filas y columnas de la matriz
                for (int row = 0; row < 8; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        // asegura que la pocision existe antes de leer el estado 
                        if (ledCheckBoxes[row, col] != null)
                        {
                            // aqui es donde se da el valor de 1 a los seleccionados y 0 a los que no
                            patrondeLEDs += ledCheckBoxes[row, col].Checked ? "1" : "0";
                        }
                        else
                        {
                            // si alguno no se encuentra se asume que esta apagado dandole un valor de 0
                            patrondeLEDs += "0";
                        }
                    }
                }

                try
                {
                    // aqui le mandamos el string formado al arduino

                    arduinoPort.WriteLine(patrondeLEDs);
                    MessageBox.Show($"Patrón enviado al Arduino: {patrondeLEDs}", "Tu figura ha sido creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al enviar datos al Arduino: {ex.Message}\nAsegúrate de que el Arduino esté conectado", "Hubo un error de Comunicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El puerto serial no está configurado o no está abierto.\nVerifica la conexión del Arduino y el puerto COM.", "Error de Puerto Serial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiarSeleccion_Click(object sender, EventArgs e)
        {
            // recorre todos los CheckBoxs
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (ledCheckBoxes[row, col] != null)
                    {
                        // los desmarca y regresa al color inicial
                        ledCheckBoxes[row, col].Checked = false;
                        ledCheckBoxes[row, col].BackColor = Color.White;
                    }
                }
            }
        }


        private void InitializeSerialPort()
        {
            try
            {
                // *** MUY IMPORTANTE: CAMBIA "COM3" por el puerto COM de tu Arduino ***
                // El BaudRate (9600) debe coincidir con el configurado en tu sketch de Arduino.
                arduinoPort = new SerialPort("COM5", 9600);
                arduinoPort.Open(); // Intenta abrir el puerto.
                Console.WriteLine($"Puerto serial {arduinoPort.PortName} abierto con éxito."); // Mensaje para depuración
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el puerto serial: {ex.Message}\nPor favor, verifica que el puerto COM sea correcto y que el Arduino esté conectado.", "Error Serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                arduinoPort = null; // Establece a null para indicar que no se pudo abrir el puerto.
            }
        }

        /// <summary>
        /// Asegura que el puerto serial se cierre correctamente cuando el formulario se cierre.
        /// </summary>
        private void CrearNuevaFigura_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduinoPort != null && arduinoPort.IsOpen)
            {
                arduinoPort.Close(); // Cierra el puerto serial.
                arduinoPort.Dispose(); // Libera los recursos asociados al puerto.
                Console.WriteLine("Puerto serial cerrado."); // Mensaje para depuración
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GeneracionFiguras generacion = new GeneracionFiguras();
            generacion.Show();
            this.Close();
        }
    }
}
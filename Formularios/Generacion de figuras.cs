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

        private void DibujarFiguraDesdeCadena(string[] matriz)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Brush brush = Brushes.Red; // Puedes cambiar el color

            int tam = 30;

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
        }

        private string GenerarCodigoArduino(string[] matriz)
        {
            List<string> lineas = new List<string>();

            foreach (var fila in matriz)
            {
                lineas.Add("B" + fila);
            }

            return "byte figura[] = {\r\n  " + string.Join(",\r\n  ", lineas) + "\r\n};";
        }

        // EVENTO DEL BOTÓN CORAZÓN
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

            DibujarFiguraDesdeCadena(corazon);

            string codigo = GenerarCodigoArduino(corazon);
            MessageBox.Show(codigo, "Código para Arduino");
        }

        /*
        
        Utilizar las cadenas que genere de 01 de generar figura 

         */
    }
}


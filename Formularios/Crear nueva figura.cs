using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatrizLED
{
    public partial class CrearNuevaFigura : Form
    {
        CheckBox[,] matriz;

        public CrearNuevaFigura()
        {
            InitializeComponent();
            CrearCheckBoxes();
            DibujarXD();
        }

        private void CrearCheckBoxes()
        {
            int tamaño = 30;
            matriz = new CheckBox[8, 8];

            for (int fila = 0; fila < 8; fila++)
            {
                for (int col = 0; col < 8; col++)
                {
                    CheckBox chk = new CheckBox();
                    chk.Width = chk.Height = tamaño;
                    chk.Location = new Point(20 + col * tamaño, 20 + fila * tamaño);
                    chk.Appearance = Appearance.Button;
                    chk.FlatStyle = FlatStyle.Flat;
                    this.Controls.Add(chk);
                    matriz[fila, col] = chk;
                }
            }
        }

        private void DibujarXD()
        {
            foreach (var chk in matriz) chk.Checked = false;

            matriz[1, 1].Checked = true;
            matriz[2, 2].Checked = true;
            matriz[3, 3].Checked = true;
            matriz[4, 4].Checked = true;
            matriz[5, 5].Checked = true;
            matriz[1, 5].Checked = true;
            matriz[2, 4].Checked = true;
            matriz[3, 3].Checked = true;
            matriz[4, 2].Checked = true;
            matriz[5, 1].Checked = true;

            matriz[1, 7].Checked = true;
            matriz[2, 7].Checked = true;
            matriz[3, 7].Checked = true;
            matriz[4, 7].Checked = true;
            matriz[5, 7].Checked = true;
            matriz[1, 6].Checked = true;
            matriz[5, 6].Checked = true;
            matriz[2, 5].Checked = true;
            matriz[3, 5].Checked = true;
            matriz[4, 5].Checked = true;
        }

        private void CrearNuevaFigura_Load(object sender, EventArgs e)
        {

        }

        /*
            
        Empezar a configurar este para hacer las demas figuras para agarrarlo de base para poder hacers las demas figuras

         */
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PingPong_Generacion_de_figuras_Grupo3.Formularios
{
    public partial class PingPongGame : Form
    {
        public PingPongGame()
        {
            InitializeComponent();
        }

        //Variables base
        int velocidad = 5; //Velocidad base de la pelota 
        int contador = 0; //Contador de puntos totales
        int puntaje = 0; //Contador para llevar el puntaje

        //Variables para comportamiento de pelota
        bool arriba;
        bool izquierda;

        private void PingPongGame_Load(object sender, EventArgs e)
        {

        }

        //Metodo para leer la posicion de los jugadores
        private void PosicionMovimientoJugador1Arriba() { 

            int x1 = pbxJugador1.Location.X;
            int y1 = pbxJugador1.Location.Y;
           
            int nuevaY = y1 - 50;

            if (nuevaY < 0) // 0 es la coordenada mas alta del formulario
            {
                // Si la nueva posición está fuera del límite superior,
                // establece la posición del PictureBox en el límite superior (0)
                pbxJugador1.Location = new Point(x1, 0);
            }
            else
            {
                // Si la nueva posición está dentro de los límites, mueve el PictureBox hacia arriba
                pbxJugador1.Location = new Point(x1, nuevaY);
            }

        }

        private void PosicionMovimientoJugador1Abajo()
        {

            int x1 = pbxJugador1.Location.X;
            int y1 = pbxJugador1.Location.Y;
            int alturaJugador1 = pbxJugador1.Height;
            int alturaformulario = this.ClientSize.Height;

            int nuevaY = y1 + 50;

            if (nuevaY + alturaJugador1 > alturaformulario) // 0 es la coordenada mas alta del formulario
            {
                // Si la nueva posición está fuera del límite superior,
                // establece la posición del PictureBox en el límite superior (0)
                pbxJugador1.Location = new Point(x1, alturaformulario - alturaJugador1);
            }
            else
            {
                // Si la nueva posición está dentro de los límites, mueve el PictureBox hacia arriba
                pbxJugador1.Location = new Point(x1, nuevaY);
            }

        }

        private void PosicionMovimientoJugador2Arriba()
        {
            int x2 = pbxJugador2.Location.X;
            int y2 = pbxJugador2.Location.Y;

            int nuevaY = y2 - 50;

            if (nuevaY < 0) // 0 es la coordenada mas alta del formulario
            {
                // Si la nueva posición está fuera del límite superior,
                // establece la posición del PictureBox en el límite superior (0)
                pbxJugador2.Location = new Point(x2, 0);
            }
            else
            {
                // Si la nueva posición está dentro de los límites, mueve el PictureBox hacia arriba
                pbxJugador2.Location = new Point(x2, nuevaY);
            }


        }

        private void PosicionMovimientoJugador2Abajo()
        {
            int x2 = pbxJugador2.Location.X;
            int y2 = pbxJugador2.Location.Y;
            int alturaJugador2 = pbxJugador2.Height;
            int alturaformulario = this.ClientSize.Height;

            int nuevaY = y2 + 50;

            if (nuevaY + alturaJugador2 > alturaformulario) // 0 es la coordenada mas alta del formulario
            {
                // Si la nueva posición está fuera del límite superior,
                // establece la posición del PictureBox en el límite superior (0)
                pbxJugador2.Location = new Point(x2, alturaformulario - alturaJugador2);
            }
            else
            {
                // Si la nueva posición está dentro de los límites, mueve el PictureBox hacia arriba
                pbxJugador2.Location = new Point(x2, nuevaY);
            }
        }

        //Evento para leer teclas
        private void PingPongGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {

                PingPong menu = new PingPong();
                menu.Show();
                this.Hide();

            }
            else if (e.KeyCode == Keys.W)
            {

                PosicionMovimientoJugador1Arriba();

            }
            else if (e.KeyCode == Keys.S) {

                PosicionMovimientoJugador1Abajo();

            }
            else if (e.KeyCode == Keys.Up)
            {

                PosicionMovimientoJugador2Arriba();

            }
            else if (e.KeyCode == Keys.Down)
            {

                PosicionMovimientoJugador2Abajo();

            }
        }

        private void pbxJugador2_Click(object sender, EventArgs e)
        {

        }
    }
}

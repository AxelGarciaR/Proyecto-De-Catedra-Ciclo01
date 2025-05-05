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
        int puntajeJugador1 = 0; //Contador para llevar el puntaje del jugador 1
        int puntajeJugador2 = 0; //Contador para llevar el puntaje del jugador 2

        //Variables para comportamiento de pelota
        bool arriba;
        bool izquierda;

        private void PingPongGame_Load(object sender, EventArgs e)
        {
            //Hacerlo de manera aleatoria para que al inicio la pelota se mueva a la izquierda o a la derecha
            Random valoral = new Random();
            pbxPelota.Location = new Point(300,valoral.Next(this.Height -10));
            //Poner como true arriba y abajo para comparar en las colisiones en los bordes del forumulario
            arriba = true;

            //Se ramdomiza este numero para saber si iniciara el lado izquierdo o derecho
            int randomNumber = valoral.Next(0, 2);

            if (randomNumber == 0)
            {
                izquierda = true;
            }
            else { 
                izquierda= false;
            }
            
            //Activa el timer
            timerPingPong.Enabled = true;
            puntajeJugador1 = 0;
            puntajeJugador2 = 0;
            lbPuntaje1.Text = puntajeJugador1.ToString(); 
            lbPuntaje2.Text = puntajeJugador2.ToString(); 
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

            if (nuevaY + alturaJugador1 > alturaformulario) // esta seria la forma de calcular la colision en la parte inferior
            {
                // Si la nueva posición está fuera del límite inferior,
                // establece la posición del PictureBox antes del limite 
                pbxJugador1.Location = new Point(x1, alturaformulario - alturaJugador1);
            }
            else
            {
                // Si la nueva posición está dentro de los límites, mueve el PictureBox hacia abajo
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

            if (nuevaY + alturaJugador2 > alturaformulario) // esta seria la forma de calcular la colision en la parte inferior
            {
                // Si la nueva posición está fuera del límite inferior,
                // establece la posición del PictureBox antes del limite 
                pbxJugador2.Location = new Point(x2, alturaformulario - alturaJugador2);
            }
            else
            {
                // Si la nueva posición está dentro de los límites, mueve el PictureBox hacia abajo
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

        private void timerPingPong_Tick(object sender, EventArgs e)
        {
            //Control de puntaje
            if (pbxPelota.Left > pbxJugador2.Left) {

                timerPingPong.Enabled = false;
                MessageBox.Show("Jugador 1 ha anotado " + puntajeJugador1.ToString() + " veces!");
                puntajeJugador1 = puntajeJugador1 + 1;
                velocidad = 5;
                contador = contador++;
                lbPuntaje1.Text = puntajeJugador1.ToString();
                

            }
            else if (pbxPelota.Left < pbxJugador1.Left) {

                timerPingPong.Enabled = false;
                MessageBox.Show("Jugador 2 ha anotado " + puntajeJugador2.ToString() + " veces!");
                puntajeJugador2 = puntajeJugador2 + 1;
                velocidad = 5;
                contador = contador++;
                lbPuntaje2.Text = puntajeJugador2.ToString();
            }

            //Movimiento de la pelota
            if (izquierda)
            {
                pbxPelota.Left += velocidad; //Se movera a la derecha
            }
            else {
                pbxPelota.Left -= velocidad; //Se movera a la izquierda
            }
            if (arriba)
            {
                pbxPelota.Top += velocidad; //Se movera hacia abajo
            }
            else {
                pbxPelota.Top -= velocidad; //Se movera hacia arriba
            }

            if (pbxPelota.Top >= this.Height - 50) {

                //Evita que desaparezca en la pared de abajo y se mueva hacia arriba
                arriba = false;

            }
            if (pbxPelota.Top <= 0) { 

                //Cuando pegue en la pared de arriba se regrese y se mueva hacia abajo
                arriba = true;
            }
            if (pbxPelota.Left <= 0) {

                //Cuando pegue en la pared de la izquierda se regrese y se mueva hacia la derecha
                izquierda = true;

            }
            if (pbxPelota.Left >= this.Width-10)
            {
                //Cuando pegue en la pared de la derecha se regrese y se mueva hacia la izquierda
                izquierda = false;

            }




        }
    }
}

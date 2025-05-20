using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrizLED;
using PingPong_Generacion_de_figuras_Grupo3.Formularios;

namespace PingPong_Generacion_de_figuras_Grupo3
{
    public partial class MenuPrincipal : Form
    {
        int opcionselecionada = 0;
        Label[] opcioneslabels;
        PictureBox[] opcionesIndicadores;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            opcioneslabels = new Label[]
            {
                lbGeneracion, lbJugarPingPong, lbCerrarPrograma, lbAyuda
            };

            opcionesIndicadores = new PictureBox[]
            {
                pbSelect1, pbSelect2, pbSelect3, pbSelect4
            };

            // Oculta todo menos lbStart
           
        }

        private void MenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (lblStart.Visible && e.KeyCode == Keys.Enter)
            {
                lblStart.Visible = false;

                foreach (var label in opcioneslabels) label.Visible = true;
                foreach (var pb in opcionesIndicadores) pb.Visible = false;

                opcionesIndicadores[opcionselecionada].Visible = true;
            }
            else if (!lblStart.Visible)
            {
                if (e.KeyCode == Keys.Up)
                {
                    int nueva = (opcionselecionada - 1 + opcioneslabels.Length) % opcioneslabels.Length;
                    CambiarSeleccion(nueva);
                }
                else if (e.KeyCode == Keys.Down)
                {
                    int nueva = (opcionselecionada + 1) % opcioneslabels.Length;
                    CambiarSeleccion(nueva);
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    EjecutarOpcion(opcionselecionada);
                }
            }
        }

        private void CambiarSeleccion(int nuevaSeleccion)
        {
            if (nuevaSeleccion < 0 || nuevaSeleccion >= opcioneslabels.Length)
                return;

            opcionesIndicadores[opcionselecionada].Visible = false;
            opcionselecionada = nuevaSeleccion;
            opcionesIndicadores[opcionselecionada].Visible = true;
        }

        private void EjecutarOpcion(int index)
        {
            switch (index)
            {
                case 0:
                    new CrearNuevaFigura().Show();
                    this.Hide();
                    break;
                case 1:
                    // new JuegoPingPong().Show();
                    this.Hide();
                    break;
                case 2:
                    Application.Exit();
                    break;
                case 3:
                    MessageBox.Show("Ayuda: Usa las flechas ↑ ↓ para moverte y Enter para seleccionar.", "Ayuda");
                    break;
            }
        }

        // ==== Eventos MouseHover y MouseLeave (estilo clásico) ====
        private void lbGeneracion_MouseHover(object sender, EventArgs e)
        {
            pbSelect1.Visible = true;
        }

        private void lbGeneracion_MouseLeave(object sender, EventArgs e)
        {
            pbSelect1.Visible = false;
        }

        private void lbJugarPingPong_MouseHover(object sender, EventArgs e)
        {
            pbSelect2.Visible = true;
        }

        private void lbJugarPingPong_MouseLeave(object sender, EventArgs e)
        {
            pbSelect2.Visible = false;
        }

        private void lbCerrarPrograma_MouseHover(object sender, EventArgs e)
        {
            pbSelect3.Visible = true;
        }

        private void lbCerrarPrograma_MouseLeave(object sender, EventArgs e)
        {
            pbSelect3.Visible = false;
        }

        private void lbAyuda_MouseHover(object sender, EventArgs e)
        {
            pbSelect4.Visible = true;
        }

        private void lbAyuda_MouseLeave(object sender, EventArgs e)
        {
            pbSelect4.Visible = false;
        }

        // ==== Clicks en los PictureBox ====
        private void pbSelect1_Click(object sender, EventArgs e)
        {
            EjecutarOpcion(0);
        }

        private void pbSelect2_Click(object sender, EventArgs e)
        {
            EjecutarOpcion(1);
        }

        private void pbSelect3_Click(object sender, EventArgs e)
        {
            EjecutarOpcion(2);
        }

        private void pbSelect4_Click(object sender, EventArgs e)
        {
            EjecutarOpcion(3);
        }
        private void lblStart_DoubleClick(object sender, EventArgs e)
        {
            // Aquí defines qué debe ocurrir cuando se haga doble clic
            lblStart.Visible = false;

            // Mostrar las opciones del menú
            foreach (var label in opcioneslabels) label.Visible = true;
            opcionesIndicadores[opcionselecionada].Visible = true;
        }

        private void lbAyuda_Click(object sender, EventArgs e)
        {
            OpcionesProyecto opciones = new OpcionesProyecto();
            this.Hide();
            opciones.Show();
        }

        private void lbJugarPingPong_Click(object sender, EventArgs e)
        {
            // Lógica para abrir el juego de ping pong
            var ventanaPingPong = new PingPongMenuP();
            ventanaPingPong.Show();
        }

        private void lbCerrarPrograma_Click(object sender, EventArgs e)
        {

            // Cerrar la aplicación
            Application.Exit();
        }

        private void lbGeneracion_Click(object sender, EventArgs e)
        {
            // Lógica para abrir el formulario de generación de figuras
            var ventanaFiguras = new GeneracionFiguras();
            ventanaFiguras.Show();
        }
    }

}


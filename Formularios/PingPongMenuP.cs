using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PingPong_Generacion_de_figuras_Grupo3.Formularios;

namespace PingPong_Generacion_de_figuras_Grupo3
{
    public partial class PingPongMenuP : Form
    {
        public PingPongMenuP()
        {
            InitializeComponent();
        }

        private void lbReanudar_MouseHover(object sender, EventArgs e)
        {
            PbRean.Visible = true;
        }

        private void lbReanudar_MouseLeave(object sender, EventArgs e)
        {
            PbRean.Visible = false;
        }

        private void LbReiniciar_MouseHover(object sender, EventArgs e)
        {
            PbReini.Visible = true;
        }

        private void LbReiniciar_MouseLeave(object sender, EventArgs e)
        {
            PbReini.Visible = false;
        }

        private void LbSalir_MouseHover(object sender, EventArgs e)
        {
            PbSalir.Visible = true;
        }

        private void LbSalir_MouseLeave(object sender, EventArgs e)
        {
            PbSalir.Visible = false;
        }

        private void LbSalirAlmenu_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void LbSalirAlmenu_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void lbIniciarPingPong_Click(object sender, EventArgs e)
        {
            PingPongGame juego = new PingPongGame();
            juego.Show();
            this.Hide();

        }

        private void PingPongMenuP_Load(object sender, EventArgs e)
        {

        }

        private void lbSalirAplicacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbSalirMenu_Click(object sender, EventArgs e)
        {

        }

        private void lbControles_Click(object sender, EventArgs e)
        {

        }

        private void PbMenu_Click(object sender, EventArgs e)
        {

        }

        private void PbSalir_Click(object sender, EventArgs e)
        {

        }

        private void PbReini_Click(object sender, EventArgs e)
        {

        }

        private void PbRean_Click(object sender, EventArgs e)
        {

        }
    }
}

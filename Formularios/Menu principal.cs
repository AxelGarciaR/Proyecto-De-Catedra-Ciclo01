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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

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

        private void pbSelect1_Click(object sender, EventArgs e)
        {

        }
    }
}

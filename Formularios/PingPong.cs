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
    public partial class PingPong : Form
    {
        public PingPong()
        {
            InitializeComponent();
        }

        //Mouse hover para hacer las animaciones de seleccionado
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

        private void LbSalirAlmenu_MouseHover(object sender, EventArgs e)
        {
            PbMenu.Visible = true;
        }

        private void LbSalirAlmenu_MouseLeave(object sender, EventArgs e)
        {
            PbMenu.Visible = false;
        }

        //Devuelve el resultado ok para reanudar el juego
        private void LbReanudar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //Cancela el resultado y sale al menu principal
        private void LbSalirAlmenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PingPong_Load(object sender, EventArgs e)
        {

        }

        //Devulve resultado yes para reiniciar el juego
        private void LbReiniciar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}

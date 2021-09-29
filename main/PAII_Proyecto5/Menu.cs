using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAII_Proyecto5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            PANEL_CREDITOS.Visible = false;
        }

        private void btnNuevaPartida_MouseMove(object sender, MouseEventArgs e)
        { 
            btnNuevaPartida.Image = Properties.Resources.MENU_UNDERLINEDTEXT;
        }
        private void btnNuevaPartida_MouseLeave(object sender, EventArgs e)
        {
            btnNuevaPartida.Image = null;
        }
        private void btnOpciones_MouseMove(object sender, MouseEventArgs e)
        {
            btnCreditos.Image = Properties.Resources.MENU_UNDERLINEDTEXT;
        }
        private void btnOpciones_MouseLeave(object sender, EventArgs e)
        {
            btnCreditos.Image = null;
        }
        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.Image = Properties.Resources.MENU_UNDERLINEDTEXT;
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.Image = null;
        }
        private void btnSalir_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantalla_Carga Form = new Pantalla_Carga();
            Form.Show();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            PANEL_CREDITOS.Visible = true;
        }
    }
}

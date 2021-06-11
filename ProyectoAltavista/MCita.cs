using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAltavista
{
    public partial class MCita : Form
    {
        public MCita()
        {
            InitializeComponent();
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            MRegistrarCita RegistroCita = new MRegistrarCita();
            RegistroCita.Show();
            this.Close();
        }

        private void btnMostrarCita_Click(object sender, EventArgs e)
        {
            MMostrarCita mostrarCita = new MMostrarCita();
            mostrarCita.Show();
            this.Close();
        }

        private void btnRegresarCita_Click(object sender, EventArgs e)
        {
            MenuPrincipal menPrincipal = new MenuPrincipal();
            menPrincipal.Show();
            this.Close();
        }
    }
}

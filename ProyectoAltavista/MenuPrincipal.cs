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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }



        private void btCliente_Click_1(object sender, EventArgs e)
        {
            MantenedorCliente mantenedorCli = new MantenedorCliente();
            this.Hide();
            mantenedorCli.ShowDialog();
        }

        private void btAgente_Click(object sender, EventArgs e)
        {
            MantenedorAgente mantenedorAge = new MantenedorAgente();
            this.Hide();
            mantenedorAge.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1Fondo_Click(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            
            this.Close();
            log.Close();
        }
    }
}

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
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrarCliente_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarCliente = new RegistrarCliente();

            registrarCliente.Show();
            this.Close();
        }

        private void btModificarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btListaCliente_Click(object sender, EventArgs e)
        {

        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }
    }
}

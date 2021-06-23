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
        MenuPrincipal principal;
        RegistrarCliente registrarCliente;
        ConsultarCliente consultaCliente;
        public MantenedorCliente(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (registrarCliente == null)
            {
                registrarCliente = new RegistrarCliente(this);
            }

            registrarCliente.Show();
            this.Hide();
        }

        private void btRegresar_Click_1(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            if (consultaCliente == null)
            {
                consultaCliente = new ConsultarCliente(this);
            }
            consultaCliente.ListarClientes();
            consultaCliente.Show();
            this.Hide();
        }
    }
}

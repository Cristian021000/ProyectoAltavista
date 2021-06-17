using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace ProyectoAltavista
{
    public partial class RegistrarCliente : Form
    {
        MantenedorCliente clie;
        public RegistrarCliente(MantenedorCliente cl)
        {
            InitializeComponent();
            clie = cl;
        }

        private void lbRegistrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void lbDni_Click(object sender, EventArgs e)
        {

        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void lbApellido_Click(object sender, EventArgs e)
        {

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            clie.Show();
            this.Hide();
        }


        private void btnRegistar_Click(object sender, EventArgs e)
        {

            try
            {
                entCliente cli = new entCliente();
                cli.dnicliente = int.Parse(txtDniCliente.Text.Trim());
                cli.nombrecliente = txtNombreCliente.Text.Trim();
                cli.apelcliente = txtApellidoCliente.Text.Trim();
                cli.edadcliente = int.Parse(txtEdadCliente.Text.Trim());
                cli.celcliente = int.Parse(txtCelularCliente.Text.Trim());
                cli.estadocliente = true;

                if (!logCliente.Instancia.ExisteDatosCliente(cli))
                {
                    logCliente.Instancia.RegistrarCliente(cli);
                }
                else
                {
                    MessageBox.Show(" El cliente ya esta Registrado ");
                }
                MessageBox.Show("El cliente se a registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error.." + ex);
            }


        }
    }
}

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
    public partial class ModificarInhabilitarCliente : Form
    {
        public ModificarInhabilitarCliente(int dnicliente)
        {
            InitializeComponent();
            entCliente Cliente = new entCliente();
            Cliente = logCliente.Instancia.DatosCliente(dnicliente);
            chbHabilitar.Enabled = false;
            txtNombre.Text = Cliente.nombrecliente.ToString();
            txtApellido.Text = Cliente.apelcliente.ToString();
            txtEdad.Text = Cliente.edadcliente.ToString();
            txtCelular.Text = Cliente.celcliente.ToString();
            chbHabilitar.Checked = Cliente.estadocliente;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorCliente menuMantenedorCliente = new MantenedorCliente();
            menuMantenedorCliente.Show();
            this.Close();
        }

        private void chbHabilitar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1Fondo_Click(object sender, EventArgs e)
        {

        }

        private void btnModifcar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entCliente Cli = new entCliente();
                Cli.nombrecliente = txtNombre.Text.Trim();
                Cli.apelcliente = txtApellido.Text.Trim();
                Cli.edadcliente = int.Parse(txtEdad.Text.Trim());
                Cli.celcliente = int.Parse(txtCelular.Text.Trim());
                logCliente.Instancia.ModificarCliente(Cli);
                MessageBox.Show("Se editaron correctamente los datos del agente");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            ConsultarCliente consultar = new ConsultarCliente();
            consultar.Show();
            this.Close();
        }
    }
}

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
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
            ListarClientes();
        }

        public void ListarClientes()
        {
            dgvDatosCliente.DataSource = logCliente.Instancia.ListarClientes();
        }


        private void btAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entCliente Cli = new entCliente();
                Cli.dnicliente = int.Parse(txtIngreseDni.Text.Trim());
                if (logCliente.Instancia.BuscarCliente(Cli))
                {
                    ModificarAgente modi = new ModificarAgente(Cli.dnicliente);               //DUDA, SOLO debe ACEPTAR y NO MODIFICAR :'v
                    modi.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró al cliente");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {

            MantenedorCliente mantenedor = new MantenedorCliente();
            mantenedor.Show();
            this.Close();

        }

        private void dgvDatosCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
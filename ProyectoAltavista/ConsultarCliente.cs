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
        MantenedorCliente cliente;
        ModificarInhabilitarCliente modificar;
        public ConsultarCliente(MantenedorCliente menu)
        {
            InitializeComponent();
            ListarClientes();
            cliente = menu;
        }

        public void ListarClientes()
        {
            dgvDatosCliente.DataSource = logCliente.Instancia.ListarClientes();
        }
        public void limpiarVariableConsultar()
        {
            txtIngreseDni.Clear();
        }

        private void btAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entCliente Cli = new entCliente();
                Cli.dnicliente = int.Parse(txtIngreseDni.Text.Trim());
                if (logCliente.Instancia.BuscarCliente(Cli))
                {
                    if (modificar == null) 
                    {
                        modificar = new ModificarInhabilitarCliente(this);
                    }
                    Cli = logCliente.Instancia.DatosCliente(Cli.dnicliente);
                    modificar.llenarDatos(Cli);
                    modificar.Show();
                    this.Hide();
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

        private void btRegresar_Click(object sender, EventArgs e)
        {
            cliente.Show();
            this.Hide();
        }
    }
}
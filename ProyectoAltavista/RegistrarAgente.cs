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
    public partial class RegistrarAgente : Form
    {
        public RegistrarAgente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorAgente MantenedorAge = new MantenedorAgente();
            MantenedorAge.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entAgente age = new entAgente();
                age.nombre = txtNombreCliente.Text.Trim();
                age.apellido = txtApellidoCliente.Text.Trim();
                age.edad = int.Parse(txtEdadCliente.Text.Trim());
                age.celular = int.Parse(txtCelularCliente.Text.Trim());
                age.correo = txtRegistraCorreoElectronicoAgente.Text.Trim();
                age.contraseña = txtRegistrarContraseñaAgente.Text.Trim();
                age.dni = int.Parse(txtDniCliente.Text.Trim());
                logAgente.Instancia.RegistrarAgente(age);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error.." + ex);
            }
        }
    }
}

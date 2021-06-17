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
    public partial class ModificarAgente : Form
    {
        ConsultarAgente consulta;
        public ModificarAgente(int dni, ConsultarAgente consult)
        { 
            InitializeComponent();
            entAgente Agente = new entAgente();
            Agente = logAgente.Instancia.DatosAgente(dni);
            txtId.Enabled = false;
            chbHabilitado.Enabled = false;
            txtId.Text = Agente.id.ToString();
            txtNombreAgente.Text = Agente.nombre.ToString();
            txtApellidoAgente.Text = Agente.apellido.ToString();
            txtEdadAgente.Text = Agente.edad.ToString();
            txtCelularAgente.Text = Agente.celular.ToString();
            txtDatosCorreoElectronica.Text = Agente.correo.ToString();
            txtContraseñaDatosCliente.Text = Agente.contraseña.ToString();
            chbHabilitado.Checked = Agente.estado;
            consulta = consult;
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCelular_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            consulta.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDatosCorreoElectronica_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entAgente Age = new entAgente();
                Age.id = int.Parse(txtId.Text.Trim());
                Age.nombre = txtNombreAgente.Text.Trim();
                Age.apellido = txtApellidoAgente.Text.Trim();
                Age.edad = int.Parse(txtEdadAgente.Text.Trim());
                Age.celular = int.Parse(txtCelularAgente.Text.Trim());
                Age.correo = txtDatosCorreoElectronica.Text.Trim();
                Age.contraseña = txtContraseñaDatosCliente.Text.Trim();
                logAgente.Instancia.ModificarAgente(Age);
                MessageBox.Show("Se editaron correctamente los datos del agente");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void btDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entAgente A = new entAgente();
                A.id = int.Parse(txtId.Text.Trim());
                chbHabilitado.Checked = false;
                A.estado = chbHabilitado.Checked;
                logAgente.Instancia.DeshabilitarAgente(A);
                txtNombreAgente.Enabled = false;
                txtApellidoAgente.Enabled = false;
                txtEdadAgente.Enabled = false;
                txtCelularAgente.Enabled = false;
                txtDatosCorreoElectronica.Enabled = false;
                txtContraseñaDatosCliente.Enabled = false;
                MessageBox.Show("El agente a sido deshabilitado correctamente");
            }
            catch (Exception exe)
            {
                throw exe;
            }
            
        }
    }
}

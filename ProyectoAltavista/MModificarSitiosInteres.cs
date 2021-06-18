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
    public partial class MModificarSitiosInteres : Form
    {
        ConsultarSitiosInteres consulta;
        public MModificarSitiosInteres(ConsultarSitiosInteres consult)
        {
            InitializeComponent();
            consulta = consult;
        }
        public void llenarDatos(entSitioInteres sit)
        {
            txtCodigoModificaSI.Enabled = false;
            checkBoxHabilitar.Enabled = false;
            txtCodigoModificaSI.Text = sit.codSitioInteres.ToString();
            txtModificarNombreSI.Text = sit.NombreSI.ToString();
            txtModificarDireccionSI.Text = sit.DireccionSI.ToString();
            checkBoxHabilitar.Checked = sit.estadoSI;
        }
        public void limpiarVariableInterfazMod()
        {
            txtCodigoModificaSI.Clear();
            txtModificarNombreSI.Clear();
            txtModificarDireccionSI.Clear();
        }
        private void btnModificarSI_Click(object sender, EventArgs e)
        {
            try
            {
                entSitioInteres Sitio = new entSitioInteres();
                Sitio.codSitioInteres = int.Parse(txtCodigoModificaSI.Text.Trim());
                Sitio.NombreSI = txtModificarNombreSI.Text.Trim();
                Sitio.DireccionSI = txtModificarDireccionSI.Text.Trim();
                logSitioInteres.Instancia.ModificarSI(Sitio);
                MessageBox.Show("Se editaron correctamente los datos del sitio de interes.");
                consulta.listarSitioInteres();
                consulta.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                consulta.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            consulta.listarSitioInteres();
            consulta.limpiarVariableConsultar();
            limpiarVariableInterfazMod();
            consulta.Show();
            this.Hide();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entSitioInteres Sitio = new entSitioInteres();
                Sitio.codSitioInteres = int.Parse(txtCodigoModificaSI.Text.Trim());
                checkBoxHabilitar.Checked = false;
                Sitio.estadoSI = checkBoxHabilitar.Checked;
                logSitioInteres.Instancia.DeshabilitarSitioInteres(Sitio);
                MessageBox.Show("El sitio de interes a sido deshabilitado correctamente.");
                consulta.listarSitioInteres();
                consulta.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                consulta.Show();
                this.Hide();
            }
            catch (Exception exe)
            {
                throw exe;
            }
        }
    }
}

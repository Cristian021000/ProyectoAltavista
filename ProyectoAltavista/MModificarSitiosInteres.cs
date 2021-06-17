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
        ConsultarSitiosInteres sitio;
        public MModificarSitiosInteres(int codSitioInteres, ConsultarSitiosInteres sit)
        {
            InitializeComponent();
            sitio = sit;
        }
        public void llenarDatos(entSitioInteres Sitios)
        {
            txtCodigoModificaSI.Enabled = false;
            checkBoxHabilitar.Enabled = false;
            txtCodigoModificaSI.Text = Sitios.codSitioInteres.ToString();
            txtModificarNombreSI.Text = Sitios.NombreSI.ToString();
            txtModificarDireccionSI.Text = Sitios.DireccionSI.ToString();
            checkBoxHabilitar.Checked = Sitios.estadoSI;
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
                logSitioInteres.Instancia.EditarSI(Sitio);
                MessageBox.Show("Se editaron correctamente los datos del sitio de interes.");
                sitio.listarSitioInteres();
                sitio.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                sitio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            sitio.listarSitioInteres();
            sitio.limpiarVariableConsultar();
            limpiarVariableInterfazMod();
            sitio.Show();
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
                sitio.listarSitioInteres();
                sitio.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                sitio.Show();
                this.Hide();
            }
            catch (Exception exe)
            {
                throw exe;
            }
        }
    }
}

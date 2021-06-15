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
        public MModificarSitiosInteres(int codSitioInteres)
        {
            InitializeComponent();
            entSitioInteres Sitio = new entSitioInteres();
            Sitio = logSitioInteres.Instancia.DatosSitioInteres(codSitioInteres);
            txtCodigoModificaSI.Enabled = false;
            checkBoxHabilitar.Enabled = false;
            txtCodigoModificaSI.Text = Sitio.codSitioInteres.ToString();
            txtModificarNombreSI.Text = Sitio.NombreSI.ToString();
            txtModificarDireccionSI.Text = Sitio.DireccionSI.ToString();
            checkBoxHabilitar.Checked = Sitio.estadoSI;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorSitiosInteres MantenedorSitio = new MantenedorSitiosInteres();
            MantenedorSitio.Show();
            this.Close();
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
                txtCodigoModificaSI.Enabled = false;
                txtModificarNombreSI.Enabled = false;
                txtModificarDireccionSI.Enabled = false;
                MessageBox.Show("El sitio de interes a sido deshabilitado correctamente.");
                MantenedorSitiosInteres MantenedorSitio = new MantenedorSitiosInteres();
                MantenedorSitio.Show();
                this.Close();
            }
            catch (Exception exe)
            {
                throw exe;
            }
        }
    }
}

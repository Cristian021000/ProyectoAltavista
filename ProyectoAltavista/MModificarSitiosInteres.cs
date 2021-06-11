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
        public MModificarSitiosInteres()
        {
            InitializeComponent();
        }

        private void btnModificarSI_Click(object sender, EventArgs e)
        {
            try
            {
                entSitioInteres Sitio = new entSitioInteres();
                Sitio.codSitioInteres = int.Parse(txtCodigoModificaSI.Text.Trim());
                Sitio.NombreSI = txtModificarNombreSI.Text.Trim();
                Sitio.DireccionSI = txtModificarDireccionSI.Text.Trim();
                Sitio.estadoSI = checkBoxHabilitar.Checked;
                logSitioInteres.Instancia.EditarSI(Sitio);
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
    }
}

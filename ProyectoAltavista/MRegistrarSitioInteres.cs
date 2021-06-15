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
    public partial class MRegistrarSitioInteres : Form
    {
        public MRegistrarSitioInteres()
        {
            InitializeComponent();
            txtCodigoRegistrarSI.Enabled = false;
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorSitiosInteres sitio = new MantenedorSitiosInteres();
            sitio.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entSitioInteres Sitio = new entSitioInteres();
                Sitio.NombreSI = txtRegistrarNombreSI.Text.Trim();
                Sitio.DireccionSI = txtRegistrarDireccionSI.Text.Trim();
                Sitio.estadoSI = true;
                logSitioInteres.Instancia.RegistrarSI(Sitio);
                MessageBox.Show("El sitio de interes fue registrado.");
                MantenedorSitiosInteres sitio = new MantenedorSitiosInteres();
                sitio.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}

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
    public partial class ConsultarSitiosInteres : Form
    {
        public ConsultarSitiosInteres()
        {
            InitializeComponent();
            listarSitioInteres();
        }
        public void listarSitioInteres()
        {
            DataGridVerSitioInteres.DataSource = logSitioInteres.Instancia.ListarSitioInteres();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entSitioInteres Sitio = new entSitioInteres();
                Sitio.codSitioInteres = int.Parse(txtCodigoSitio.Text.Trim());
                MModificarSitiosInteres ModifaSI = new MModificarSitiosInteres();
                ModifaSI.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }
    }
}

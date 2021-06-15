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
                if (logSitioInteres.Instancia.BuscarSitioInteres(Sitio))
                {
                    MModificarSitiosInteres ModifaSI = new MModificarSitiosInteres(Sitio.codSitioInteres);
                    ModifaSI.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró al sitio de interes.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MantenedorSitiosInteres mantSI = new MantenedorSitiosInteres();
            mantSI.Show();
            this.Close();
        }
    }
}

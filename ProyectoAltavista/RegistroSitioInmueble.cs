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
    public partial class RegistroSitioInmueble : Form
    {
        MantenedorSitiosInteres mantSitioInteres;
        public RegistroSitioInmueble(MantenedorSitiosInteres mant)
        {
            InitializeComponent();
            mantSitioInteres = mant;
            ListarSitioInteres();
        }
        public void abrir()
        {
            ListarSitioInteres();
        }
        public void ListarSitioInteres()
        {
            SitioDeInteresVista.DataSource = logSitioInteres.Instancia.ListarSitioInteres();
        }
        public void ListarSitioInmueble()
        {
            dataGridViewRegistrarSitioInmueble.DataSource = logSitioInmueble.Instancia.ListarSitiosInmuebles();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LbSitioine_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtRegistrarSiti_Click(object sender, EventArgs e)
        {
            entSitioInmueble sitioInmueble = new entSitioInmueble();
            sitioInmueble.InmuebleID = int.Parse(txtIdInmuebleC.Text);
            sitioInmueble.SitiodeinteresID = int.Parse(txtIdSitioInteress.Text);
            sitioInmueble.Distancia = int.Parse(txtDsitancia.Text);
            logSitioInmueble.Instancia.RegistrarSitioInmueble(sitioInmueble);
            MessageBox.Show("Se registro correctamente el sitio inmueble");
            ListarSitioInmueble();
        }

        private void btnCancerlarModificarSI_Click(object sender, EventArgs e)
        {
            mantSitioInteres.Show();
            this.Hide();
        }

        private void comboBoxTipoInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipo;
            tipo = comboBoxTipoInmueble.SelectedIndex + 1;
            switch (tipo)
            {
                case 1:
                    InmueblesVista.DataSource = logInmueble.Instancia.ListarInmuebleCasa();
                    break;
                case 2:
                    InmueblesVista.DataSource = logInmueble.Instancia.ListarInmuebleDepartamento();
                    break;
                case 3:
                    InmueblesVista.DataSource = logInmueble.Instancia.ListarInmuebleTerreno();
                    break;
            }
        }
    }
}

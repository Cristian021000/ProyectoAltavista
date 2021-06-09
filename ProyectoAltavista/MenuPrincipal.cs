using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAltavista
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }



        private void btCliente_Click_1(object sender, EventArgs e)
        {
            MantenedorCliente mantenedorCli = new MantenedorCliente();
            this.Hide();
            mantenedorCli.ShowDialog();
        }

        private void btAgente_Click(object sender, EventArgs e)
        {
            MantenedorAgente mantenedorAge = new MantenedorAgente();
            this.Hide();
            mantenedorAge.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1Fondo_Click(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            
            this.Close();
            log.Close();
        }

        private void btBanco_Click(object sender, EventArgs e)
        {
            MantenedorBanco Ban = new MantenedorBanco();
            Ban.Show();
            this.Close();

        }

        private void btCiudad_Click(object sender, EventArgs e)
        {
            MantenedorCiudad ciu = new MantenedorCiudad();
            ciu.Show();
            this.Close();
        }

        private void btSitioInteres_Click(object sender, EventArgs e)
        {
            MantenedorSitiosInteres sitio = new MantenedorSitiosInteres();
            sitio.Show();
            this.Close();
        }

        private void btPropietario_Click(object sender, EventArgs e)
        {
            MantenedorCliPropietario propietario = new MantenedorCliPropietario();
            propietario.Show();
            this.Close();
        }

        private void btInmueble_Click(object sender, EventArgs e)
        {
            MantenedorDeInmueble inmueble = new MantenedorDeInmueble();
            inmueble.Show();
            this.Close();
        }

        private void btVenta_Click(object sender, EventArgs e)
        {
            MenuVentas ventas = new MenuVentas();
            ventas.Show();
            this.Close();
        }
    }
}

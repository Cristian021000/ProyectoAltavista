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
            mantenedorCli.Show();
        }

        private void btAgente_Click(object sender, EventArgs e)
        {
            MantenedorAgente mantenedorAge = new MantenedorAgente();
            this.Hide();
            mantenedorAge.Show();
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

            this.Hide();
            Ban.Show();
            

        }

        private void btCiudad_Click(object sender, EventArgs e)
        {
            MantenedorCiudad ciudad = new MantenedorCiudad();
            this.Hide();
            ciudad.Show();
            
        }

        private void btSitioInteres_Click(object sender, EventArgs e)
        {
            MantenedorSitiosInteres sitio = new MantenedorSitiosInteres();
            sitio.Show();
            this.Hide();
        }

        private void btPropietario_Click(object sender, EventArgs e)
        {
            MantenedorCliPropietario propietario = new MantenedorCliPropietario();
            propietario.Show();
            this.Hide();
        }

        private void btInmueble_Click(object sender, EventArgs e)
        {
            MantenedorDeInmueble inmueble = new MantenedorDeInmueble();
            inmueble.Show();
            this.Hide();
        }

        private void btVenta_Click(object sender, EventArgs e)
        {
            MenuVentas ventas = new MenuVentas();
            ventas.Show();
            this.Hide();
        }
        private void btCita_Click(object sender, EventArgs e)
        {
            MCita mantCita = new MCita();
            mantCita.Show();
            this.Hide();
        }
        private void btSector_Click(object sender, EventArgs e)
        {
            MantenedorSector mantSector = new MantenedorSector();
            mantSector.Show();
            this.Hide();
        }
    }
}

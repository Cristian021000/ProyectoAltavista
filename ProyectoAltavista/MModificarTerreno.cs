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
    public partial class MModificarTerreno : Form
    {
        ConsultarInmueble consultar;
        int idAux;
        public MModificarTerreno(ConsultarInmueble consu)
        {
            InitializeComponent();
            consultar = consu;
        }

        private void pictureBox1Fondo_Click(object sender, EventArgs e)
        {
            
        }

        public void DatosTerreno(entInmueble inmueble, entTerreno terreno)
        {
            idAux = inmueble.InmuebleID;
            txtPrecio.Text = inmueble.precio.ToString();
            txtPrecioMinimo.Text = inmueble.precioMinimo.ToString();
            chbAgua.Checked = terreno.agua;
            chbAlcantarillado.Checked = terreno.Alcantarillado;
            chbDesague.Checked = terreno.Desague;
            chbLuz.Checked = terreno.Luz;
            txtArea.Text = terreno.Aream2.ToString();
        }

        private void labelModificarTerreno_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecioMinimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            consultar.Show();
        }
    }
}

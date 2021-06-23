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
    public partial class MModificarDepartamento : Form
    {
        ConsultarInmueble consultar;
        int idAux;
        public MModificarDepartamento(ConsultarInmueble consu)
        {
            InitializeComponent();
            consultar = consu;
        }


        public void DatosDepartamento(entInmueble inmu, entDepartamento depar)
        {
            idAux = inmu.InmuebleID;
            txtPrecio.Text = inmu.precio.ToString();
            txtPrecioMinimo.Text = inmu.precioMinimo.ToString();
            txtCantidadBaños.Text = depar.CantBao.ToString();
            txtCantidadHabitaciones.Text = depar.CantHabitacinoes.ToString();
            txtCantidadCostruida.Text = depar.Aream2.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MantenedorInmueble_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarInmueble_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarInmueble_Click(object sender, EventArgs e)
        {

        }

        private void btnInhabilitarInmueble_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarInmueble_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirInmueble_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarInmueble_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoInmueble_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxDvi_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            consultar.Show();
        }
    }
}

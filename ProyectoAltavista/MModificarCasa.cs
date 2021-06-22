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
    public partial class MModificarCasa : Form
    {
        ConsultarInmueble consultar;
        int idAux;
        public MModificarCasa(ConsultarInmueble consu)
        {
            InitializeComponent();
            consultar = consu;
        }

        public void datosCasa(entInmueble inmueble, entCasa casa)
        {
            idAux = inmueble.idInmueble;
            txtPrecio.Text = inmueble.precio.ToString();
            txtPrecioMinimo.Text = inmueble.precioMinimo.ToString();
            txtCantidadPiso.Text = casa.cantPisos.ToString();
            txtCantidadBaños.Text = casa.cantBaños.ToString();
            txtCantidadHabitaciones.Text = casa.cantHabitaciones.ToString();
            txtCantidadCostruida.Text = casa.areaM2.ToString();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

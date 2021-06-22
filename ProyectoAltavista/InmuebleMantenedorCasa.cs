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
    public partial class InmuebleMantenedorCasa : Form
    {
        MantenedorDeInmueble inmueble;
        public InmuebleMantenedorCasa(MantenedorDeInmueble inm)
        {
            InitializeComponent();
            inmueble = inm;
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            inmueble.Show();
        }

        private void AceptarRegisCasa_Click(object sender, EventArgs e)
        {
            try
            {
                entInmueble inmueble = new entInmueble();
                entCasa casa = new entCasa();
                inmueble.idSector = int.Parse(textBox1IDSetor.Text.Trim());
                inmueble.idPropietario = int.Parse(textBox1IDPropietario.Text.Trim());
                inmueble.direccion = textBox1Direccion.Text.Trim();
                inmueble.precio = int.Parse(textBox1Precio.Text.Trim());
                inmueble.precioMinimo = int.Parse(textBox1PrecioMin.Text.Trim());
                inmueble.nRegistroPublico = int.Parse(textBox1RegistrosPublios.Text.Trim());
                inmueble.vendido = false;
                inmueble.habilitado = true;
                casa.cantPisos = int.Parse(textBox1CantidadPisos.Text.Trim());
                casa.cantBaños = int.Parse(textBox1CantidadBaños.Text.Trim());
                casa.cantHabitaciones = int.Parse(textBox1CantidadHabitaciones.Text.Trim());
                casa.piscina = chbPiscina.Checked;
                casa.jardin = chbJardin.Checked;
                casa.fechaConstruccion = dtpFecha.Value;
                logInmueble.Instancia.RegistrarInmueble(inmueble);
                casa.idInmueble1 = logInmueble.Instancia.BuscarNRegistroPublico(inmueble.nRegistroPublico).idInmueble;
                MessageBox.Show("id: " + casa.idInmueble1);
                logCasa.Instancia.RegistrarInmuebleCasa(casa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Fondo_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        MantenedorDeInmueble Mantinmueble;
        public InmuebleMantenedorCasa(MantenedorDeInmueble inm)
        {
            InitializeComponent();
            Mantinmueble = inm;
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantinmueble.Show();
        }

        private void AceptarRegisCasa_Click(object sender, EventArgs e)
        {
            try
            {
                entInmueble inmueble = new entInmueble();
                entCasa casa = new entCasa();
                inmueble.SectorID = int.Parse(textBox1IDSetor.Text.Trim());
                inmueble.idPropietario = int.Parse(textBox1IDPropietario.Text.Trim());
                inmueble.direccion = textBox1Direccion.Text.Trim();
                inmueble.precio = (float)Convert.ToDouble(textBox1Precio.Text.Trim());
                inmueble.precioMinimo = (float)Convert.ToDouble(textBox1PrecioMin.Text.Trim());
                inmueble.nRegistroPublico = int.Parse(textBox1RegistrosPublios.Text.Trim());           
                inmueble.vendido = false;
                inmueble.habilitado = true;
                casa.cantPisos = int.Parse(textBox1CantidadPisos.Text.Trim());
                casa.cantBaños = int.Parse(textBox1CantidadBaños.Text.Trim());
                casa.cantHabitaciones = int.Parse(textBox1CantidadHabitaciones.Text.Trim());
                casa.areaM2 = (float)Convert.ToDouble(txtAream2.Text.Trim());
                casa.piscina = chbPiscina.Checked;
                casa.jardin = chbJardin.Checked;
                casa.fechaConstruccion = dtpFecha.Value;
                logInmueble.Instancia.RegistrarInmueble(inmueble);
                casa.InmuebleID1 = logInmueble.Instancia.BuscarNRegistroPublico(inmueble.nRegistroPublico).InmuebleID;
                MessageBox.Show("Se registró correctamente el inmueble casa");
                logCasa.Instancia.RegistrarInmuebleCasa(casa);
                this.Hide();
                Mantinmueble.Show();
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

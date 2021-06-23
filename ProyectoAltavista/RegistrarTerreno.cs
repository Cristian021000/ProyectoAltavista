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
    public partial class RegistrarTerreno : Form
    {
        MantenedorDeInmueble inmuebles;
        public RegistrarTerreno(MantenedorDeInmueble inm)
        {
            InitializeComponent();
            inmuebles = inm;
        }

        private void RegresarTerreno_Click(object sender, EventArgs e)
        {
            this.Hide();
            inmuebles.Show();
        }

        private void AceptarRegisTerreno_Click(object sender, EventArgs e)
        {
            try
            {
                entInmueble inmueble = new entInmueble();
                entTerreno terreno = new entTerreno();
                inmueble.SectorID = int.Parse(txIDSectorT.Text.Trim());
                inmueble.idPropietario = int.Parse(txtIDPropietarioT.Text.Trim());
                inmueble.direccion = txtDireccionT.Text.Trim();
                inmueble.precio = (float)Convert.ToDouble(txtPrecioT.Text.Trim());
                inmueble.precioMinimo = (float)Convert.ToDouble(txtPrecioMinT.Text.Trim());
                inmueble.nRegistroPublico = int.Parse(txtRegisPubliT.Text.Trim());
                inmueble.vendido = false;
                inmueble.habilitado = true;
                terreno.agua = chbAgua.Checked;
                terreno.Luz = chbLuz.Checked;
                terreno.Alcantarillado = chbAlcantarillado.Checked;
                terreno.Desague = chbDesague.Checked;
                logInmueble.Instancia.RegistrarInmueble(inmueble);
                terreno.InmuebleID3 = logInmueble.Instancia.BuscarNRegistroPublico(inmueble.nRegistroPublico).InmuebleID;
                logTerreno.Instancia.RegistrarInmuebleTerreno(terreno);
                MessageBox.Show("Se registró correctamente el terreno");
                inmuebles.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

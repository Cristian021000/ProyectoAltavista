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
    public partial class ConsultarInmueble : Form
    {
        Inmueble inm;
        MModificarCasa casa;
        MModificarDepartamento departamento;
        MModificarTerreno terreno;
        int tipo;
        int aux;
        public ConsultarInmueble(Inmueble inmu)
        {
            InitializeComponent();
            inm = inmu;
            //comboBoxTipoInmueble.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            entInmueble inmueble = new entInmueble();
            aux = int.Parse(txtCodigo.Text.Trim());
            entCasa cas = new entCasa();
            switch (tipo)
            {
                case 1:
                    if (casa == null)
                    {
                        casa = new MModificarCasa(this); 
                    }
                    inmueble = logInmueble.Instancia.DatosInmueble(aux);
                    cas = logCasa.Instancia.DatosCasa(aux);
                    casa.datosCasa(inmueble, cas);
                    this.Hide();
                    casa.Show();
                    break;
                case 2: break;
                case 3: break;
            }
        }
        public void ListarInmueble()
        {
            
        }

        private void comboBoxTipoInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = comboBoxTipoInmueble.SelectedIndex + 1;
            switch (tipo)
            {
                case 1:
                    dataGridViewConsulInmuble.DataSource = logInmueble.Instancia.ListarInmuebleCasa();
                    dtgTipoInmueble.DataSource = logCasa.Instancia.ListarInmuebleCasa();
                    break;
                case 2: break;
                case 3: break;
            }
        }
    }
}

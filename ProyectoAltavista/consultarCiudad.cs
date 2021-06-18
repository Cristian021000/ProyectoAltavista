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
    public partial class consultarCiudad : Form
    {
        MantenedorCiudad ciuda;
        ModificarInhabilitarCiudad modi;
        public consultarCiudad(MantenedorCiudad ciud)
        {
            InitializeComponent();
            ListaCiudad();
            ciuda = ciud;

        }
        public void ListaCiudad()
        {
            dgvConsultaCiudad.DataSource = logCiudad.Instancia.ListarCiudad();
        }
        public void limpiarVariableConsultar()
        {
            txtcodCiudad.Clear();
        }

        private void btModificarCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad ciudad = new entCiudad();
                if (logCiudad.Instancia.BuscaCiudad(ciudad))
                {
                    if (modi == null )
                    {
                         modi = new ModificarInhabilitarCiudad(this);
                    }
                    ciudad = logCiudad.Instancia.DatosCiudad(ciudad.codCiudad);
                    modi.llenarDatos(ciudad);
                    modi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se encontro la Ciudad");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

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
        public consultarCiudad()
        {
            InitializeComponent();
            ListaCiudad();

        }
        public void ListaCiudad()
        {
            dgvConsultaCiudad.DataSource = logCiudad.Instancia.ListarCiudad();
        }

        private void btModificarCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad ciudad = new entCiudad();
                if (logCiudad.Instancia.BuscaCiudad(ciudad))
                {
                    ModificarInhabilitarCiudad modi = new ModificarInhabilitarCiudad(ciudad.codCiudad);
                    modi.Show();
                    this.Close();
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

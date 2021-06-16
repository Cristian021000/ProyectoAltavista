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
    public partial class RegistrarCiudad : Form
    {
        public RegistrarCiudad()
        {
            InitializeComponent();
        }

        private void lbRegistrarCiudad_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorCiudad mantCiudad = new MantenedorCiudad();
            mantCiudad.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad ciudad = new entCiudad();
                ciudad.nombCiudad = txtNombreCiudad.Text.Trim();
                ciudad.referenciasCiudad = textReferenciasCiudad.Text.Trim();
                ciudad.postalCiudad = int.Parse(textCódigoPostal.Text.Trim());
                logCiudad.Instancia.RegistrarCiudad(ciudad);
                MessageBox.Show("Ciudad Registrada Correctamente");
                MantenedorCiudad manCiudad = new MantenedorCiudad();
                manCiudad.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error.." + ex);
            }
        }
    }
}

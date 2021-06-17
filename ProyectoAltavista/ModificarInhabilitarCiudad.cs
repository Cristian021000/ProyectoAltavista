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
    public partial class ModificarInhabilitarCiudad : Form
    {
        consultarCiudad ciuda;
        public ModificarInhabilitarCiudad(int codCiudad, consultarCiudad ciu)
        {
            InitializeComponent();
            entCiudad Ciudad = new entCiudad();
            Ciudad = logCiudad.Instancia.DatosCiudad(codCiudad);
            txtNombreCiudad.Text = Ciudad.nombCiudad.ToString();
            textCódigoPostal.Text = Ciudad.postalCiudad.ToString();
            textReferenciasCiudad.Text = Ciudad.referenciasCiudad.ToString();
            ciuda = ciu;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1Bnaco_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            ciuda.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad ciudad = new entCiudad();
                ciudad.nombCiudad = txtNombreCiudad.Text.Trim();
                ciudad.postalCiudad = int.Parse(textCódigoPostal.Text.Trim());
                ciudad.referenciasCiudad = textReferenciasCiudad.Text.Trim();           
                logCiudad.Instancia.ModificarCiudad(ciudad);
                MessageBox.Show("Se editaron correctamente la ciudad");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

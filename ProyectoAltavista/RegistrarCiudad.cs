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
        MantenedorCiudad ciud;
        public RegistrarCiudad(MantenedorCiudad ci)
        {
            InitializeComponent();
            ciud = ci;
        }
        public void limpiarVariableInterfazReg()
        {
            txtNombreCiudad.Clear();
            textCódigoPostal.Clear();
            textReferenciasCiudad.Clear();
        }
        private void lbRegistrarCiudad_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            ciud.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad ciudad = new entCiudad();
                ciudad.nombrCiudad = txtNombreCiudad.Text.Trim();
                ciudad.referenciasCiudad = textReferenciasCiudad.Text.Trim();
                ciudad.postalCiudad = int.Parse(textCódigoPostal.Text.Trim());
                if (logCiudad.Instancia.ExisteDatosCiudadNombre(ciudad))
                {
                    MessageBox.Show("El nombre de la ciudad ya está en uso.");
                }
                else
                {
                    logCiudad.Instancia.RegistrarCiudad(ciudad);
                    MessageBox.Show("Ciudad Registrada Correctamente.");
                    limpiarVariableInterfazReg();
                    ciud.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error.." + ex);
            }
        }
    }
}

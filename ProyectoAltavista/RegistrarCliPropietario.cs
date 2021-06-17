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
    public partial class RegistrarCliPropietario : Form
    {
        public RegistrarCliPropietario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorCliPropietario mantCliPropietario = new MantenedorCliPropietario();
            mantCliPropietario.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entPropietario Prop = new entPropietario();
                Prop.dni = int.Parse(txtDni.Text.Trim());
                Prop.nombre = txtNombre.Text.Trim();
                Prop.apellido = txtApellido.Text.Trim();
                Prop.edad = int.Parse(txtEdad.Text.Trim());
                Prop.celular = int.Parse(txtCelular.Text.Trim());
                Prop.direccion = txtDireccion.Text.Trim();
                Prop.estadoPropietario = true;
                if (!logPropietario.Instancia.ExisteDatosPropietario(Prop))
                {
                    logPropietario.Instancia.RegistrarPropietario(Prop);
                }
                else
                {
                    MessageBox.Show("El dni o el número de celular ya se encuentran en uso");
                }
                MessageBox.Show("El propietario fue registrado exitosamente ");
                MantenedorSitiosInteres sitio = new MantenedorSitiosInteres();
                sitio.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}

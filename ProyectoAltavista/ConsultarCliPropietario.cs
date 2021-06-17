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
    public partial class ConsultarCliPropietario : Form
    {
        public ConsultarCliPropietario()
        {
            InitializeComponent();
            listarPropietario();
        }
        public void listarPropietario()
        {
            dgvDatosPropietario.DataSource = logPropietario.Instancia.ListarPropietario();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entPropietario Prop = new entPropietario();
                Prop.dni = int.Parse(txtIngreseDni.Text.Trim());
                if (logPropietario.Instancia.BuscarPropietario(Prop))
                {
                    ModificarInhabilitarCliPropietario mod = ModificarInhabilitarCliPropietario(Prop.dni);
                    mod.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró al Propietario");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            MantenedorCliPropietario menPropietario = new MantenedorCliPropietario();
            menPropietario.Show();
            this.Close();
        }
    }
    
}
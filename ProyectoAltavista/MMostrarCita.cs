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
    public partial class MMostrarCita : Form
    {
        MCita Mantcita;
        ModificarCita modificar;
        public MMostrarCita(MCita ci)
        {
            InitializeComponent();
            ListarCita();
            Mantcita = ci;
        }
        public void ListarCita()
        {
            dataGridViewMostrarCita.DataSource = logCita.Instancia.ListarCita();
        }
        public void limpiarVariableConsultar()
        {
            txtIDClienteCita.Clear();
        }
        private void btnSalirMostrarCita_Click(object sender, EventArgs e)
        {
            Mantcita.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entCita cita = new entCita();
                cita.CitaID = int.Parse(txtIDClienteCita.Text.Trim());
                if (logCita.Instancia.BuscarCita(cita))
                {
                    if (modificar == null)
                    {
                        modificar = new ModificarCita(this);
                    }
                    cita = logCita.Instancia.DatosCita(cita.CitaID);
                    modificar.llenarDatos(cita);
                    modificar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La cita ya fue realizada o ha sido inhabilitada .");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

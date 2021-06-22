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
    public partial class InmuebleSetorRegistro : Form
    {
        MantenedorSector ManteSector;
        public InmuebleSetorRegistro(MantenedorSector ManteneSector)
        {

            InitializeComponent();
            ManteSector = ManteneSector;
            ListaCiudades();
        }

        private void btnAgregarSector_Click(object sender, EventArgs e)
        {
            try
            {
                entSector sec = new entSector();
                sec.Nombresector = txtNombreSector.Text.Trim();
                if (!logSector.Instancia.ExisteDatosSector(sec.Nombresector))
                {
                    sec.CiudadID = Convert.ToInt32(comboBoxCiudad.SelectedValue);
                    sec.Nombresector = txtNombreSector.Text.Trim();
                    sec.Comentario = txtComentarioSector.Text.Trim();
                    logSector.Instancia.RegistrarSector(sec);
                    MessageBox.Show("Se registro correctamente el sector");
                    ManteSector.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ya existe este sector");
                }
                
                ListaCiudades();
                limpiarVariableInterfazMod();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error..." + ex);
            }

        }

        /*private void ListaCiudades()
        {
            List<entCiudad> listciudad= logCiudad.Instancia.ListarCiudad();
            foreach (entCiudad a in listciudad)
            {
                comboBoxCiudad.Items.Add(a.nombrCiudad);
            }

        }*/

        public void ListaCiudades()
        {
            comboBoxCiudad.DataSource = logCiudad.Instancia.ListarCiudad();
            comboBoxCiudad.DisplayMember = "nombrCiudad";
            comboBoxCiudad.ValueMember = "CiudadID";
        }

        public void limpiarVariableInterfazMod()
        {
            txtNombreSector.Clear();
            txtComentarioSector.Clear();
        }



        private void Regresar_Click(object sender, EventArgs e)
        {
            ManteSector.Show();
            this.Hide();
            limpiarVariableInterfazMod();
        }
    }
}

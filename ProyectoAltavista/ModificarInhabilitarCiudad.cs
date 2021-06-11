using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAltavista
{
    public partial class ModificarInhabilitarCiudad : Form
    {
        public ModificarInhabilitarCiudad()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1Bnaco_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorCiudad mantCiudad = new MantenedorCiudad();
            mantCiudad.Show();
            this.Close();
        }
    }
}

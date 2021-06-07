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
    public partial class RegistrarAgente : Form
    {
        public RegistrarAgente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorAgente MantenedorAge = new MantenedorAgente();
            MantenedorAge.Show();
            this.Close();
        }
    }
}

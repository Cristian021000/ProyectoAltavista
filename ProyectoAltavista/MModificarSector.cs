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
    public partial class MModificarSector : Form
    {
        public MModificarSector()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorSector mantSector = new MantenedorSector();
            mantSector.Show();
            this.Close();
        }
    }
}

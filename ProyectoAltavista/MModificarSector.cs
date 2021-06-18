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
        MantenedorSector sector;
        public MModificarSector(MantenedorSector sec)
        {
            InitializeComponent();
            sector = sec;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            sector.Show();
            this.Hide();
        }
    }
}

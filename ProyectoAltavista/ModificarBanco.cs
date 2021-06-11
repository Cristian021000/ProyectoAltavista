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
    public partial class ModificarBanco : Form
    {
        public ModificarBanco()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MantenedorBanco mantBanco = new MantenedorBanco();
            mantBanco.Show();
            this.Close();
        }
    }
}

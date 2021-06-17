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
    public partial class MRegistrarCita : Form
    {
        MCita mantCita;
        public MRegistrarCita(MCita ci)
        {
            InitializeComponent();
            mantCita = ci;
        }

        private void btnCancelarRegistrarCita_Click(object sender, EventArgs e)
        {   
            mantCita.Show();
            this.Close();
        }
    }
}

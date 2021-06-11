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
    public partial class MantenedorBanco : Form
    {
        public MantenedorBanco()
        {
            InitializeComponent();
        }

        private void MantenedorBanco_Load(object sender, EventArgs e)
        {

        }

        private void bt2RegistarBanco_Click(object sender, EventArgs e)
        {
            RegistroBanco registrarBanco = new RegistroBanco();
            registrarBanco.Show();
            this.Close();
        }

        private void bt3MostraBanco_Click(object sender, EventArgs e)
        {
            MostrandoBanco muestraBanco = new MostrandoBanco();
            muestraBanco.Show();
            this.Close();
        }
    }
}

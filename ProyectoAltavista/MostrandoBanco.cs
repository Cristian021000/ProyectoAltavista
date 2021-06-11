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
    public partial class MostrandoBanco : Form
    {
        public MostrandoBanco()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1NombreBanco_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1Fondo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MantenedorBanco mantBano = new MantenedorBanco();
            mantBano.Show();
            this.Close();
        }
    }
}

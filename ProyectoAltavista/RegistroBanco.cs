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
    public partial class RegistroBanco : Form
    {
        public RegistroBanco()
        {
            InitializeComponent();
            ListarBanco();
        }
        public void ListarBanco()
        {
            dgRegistroBanco.DataSource = logBanco.Instancia.ListarBancos();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            MantenedorBanco mantBanco = new MantenedorBanco();
            mantBanco.Show();
            this.Close();
        }

        private void bt2RegistarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                entBanco ban = new entBanco();
                ban.Nombre = textbAgregarBanco.Text.Trim();
                ban.idbanco = int.Parse(textBox1CodigoBanco.Text.Trim());
                logBanco.Instancia.RegistrarBanco(ban);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error..." + ex);
            }
            ListarBanco();
        }

        private void dgRegistroBanco_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgRegistroBanco.Rows[e.RowIndex]; //
            textbAgregarBanco.Text = filaActual.Cells[0].Value.ToString();
            textBox1CodigoBanco.Text = filaActual.Cells[1].Value.ToString();
        }
    }
}

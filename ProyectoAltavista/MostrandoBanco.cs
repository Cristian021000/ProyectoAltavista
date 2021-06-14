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
    public partial class MostrandoBanco : Form
    {
        public MostrandoBanco()
        {
            InitializeComponent();
            ListarBanco();
        }
        public void ListarBanco()
        {
            DataGridMostrarBanco.DataSource = logBanco.Instancia.ListarBancos();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entBanco banco = new entBanco();
                banco.idbanco = int.Parse(textBox1IngresoBanco.Text.Trim());
                if (logBanco.Instancia.BuscarBanco(banco))
                {
                    ModificarBanco mod = new ModificarBanco(banco.idbanco);
                    mod.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró al Banco");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DataGridMostrarBanco_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

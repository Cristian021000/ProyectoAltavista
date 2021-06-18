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
    public partial class ModificarBanco : Form
    {
        MostrandoBanco banc;
        public ModificarBanco(int idbanco, MostrandoBanco ban)
        {
            InitializeComponent();
            banc = ban;
        }
        public void llenarDatos(entBanco banco)
        {
            txtIdBanco.Enabled = false;
            textBox1NombreBanco.Text = banco.Nombre.ToString();
            txtIdBanco.Text = banco.idbanco.ToString();
        }
        public void limpiarVariableInterfazMod()
        {
            txtIdBanco.Clear();
            textBox1NombreBanco.Clear();
        }
        public void ListarBanco()
        {
            dataGridViewVerBanco.DataSource = logBanco.Instancia.ListarBancos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            banc.ListarBanco();
            banc.limpiarVariableConsultar();
            limpiarVariableInterfazMod();
            banc.Show();
            this.Close();
        }
        private void LimpiarVariables()
        {
            textBox1NombreBanco.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entBanco banco = new entBanco();
                banco.idbanco = int.Parse(txtIdBanco.Text.Trim());
                banco.Nombre = textBox1NombreBanco.Text.Trim();
                logBanco.Instancia.EditarBanco(banco);
                MessageBox.Show("Cambio realizado con exito");
                banc.ListarBanco();
                banc.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                banc.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dataGridViewVerBanco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dataGridViewVerBanco.Rows[e.RowIndex];
            textBox1NombreBanco.Text = filaActual.Cells[0].Value.ToString();
            txtIdBanco.Text = filaActual.Cells[1].Value.ToString();
        }
    }
}

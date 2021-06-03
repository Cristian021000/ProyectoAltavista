
namespace ProyectoAltavista
{
    partial class ConsultarVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDatosVentas = new System.Windows.Forms.Label();
            this.rbVentaPropia = new System.Windows.Forms.RadioButton();
            this.dbVentaTerceros = new System.Windows.Forms.RadioButton();
            this.btRegresar = new System.Windows.Forms.Button();
            this.dgvDatosVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDatosVentas
            // 
            this.lbDatosVentas.AutoSize = true;
            this.lbDatosVentas.Location = new System.Drawing.Point(333, 46);
            this.lbDatosVentas.Name = "lbDatosVentas";
            this.lbDatosVentas.Size = new System.Drawing.Size(145, 13);
            this.lbDatosVentas.TabIndex = 0;
            this.lbDatosVentas.Text = "Datos de venta de inmuebles";
            // 
            // rbVentaPropia
            // 
            this.rbVentaPropia.AutoSize = true;
            this.rbVentaPropia.Location = new System.Drawing.Point(68, 99);
            this.rbVentaPropia.Name = "rbVentaPropia";
            this.rbVentaPropia.Size = new System.Drawing.Size(85, 17);
            this.rbVentaPropia.TabIndex = 1;
            this.rbVentaPropia.TabStop = true;
            this.rbVentaPropia.Text = "Venta propia";
            this.rbVentaPropia.UseVisualStyleBackColor = true;
            // 
            // dbVentaTerceros
            // 
            this.dbVentaTerceros.AutoSize = true;
            this.dbVentaTerceros.Location = new System.Drawing.Point(68, 138);
            this.dbVentaTerceros.Name = "dbVentaTerceros";
            this.dbVentaTerceros.Size = new System.Drawing.Size(109, 17);
            this.dbVentaTerceros.TabIndex = 2;
            this.dbVentaTerceros.TabStop = true;
            this.dbVentaTerceros.Text = "Venta de terceros";
            this.dbVentaTerceros.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(650, 319);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(119, 66);
            this.btRegresar.TabIndex = 4;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // dgvDatosVenta
            // 
            this.dgvDatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVenta.Location = new System.Drawing.Point(68, 192);
            this.dgvDatosVenta.Name = "dgvDatosVenta";
            this.dgvDatosVenta.Size = new System.Drawing.Size(554, 225);
            this.dgvDatosVenta.TabIndex = 5;
            // 
            // ConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatosVenta);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.dbVentaTerceros);
            this.Controls.Add(this.rbVentaPropia);
            this.Controls.Add(this.lbDatosVentas);
            this.Name = "ConsultarVentas";
            this.Text = "ConsultarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDatosVentas;
        private System.Windows.Forms.RadioButton rbVentaPropia;
        private System.Windows.Forms.RadioButton dbVentaTerceros;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.DataGridView dgvDatosVenta;
    }
}
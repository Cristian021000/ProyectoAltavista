
namespace ProyectoAltavista
{
    partial class MantenedorCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMenuCliente = new System.Windows.Forms.Label();
            this.btRegistrarCliente = new System.Windows.Forms.Button();
            this.btListaCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMenuCliente
            // 
            this.lbMenuCliente.AutoSize = true;
            this.lbMenuCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuCliente.Location = new System.Drawing.Point(328, 38);
            this.lbMenuCliente.Name = "lbMenuCliente";
            this.lbMenuCliente.Size = new System.Drawing.Size(145, 55);
            this.lbMenuCliente.TabIndex = 0;
            this.lbMenuCliente.Text = "Menú";
            this.lbMenuCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // btRegistrarCliente
            // 
            this.btRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarCliente.Location = new System.Drawing.Point(141, 221);
            this.btRegistrarCliente.Name = "btRegistrarCliente";
            this.btRegistrarCliente.Size = new System.Drawing.Size(179, 74);
            this.btRegistrarCliente.TabIndex = 1;
            this.btRegistrarCliente.Text = "Registrar";
            this.btRegistrarCliente.UseVisualStyleBackColor = true;
            this.btRegistrarCliente.Click += new System.EventHandler(this.btRegistrarCliente_Click);
            // 
            // btListaCliente
            // 
            this.btListaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListaCliente.Location = new System.Drawing.Point(496, 220);
            this.btListaCliente.Name = "btListaCliente";
            this.btListaCliente.Size = new System.Drawing.Size(173, 75);
            this.btListaCliente.TabIndex = 4;
            this.btListaCliente.Text = "Lista";
            this.btListaCliente.UseVisualStyleBackColor = true;
            this.btListaCliente.Click += new System.EventHandler(this.btListaCliente_Click);
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 448);
            this.Controls.Add(this.btListaCliente);
            this.Controls.Add(this.btRegistrarCliente);
            this.Controls.Add(this.lbMenuCliente);
            this.Name = "MantenedorCliente";
            this.Text = "Mantenedor del Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMenuCliente;
        private System.Windows.Forms.Button btRegistrarCliente;
        private System.Windows.Forms.Button btListaCliente;
    }
}


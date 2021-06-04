
namespace ProyectoAltavista
{
    partial class ConsultarContratoInmueble
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
            this.dataGridDatosCI = new System.Windows.Forms.DataGridView();
            this.lbDatosContrato = new System.Windows.Forms.Label();
            this.labelIngresoDNIDCI = new System.Windows.Forms.Label();
            this.textBoxDNIDCI = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btnInhabilitarDCI = new System.Windows.Forms.Button();
            this.btnSalirDCI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatosCI)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDatosCI
            // 
            this.dataGridDatosCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatosCI.Location = new System.Drawing.Point(12, 95);
            this.dataGridDatosCI.Name = "dataGridDatosCI";
            this.dataGridDatosCI.Size = new System.Drawing.Size(486, 343);
            this.dataGridDatosCI.TabIndex = 0;
            // 
            // lbDatosContrato
            // 
            this.lbDatosContrato.AutoSize = true;
            this.lbDatosContrato.Font = new System.Drawing.Font("Monotype Corsiva", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosContrato.Location = new System.Drawing.Point(168, 9);
            this.lbDatosContrato.Name = "lbDatosContrato";
            this.lbDatosContrato.Size = new System.Drawing.Size(495, 56);
            this.lbDatosContrato.TabIndex = 1;
            this.lbDatosContrato.Text = "Datos de Contrato Inmueble";
            // 
            // labelIngresoDNIDCI
            // 
            this.labelIngresoDNIDCI.AutoSize = true;
            this.labelIngresoDNIDCI.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoDNIDCI.Location = new System.Drawing.Point(522, 118);
            this.labelIngresoDNIDCI.Name = "labelIngresoDNIDCI";
            this.labelIngresoDNIDCI.Size = new System.Drawing.Size(266, 24);
            this.labelIngresoDNIDCI.TabIndex = 2;
            this.labelIngresoDNIDCI.Text = "Ingrese DNI propietario:";
            // 
            // textBoxDNIDCI
            // 
            this.textBoxDNIDCI.Location = new System.Drawing.Point(531, 160);
            this.textBoxDNIDCI.Name = "textBoxDNIDCI";
            this.textBoxDNIDCI.Size = new System.Drawing.Size(238, 20);
            this.textBoxDNIDCI.TabIndex = 3;
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(598, 224);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(103, 31);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitarDCI
            // 
            this.btnInhabilitarDCI.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarDCI.Location = new System.Drawing.Point(587, 292);
            this.btnInhabilitarDCI.Name = "btnInhabilitarDCI";
            this.btnInhabilitarDCI.Size = new System.Drawing.Size(128, 31);
            this.btnInhabilitarDCI.TabIndex = 5;
            this.btnInhabilitarDCI.Text = "Inhabilitar";
            this.btnInhabilitarDCI.UseVisualStyleBackColor = true;
            // 
            // btnSalirDCI
            // 
            this.btnSalirDCI.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirDCI.Location = new System.Drawing.Point(598, 360);
            this.btnSalirDCI.Name = "btnSalirDCI";
            this.btnSalirDCI.Size = new System.Drawing.Size(103, 31);
            this.btnSalirDCI.TabIndex = 6;
            this.btnSalirDCI.Text = "Salir";
            this.btnSalirDCI.UseVisualStyleBackColor = true;
            // 
            // ConsultarContratoInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirDCI);
            this.Controls.Add(this.btnInhabilitarDCI);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.textBoxDNIDCI);
            this.Controls.Add(this.labelIngresoDNIDCI);
            this.Controls.Add(this.lbDatosContrato);
            this.Controls.Add(this.dataGridDatosCI);
            this.Name = "ConsultarContratoInmueble";
            this.Text = "ConsultarContratoInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatosCI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDatosCI;
        private System.Windows.Forms.Label lbDatosContrato;
        private System.Windows.Forms.Label labelIngresoDNIDCI;
        private System.Windows.Forms.TextBox textBoxDNIDCI;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btnInhabilitarDCI;
        private System.Windows.Forms.Button btnSalirDCI;
    }
}
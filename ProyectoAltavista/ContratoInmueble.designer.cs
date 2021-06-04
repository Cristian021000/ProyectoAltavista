
namespace ProyectoAltavista
{
    partial class ContratoInmueble
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
            this.labelContratoInmueblePropietario = new System.Windows.Forms.Label();
            this.btnRegistrarContratoInmueble = new System.Windows.Forms.Button();
            this.btnListarContratoInmueble = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelContratoInmueblePropietario
            // 
            this.labelContratoInmueblePropietario.AutoSize = true;
            this.labelContratoInmueblePropietario.Font = new System.Drawing.Font("Monotype Corsiva", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContratoInmueblePropietario.Location = new System.Drawing.Point(218, 18);
            this.labelContratoInmueblePropietario.Name = "labelContratoInmueblePropietario";
            this.labelContratoInmueblePropietario.Size = new System.Drawing.Size(336, 56);
            this.labelContratoInmueblePropietario.TabIndex = 1;
            this.labelContratoInmueblePropietario.Text = "Contrato Inmueble";
            // 
            // btnRegistrarContratoInmueble
            // 
            this.btnRegistrarContratoInmueble.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarContratoInmueble.Location = new System.Drawing.Point(107, 157);
            this.btnRegistrarContratoInmueble.Name = "btnRegistrarContratoInmueble";
            this.btnRegistrarContratoInmueble.Size = new System.Drawing.Size(214, 61);
            this.btnRegistrarContratoInmueble.TabIndex = 2;
            this.btnRegistrarContratoInmueble.Text = "Registrar Contrato de Inmueble";
            this.btnRegistrarContratoInmueble.UseVisualStyleBackColor = true;
            // 
            // btnListarContratoInmueble
            // 
            this.btnListarContratoInmueble.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarContratoInmueble.Location = new System.Drawing.Point(480, 157);
            this.btnListarContratoInmueble.Name = "btnListarContratoInmueble";
            this.btnListarContratoInmueble.Size = new System.Drawing.Size(214, 61);
            this.btnListarContratoInmueble.TabIndex = 3;
            this.btnListarContratoInmueble.Text = "Listar";
            this.btnListarContratoInmueble.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(666, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ContratoInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListarContratoInmueble);
            this.Controls.Add(this.btnRegistrarContratoInmueble);
            this.Controls.Add(this.labelContratoInmueblePropietario);
            this.Name = "ContratoInmueble";
            this.Text = "ContratoInmueble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContratoInmueblePropietario;
        private System.Windows.Forms.Button btnRegistrarContratoInmueble;
        private System.Windows.Forms.Button btnListarContratoInmueble;
        private System.Windows.Forms.Button button1;
    }
}
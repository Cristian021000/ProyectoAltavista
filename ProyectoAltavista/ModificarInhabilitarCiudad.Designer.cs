
namespace ProyectoAltavista
{
    partial class ModificarInhabilitarCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarInhabilitarCiudad));
            this.textReferenciasCiudad = new System.Windows.Forms.TextBox();
            this.textCódigoPostal = new System.Windows.Forms.TextBox();
            this.textDireccionCiudad = new System.Windows.Forms.TextBox();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.labelDatosCiudad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // textReferenciasCiudad
            // 
            this.textReferenciasCiudad.Location = new System.Drawing.Point(246, 288);
            this.textReferenciasCiudad.Name = "textReferenciasCiudad";
            this.textReferenciasCiudad.Size = new System.Drawing.Size(360, 20);
            this.textReferenciasCiudad.TabIndex = 21;
            // 
            // textCódigoPostal
            // 
            this.textCódigoPostal.Location = new System.Drawing.Point(246, 236);
            this.textCódigoPostal.Name = "textCódigoPostal";
            this.textCódigoPostal.Size = new System.Drawing.Size(360, 20);
            this.textCódigoPostal.TabIndex = 20;
            // 
            // textDireccionCiudad
            // 
            this.textDireccionCiudad.Location = new System.Drawing.Point(246, 192);
            this.textDireccionCiudad.Name = "textDireccionCiudad";
            this.textDireccionCiudad.Size = new System.Drawing.Size(360, 20);
            this.textDireccionCiudad.TabIndex = 19;
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Location = new System.Drawing.Point(246, 143);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(360, 20);
            this.txtNombreCiudad.TabIndex = 18;
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-20, -7);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 26;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // labelDatosCiudad
            // 
            this.labelDatosCiudad.AutoSize = true;
            this.labelDatosCiudad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDatosCiudad.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosCiudad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDatosCiudad.Location = new System.Drawing.Point(90, 29);
            this.labelDatosCiudad.Name = "labelDatosCiudad";
            this.labelDatosCiudad.Size = new System.Drawing.Size(410, 79);
            this.labelDatosCiudad.TabIndex = 27;
            this.labelDatosCiudad.Text = "Datos de Cuidad";
            this.labelDatosCiudad.Click += new System.EventHandler(this.label1Bnaco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre de Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Direccion:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Codigo Postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Referencias:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(617, 143);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(160, 49);
            this.btnRegistrar.TabIndex = 32;
            this.btnRegistrar.Text = "Registar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(617, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 49);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(617, 353);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(160, 49);
            this.btnInhabilitar.TabIndex = 34;
            this.btnInhabilitar.Text = "Inhabiitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            // 
            // ModificarInhabilitarCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDatosCiudad);
            this.Controls.Add(this.textReferenciasCiudad);
            this.Controls.Add(this.textCódigoPostal);
            this.Controls.Add(this.textDireccionCiudad);
            this.Controls.Add(this.txtNombreCiudad);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarInhabilitarCiudad";
            this.Text = "ModificarInhabilitarCiudad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textReferenciasCiudad;
        private System.Windows.Forms.TextBox textCódigoPostal;
        private System.Windows.Forms.TextBox textDireccionCiudad;
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.Label labelDatosCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInhabilitar;
    }
}
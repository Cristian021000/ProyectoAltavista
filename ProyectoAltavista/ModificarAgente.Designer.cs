
namespace ProyectoAltavista
{
    partial class ModificarAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAgente));
            this.txtCelularAgente = new System.Windows.Forms.TextBox();
            this.txtEdadAgente = new System.Windows.Forms.TextBox();
            this.txtApellidoAgente = new System.Windows.Forms.TextBox();
            this.txtNombreAgente = new System.Windows.Forms.TextBox();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.labelDatosCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatosCorreoElectronica = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContraseñaDatosCliente = new System.Windows.Forms.TextBox();
            this.chbHabilitado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCelularAgente
            // 
            this.txtCelularAgente.Location = new System.Drawing.Point(145, 243);
            this.txtCelularAgente.Name = "txtCelularAgente";
            this.txtCelularAgente.Size = new System.Drawing.Size(137, 20);
            this.txtCelularAgente.TabIndex = 21;
            this.txtCelularAgente.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // txtEdadAgente
            // 
            this.txtEdadAgente.Location = new System.Drawing.Point(145, 198);
            this.txtEdadAgente.Name = "txtEdadAgente";
            this.txtEdadAgente.Size = new System.Drawing.Size(65, 20);
            this.txtEdadAgente.TabIndex = 20;
            // 
            // txtApellidoAgente
            // 
            this.txtApellidoAgente.Location = new System.Drawing.Point(145, 152);
            this.txtApellidoAgente.Name = "txtApellidoAgente";
            this.txtApellidoAgente.Size = new System.Drawing.Size(321, 20);
            this.txtApellidoAgente.TabIndex = 19;
            // 
            // txtNombreAgente
            // 
            this.txtNombreAgente.Location = new System.Drawing.Point(145, 113);
            this.txtNombreAgente.Name = "txtNombreAgente";
            this.txtNombreAgente.Size = new System.Drawing.Size(321, 20);
            this.txtNombreAgente.TabIndex = 18;
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-20, -7);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 25;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // labelDatosCliente
            // 
            this.labelDatosCliente.AutoSize = true;
            this.labelDatosCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDatosCliente.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDatosCliente.Location = new System.Drawing.Point(54, 22);
            this.labelDatosCliente.Name = "labelDatosCliente";
            this.labelDatosCliente.Size = new System.Drawing.Size(421, 79);
            this.labelDatosCliente.TabIndex = 26;
            this.labelDatosCliente.Text = "Datos del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Celular:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(552, 134);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(188, 54);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(552, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(188, 54);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Correo electronico:";
            // 
            // txtDatosCorreoElectronica
            // 
            this.txtDatosCorreoElectronica.Location = new System.Drawing.Point(244, 291);
            this.txtDatosCorreoElectronica.Name = "txtDatosCorreoElectronica";
            this.txtDatosCorreoElectronica.Size = new System.Drawing.Size(255, 20);
            this.txtDatosCorreoElectronica.TabIndex = 33;
            this.txtDatosCorreoElectronica.TextChanged += new System.EventHandler(this.txtDatosCorreoElectronica_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Contraseña:";
            // 
            // txtContraseñaDatosCliente
            // 
            this.txtContraseñaDatosCliente.Location = new System.Drawing.Point(171, 344);
            this.txtContraseñaDatosCliente.Name = "txtContraseñaDatosCliente";
            this.txtContraseñaDatosCliente.Size = new System.Drawing.Size(328, 20);
            this.txtContraseñaDatosCliente.TabIndex = 35;
            // 
            // chbHabilitado
            // 
            this.chbHabilitado.AutoSize = true;
            this.chbHabilitado.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHabilitado.Location = new System.Drawing.Point(46, 390);
            this.chbHabilitado.Name = "chbHabilitado";
            this.chbHabilitado.Size = new System.Drawing.Size(110, 22);
            this.chbHabilitado.TabIndex = 37;
            this.chbHabilitado.Text = "Habilitado";
            this.chbHabilitado.UseVisualStyleBackColor = true;
            // 
            // ModificarAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbHabilitado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContraseñaDatosCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatosCorreoElectronica);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDatosCliente);
            this.Controls.Add(this.txtCelularAgente);
            this.Controls.Add(this.txtEdadAgente);
            this.Controls.Add(this.txtApellidoAgente);
            this.Controls.Add(this.txtNombreAgente);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarAgente";
            this.Text = "ModificarAgente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCelularAgente;
        private System.Windows.Forms.TextBox txtEdadAgente;
        private System.Windows.Forms.TextBox txtApellidoAgente;
        private System.Windows.Forms.TextBox txtNombreAgente;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.Label labelDatosCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatosCorreoElectronica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContraseñaDatosCliente;
        private System.Windows.Forms.CheckBox chbHabilitado;
    }
}
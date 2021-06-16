
namespace ProyectoAltavista
{
    partial class ModificarInhabilitarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarInhabilitarCliente));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.chbHabilitar = new System.Windows.Forms.CheckBox();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.label1Bnaco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModifcar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(321, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(151, 169);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(321, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(151, 233);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(151, 297);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(193, 20);
            this.txtCelular.TabIndex = 8;
            // 
            // chbHabilitar
            // 
            this.chbHabilitar.AutoSize = true;
            this.chbHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHabilitar.Location = new System.Drawing.Point(151, 356);
            this.chbHabilitar.Name = "chbHabilitar";
            this.chbHabilitar.Size = new System.Drawing.Size(127, 29);
            this.chbHabilitar.TabIndex = 9;
            this.chbHabilitar.Text = "Habilitado";
            this.chbHabilitar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-20, -2);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 27;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // label1Bnaco
            // 
            this.label1Bnaco.AutoSize = true;
            this.label1Bnaco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1Bnaco.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Bnaco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1Bnaco.Location = new System.Drawing.Point(48, 7);
            this.label1Bnaco.Name = "label1Bnaco";
            this.label1Bnaco.Size = new System.Drawing.Size(421, 79);
            this.label1Bnaco.TabIndex = 28;
            this.label1Bnaco.Text = "Datos del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Edad:";
            // 
            // btnModifcar
            // 
            this.btnModifcar.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifcar.Location = new System.Drawing.Point(572, 98);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(160, 49);
            this.btnModifcar.TabIndex = 34;
            this.btnModifcar.Text = "Modificar";
            this.btnModifcar.UseVisualStyleBackColor = true;
            this.btnModifcar.Click += new System.EventHandler(this.btnModifcar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(571, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 49);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(571, 277);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(160, 49);
            this.btnRegresar.TabIndex = 36;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // ModificarInhabilitarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModifcar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1Bnaco);
            this.Controls.Add(this.chbHabilitar);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Name = "ModificarInhabilitarCliente";
            this.Text = "ModificarInhabilitarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.CheckBox chbHabilitar;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.Label label1Bnaco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModifcar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegresar;
    }
}
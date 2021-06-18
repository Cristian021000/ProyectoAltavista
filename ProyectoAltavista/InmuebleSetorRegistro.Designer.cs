
namespace ProyectoAltavista
{
    partial class InmuebleSetorRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InmuebleSetorRegistro));
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.lbNuevoSetor = new System.Windows.Forms.Label();
            this.IngreseCuidad = new System.Windows.Forms.Label();
            this.label1NombreDelSetor = new System.Windows.Forms.Label();
            this.btnAgregarSector = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.txtNombreSector = new System.Windows.Forms.TextBox();
            this.txtComentarioSector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(667, 371);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 57;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // lbNuevoSetor
            // 
            this.lbNuevoSetor.AutoSize = true;
            this.lbNuevoSetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbNuevoSetor.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevoSetor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNuevoSetor.Location = new System.Drawing.Point(138, 7);
            this.lbNuevoSetor.Name = "lbNuevoSetor";
            this.lbNuevoSetor.Size = new System.Drawing.Size(336, 79);
            this.lbNuevoSetor.TabIndex = 58;
            this.lbNuevoSetor.Text = "Nuevo Sector";
            // 
            // IngreseCuidad
            // 
            this.IngreseCuidad.AutoSize = true;
            this.IngreseCuidad.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseCuidad.Location = new System.Drawing.Point(8, 99);
            this.IngreseCuidad.Name = "IngreseCuidad";
            this.IngreseCuidad.Size = new System.Drawing.Size(126, 22);
            this.IngreseCuidad.TabIndex = 60;
            this.IngreseCuidad.Text = "Elija Ciudad";
            // 
            // label1NombreDelSetor
            // 
            this.label1NombreDelSetor.AutoSize = true;
            this.label1NombreDelSetor.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1NombreDelSetor.Location = new System.Drawing.Point(162, 99);
            this.label1NombreDelSetor.Name = "label1NombreDelSetor";
            this.label1NombreDelSetor.Size = new System.Drawing.Size(258, 22);
            this.label1NombreDelSetor.TabIndex = 62;
            this.label1NombreDelSetor.Text = "Ingrese Nombre Del Sector";
            // 
            // btnAgregarSector
            // 
            this.btnAgregarSector.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSector.Location = new System.Drawing.Point(472, 148);
            this.btnAgregarSector.Name = "btnAgregarSector";
            this.btnAgregarSector.Size = new System.Drawing.Size(168, 30);
            this.btnAgregarSector.TabIndex = 64;
            this.btnAgregarSector.Text = "Agregar Sector";
            this.btnAgregarSector.UseVisualStyleBackColor = true;
            this.btnAgregarSector.Click += new System.EventHandler(this.btnAgregarSector_Click);
            // 
            // Regresar
            // 
            this.Regresar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(472, 231);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(168, 30);
            this.Regresar.TabIndex = 65;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(12, 134);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCiudad.TabIndex = 67;
            // 
            // txtNombreSector
            // 
            this.txtNombreSector.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSector.Location = new System.Drawing.Point(166, 134);
            this.txtNombreSector.Multiline = true;
            this.txtNombreSector.Name = "txtNombreSector";
            this.txtNombreSector.Size = new System.Drawing.Size(272, 26);
            this.txtNombreSector.TabIndex = 63;
            // 
            // txtComentarioSector
            // 
            this.txtComentarioSector.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioSector.Location = new System.Drawing.Point(166, 231);
            this.txtComentarioSector.Multiline = true;
            this.txtComentarioSector.Name = "txtComentarioSector";
            this.txtComentarioSector.Size = new System.Drawing.Size(289, 26);
            this.txtComentarioSector.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Comentario Del Sector";
            // 
            // InmuebleSetorRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 286);
            this.Controls.Add(this.txtComentarioSector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCiudad);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnAgregarSector);
            this.Controls.Add(this.txtNombreSector);
            this.Controls.Add(this.label1NombreDelSetor);
            this.Controls.Add(this.IngreseCuidad);
            this.Controls.Add(this.lbNuevoSetor);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InmuebleSetorRegistro";
            this.Text = "InmuebleSetorRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.Label lbNuevoSetor;
        private System.Windows.Forms.Label IngreseCuidad;
        private System.Windows.Forms.Label label1NombreDelSetor;
        private System.Windows.Forms.Button btnAgregarSector;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.TextBox txtNombreSector;
        private System.Windows.Forms.TextBox txtComentarioSector;
        private System.Windows.Forms.Label label2;
    }
}
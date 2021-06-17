
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
            this.ElijaCuidad = new System.Windows.Forms.CheckedListBox();
            this.label1NombreDelSetor = new System.Windows.Forms.Label();
            this.textBox1INombreDeSector = new System.Windows.Forms.TextBox();
            this.btnAgregarSector = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
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
            this.IngreseCuidad.Location = new System.Drawing.Point(76, 105);
            this.IngreseCuidad.Name = "IngreseCuidad";
            this.IngreseCuidad.Size = new System.Drawing.Size(126, 22);
            this.IngreseCuidad.TabIndex = 60;
            this.IngreseCuidad.Text = "Elija Ciudad";
            // 
            // ElijaCuidad
            // 
            this.ElijaCuidad.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElijaCuidad.ForeColor = System.Drawing.Color.Black;
            this.ElijaCuidad.FormattingEnabled = true;
            this.ElijaCuidad.Items.AddRange(new object[] {
            "Trujillo ",
            "Cajamarca",
            "Arequipa",
            "Tacna",
            "Lima",
            "Cusco",
            "Iquitos",
            "Chimbote",
            "Piura",
            "Tumbes ",
            "Ica"});
            this.ElijaCuidad.Location = new System.Drawing.Point(89, 140);
            this.ElijaCuidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ElijaCuidad.Name = "ElijaCuidad";
            this.ElijaCuidad.Size = new System.Drawing.Size(93, 154);
            this.ElijaCuidad.TabIndex = 61;
            // 
            // label1NombreDelSetor
            // 
            this.label1NombreDelSetor.AutoSize = true;
            this.label1NombreDelSetor.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1NombreDelSetor.Location = new System.Drawing.Point(341, 105);
            this.label1NombreDelSetor.Name = "label1NombreDelSetor";
            this.label1NombreDelSetor.Size = new System.Drawing.Size(248, 22);
            this.label1NombreDelSetor.TabIndex = 62;
            this.label1NombreDelSetor.Text = "Ingrese Nombre Del Setor";
            // 
            // textBox1INombreDeSector
            // 
            this.textBox1INombreDeSector.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1INombreDeSector.Location = new System.Drawing.Point(345, 140);
            this.textBox1INombreDeSector.Multiline = true;
            this.textBox1INombreDeSector.Name = "textBox1INombreDeSector";
            this.textBox1INombreDeSector.Size = new System.Drawing.Size(229, 33);
            this.textBox1INombreDeSector.TabIndex = 63;
            // 
            // btnAgregarSector
            // 
            this.btnAgregarSector.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSector.Location = new System.Drawing.Point(235, 229);
            this.btnAgregarSector.Name = "btnAgregarSector";
            this.btnAgregarSector.Size = new System.Drawing.Size(168, 30);
            this.btnAgregarSector.TabIndex = 64;
            this.btnAgregarSector.Text = "Agregar Sector";
            this.btnAgregarSector.UseVisualStyleBackColor = true;
            // 
            // Regresar
            // 
            this.Regresar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(462, 229);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(168, 30);
            this.Regresar.TabIndex = 65;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(361, 301);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(127, 30);
            this.Salir.TabIndex = 66;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // InmuebleSetorRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 368);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnAgregarSector);
            this.Controls.Add(this.textBox1INombreDeSector);
            this.Controls.Add(this.label1NombreDelSetor);
            this.Controls.Add(this.ElijaCuidad);
            this.Controls.Add(this.IngreseCuidad);
            this.Controls.Add(this.lbNuevoSetor);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.CheckedListBox ElijaCuidad;
        private System.Windows.Forms.Label label1NombreDelSetor;
        private System.Windows.Forms.TextBox textBox1INombreDeSector;
        private System.Windows.Forms.Button btnAgregarSector;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button Salir;
    }
}
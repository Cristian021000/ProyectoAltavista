
namespace ProyectoAltavista
{
    partial class InmuebleMantenedorCasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InmuebleMantenedorCasa));
            this.Fondo = new System.Windows.Forms.PictureBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.RegistrarCasa = new System.Windows.Forms.Label();
            this.textBox1Direccion = new System.Windows.Forms.TextBox();
            this.label1Precio = new System.Windows.Forms.Label();
            this.PrecioMin = new System.Windows.Forms.Label();
            this.NumRegisPublicos = new System.Windows.Forms.Label();
            this.label1IdSector = new System.Windows.Forms.Label();
            this.labelIDPropietario = new System.Windows.Forms.Label();
            this.CantidadPisos = new System.Windows.Forms.Label();
            this.label1CantidadBaños = new System.Windows.Forms.Label();
            this.label1CantidadHabitaciones = new System.Windows.Forms.Label();
            this.textBox1Precio = new System.Windows.Forms.TextBox();
            this.textBox1PrecioMin = new System.Windows.Forms.TextBox();
            this.textBox1RegistrosPublios = new System.Windows.Forms.TextBox();
            this.textBox1IDSetor = new System.Windows.Forms.TextBox();
            this.textBox1IDPropietario = new System.Windows.Forms.TextBox();
            this.textBox1CantidadPisos = new System.Windows.Forms.TextBox();
            this.textBox1CantidadBaños = new System.Windows.Forms.TextBox();
            this.textBox1CantidadHabitaciones = new System.Windows.Forms.TextBox();
            this.AceptarRegisCasa = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.chbPiscina = new System.Windows.Forms.CheckBox();
            this.chbJardin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtAream2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.Transparent;
            this.Fondo.Image = ((System.Drawing.Image)(resources.GetObject("Fondo.Image")));
            this.Fondo.Location = new System.Drawing.Point(-2, -8);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(592, 787);
            this.Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fondo.TabIndex = 25;
            this.Fondo.TabStop = false;
            this.Fondo.Click += new System.EventHandler(this.Fondo_Click);
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(44, 105);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(105, 22);
            this.Direccion.TabIndex = 48;
            this.Direccion.Text = "Direccion:";
            // 
            // RegistrarCasa
            // 
            this.RegistrarCasa.AutoSize = true;
            this.RegistrarCasa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RegistrarCasa.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarCasa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegistrarCasa.Location = new System.Drawing.Point(134, 7);
            this.RegistrarCasa.Name = "RegistrarCasa";
            this.RegistrarCasa.Size = new System.Drawing.Size(361, 79);
            this.RegistrarCasa.TabIndex = 49;
            this.RegistrarCasa.Text = "Registrar Casa";
            // 
            // textBox1Direccion
            // 
            this.textBox1Direccion.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Direccion.Location = new System.Drawing.Point(150, 102);
            this.textBox1Direccion.Multiline = true;
            this.textBox1Direccion.Name = "textBox1Direccion";
            this.textBox1Direccion.Size = new System.Drawing.Size(351, 25);
            this.textBox1Direccion.TabIndex = 50;
            // 
            // label1Precio
            // 
            this.label1Precio.AutoSize = true;
            this.label1Precio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Precio.Location = new System.Drawing.Point(44, 145);
            this.label1Precio.Name = "label1Precio";
            this.label1Precio.Size = new System.Drawing.Size(73, 22);
            this.label1Precio.TabIndex = 51;
            this.label1Precio.Text = "Precio:";
            // 
            // PrecioMin
            // 
            this.PrecioMin.AutoSize = true;
            this.PrecioMin.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioMin.Location = new System.Drawing.Point(43, 188);
            this.PrecioMin.Name = "PrecioMin";
            this.PrecioMin.Size = new System.Drawing.Size(148, 22);
            this.PrecioMin.TabIndex = 52;
            this.PrecioMin.Text = "Precio Minimo:";
            // 
            // NumRegisPublicos
            // 
            this.NumRegisPublicos.AutoSize = true;
            this.NumRegisPublicos.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumRegisPublicos.Location = new System.Drawing.Point(44, 234);
            this.NumRegisPublicos.Name = "NumRegisPublicos";
            this.NumRegisPublicos.Size = new System.Drawing.Size(293, 22);
            this.NumRegisPublicos.TabIndex = 53;
            this.NumRegisPublicos.Text = "Numero de Registros Publicos:";
            // 
            // label1IdSector
            // 
            this.label1IdSector.AutoSize = true;
            this.label1IdSector.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1IdSector.Location = new System.Drawing.Point(43, 278);
            this.label1IdSector.Name = "label1IdSector";
            this.label1IdSector.Size = new System.Drawing.Size(100, 22);
            this.label1IdSector.TabIndex = 54;
            this.label1IdSector.Text = "ID Sector:";
            // 
            // labelIDPropietario
            // 
            this.labelIDPropietario.AutoSize = true;
            this.labelIDPropietario.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDPropietario.Location = new System.Drawing.Point(44, 321);
            this.labelIDPropietario.Name = "labelIDPropietario";
            this.labelIDPropietario.Size = new System.Drawing.Size(147, 22);
            this.labelIDPropietario.TabIndex = 55;
            this.labelIDPropietario.Text = "ID Propietario:";
            // 
            // CantidadPisos
            // 
            this.CantidadPisos.AutoSize = true;
            this.CantidadPisos.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadPisos.Location = new System.Drawing.Point(43, 362);
            this.CantidadPisos.Name = "CantidadPisos";
            this.CantidadPisos.Size = new System.Drawing.Size(155, 22);
            this.CantidadPisos.TabIndex = 56;
            this.CantidadPisos.Text = "Cantidad Pisos:";
            // 
            // label1CantidadBaños
            // 
            this.label1CantidadBaños.AutoSize = true;
            this.label1CantidadBaños.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CantidadBaños.Location = new System.Drawing.Point(44, 397);
            this.label1CantidadBaños.Name = "label1CantidadBaños";
            this.label1CantidadBaños.Size = new System.Drawing.Size(164, 22);
            this.label1CantidadBaños.TabIndex = 57;
            this.label1CantidadBaños.Text = "Cantidad Baños:";
            // 
            // label1CantidadHabitaciones
            // 
            this.label1CantidadHabitaciones.AutoSize = true;
            this.label1CantidadHabitaciones.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CantidadHabitaciones.Location = new System.Drawing.Point(44, 442);
            this.label1CantidadHabitaciones.Name = "label1CantidadHabitaciones";
            this.label1CantidadHabitaciones.Size = new System.Drawing.Size(258, 22);
            this.label1CantidadHabitaciones.TabIndex = 58;
            this.label1CantidadHabitaciones.Text = "Cantidad De Habilationes:";
            // 
            // textBox1Precio
            // 
            this.textBox1Precio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Precio.Location = new System.Drawing.Point(151, 142);
            this.textBox1Precio.Multiline = true;
            this.textBox1Precio.Name = "textBox1Precio";
            this.textBox1Precio.Size = new System.Drawing.Size(351, 34);
            this.textBox1Precio.TabIndex = 61;
            // 
            // textBox1PrecioMin
            // 
            this.textBox1PrecioMin.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1PrecioMin.Location = new System.Drawing.Point(198, 188);
            this.textBox1PrecioMin.Multiline = true;
            this.textBox1PrecioMin.Name = "textBox1PrecioMin";
            this.textBox1PrecioMin.Size = new System.Drawing.Size(308, 34);
            this.textBox1PrecioMin.TabIndex = 62;
            // 
            // textBox1RegistrosPublios
            // 
            this.textBox1RegistrosPublios.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1RegistrosPublios.Location = new System.Drawing.Point(344, 234);
            this.textBox1RegistrosPublios.Multiline = true;
            this.textBox1RegistrosPublios.Name = "textBox1RegistrosPublios";
            this.textBox1RegistrosPublios.Size = new System.Drawing.Size(174, 33);
            this.textBox1RegistrosPublios.TabIndex = 63;
            // 
            // textBox1IDSetor
            // 
            this.textBox1IDSetor.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1IDSetor.Location = new System.Drawing.Point(151, 278);
            this.textBox1IDSetor.Multiline = true;
            this.textBox1IDSetor.Name = "textBox1IDSetor";
            this.textBox1IDSetor.Size = new System.Drawing.Size(351, 25);
            this.textBox1IDSetor.TabIndex = 64;
            // 
            // textBox1IDPropietario
            // 
            this.textBox1IDPropietario.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1IDPropietario.Location = new System.Drawing.Point(201, 321);
            this.textBox1IDPropietario.Multiline = true;
            this.textBox1IDPropietario.Name = "textBox1IDPropietario";
            this.textBox1IDPropietario.Size = new System.Drawing.Size(308, 22);
            this.textBox1IDPropietario.TabIndex = 65;
            // 
            // textBox1CantidadPisos
            // 
            this.textBox1CantidadPisos.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1CantidadPisos.Location = new System.Drawing.Point(214, 362);
            this.textBox1CantidadPisos.Multiline = true;
            this.textBox1CantidadPisos.Name = "textBox1CantidadPisos";
            this.textBox1CantidadPisos.Size = new System.Drawing.Size(308, 22);
            this.textBox1CantidadPisos.TabIndex = 66;
            // 
            // textBox1CantidadBaños
            // 
            this.textBox1CantidadBaños.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1CantidadBaños.Location = new System.Drawing.Point(223, 397);
            this.textBox1CantidadBaños.Multiline = true;
            this.textBox1CantidadBaños.Name = "textBox1CantidadBaños";
            this.textBox1CantidadBaños.Size = new System.Drawing.Size(295, 24);
            this.textBox1CantidadBaños.TabIndex = 67;
            // 
            // textBox1CantidadHabitaciones
            // 
            this.textBox1CantidadHabitaciones.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1CantidadHabitaciones.Location = new System.Drawing.Point(311, 442);
            this.textBox1CantidadHabitaciones.Multiline = true;
            this.textBox1CantidadHabitaciones.Name = "textBox1CantidadHabitaciones";
            this.textBox1CantidadHabitaciones.Size = new System.Drawing.Size(207, 22);
            this.textBox1CantidadHabitaciones.TabIndex = 68;
            // 
            // AceptarRegisCasa
            // 
            this.AceptarRegisCasa.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarRegisCasa.Location = new System.Drawing.Point(48, 678);
            this.AceptarRegisCasa.Name = "AceptarRegisCasa";
            this.AceptarRegisCasa.Size = new System.Drawing.Size(173, 50);
            this.AceptarRegisCasa.TabIndex = 71;
            this.AceptarRegisCasa.Text = "Aceptar";
            this.AceptarRegisCasa.UseVisualStyleBackColor = true;
            this.AceptarRegisCasa.Click += new System.EventHandler(this.AceptarRegisCasa_Click);
            // 
            // Regresar
            // 
            this.Regresar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(344, 678);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(173, 50);
            this.Regresar.TabIndex = 72;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // chbPiscina
            // 
            this.chbPiscina.AutoSize = true;
            this.chbPiscina.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPiscina.Location = new System.Drawing.Point(48, 623);
            this.chbPiscina.Name = "chbPiscina";
            this.chbPiscina.Size = new System.Drawing.Size(95, 26);
            this.chbPiscina.TabIndex = 73;
            this.chbPiscina.Text = "Piscina";
            this.chbPiscina.UseVisualStyleBackColor = true;
            // 
            // chbJardin
            // 
            this.chbJardin.AutoSize = true;
            this.chbJardin.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbJardin.Location = new System.Drawing.Point(48, 575);
            this.chbJardin.Name = "chbJardin";
            this.chbJardin.Size = new System.Drawing.Size(88, 26);
            this.chbJardin.TabIndex = 74;
            this.chbJardin.Text = "Jardin";
            this.chbJardin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 22);
            this.label1.TabIndex = 75;
            this.label1.Text = "Fecha de contrucción:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(270, 533);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(236, 20);
            this.dtpFecha.TabIndex = 76;
            // 
            // txtAream2
            // 
            this.txtAream2.Location = new System.Drawing.Point(119, 488);
            this.txtAream2.Name = "txtAream2";
            this.txtAream2.Size = new System.Drawing.Size(160, 20);
            this.txtAream2.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 78;
            this.label2.Text = "Area";
            // 
            // InmuebleMantenedorCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAream2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbJardin);
            this.Controls.Add(this.chbPiscina);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.AceptarRegisCasa);
            this.Controls.Add(this.textBox1CantidadHabitaciones);
            this.Controls.Add(this.textBox1CantidadBaños);
            this.Controls.Add(this.textBox1CantidadPisos);
            this.Controls.Add(this.textBox1IDPropietario);
            this.Controls.Add(this.textBox1IDSetor);
            this.Controls.Add(this.textBox1RegistrosPublios);
            this.Controls.Add(this.textBox1PrecioMin);
            this.Controls.Add(this.textBox1Precio);
            this.Controls.Add(this.label1CantidadHabitaciones);
            this.Controls.Add(this.label1CantidadBaños);
            this.Controls.Add(this.CantidadPisos);
            this.Controls.Add(this.labelIDPropietario);
            this.Controls.Add(this.label1IdSector);
            this.Controls.Add(this.NumRegisPublicos);
            this.Controls.Add(this.PrecioMin);
            this.Controls.Add(this.label1Precio);
            this.Controls.Add(this.textBox1Direccion);
            this.Controls.Add(this.RegistrarCasa);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InmuebleMantenedorCasa";
            this.Text = "InmuebleMantenedorCasa";
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fondo;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label RegistrarCasa;
        private System.Windows.Forms.TextBox textBox1Direccion;
        private System.Windows.Forms.Label label1Precio;
        private System.Windows.Forms.Label PrecioMin;
        private System.Windows.Forms.Label NumRegisPublicos;
        private System.Windows.Forms.Label label1IdSector;
        private System.Windows.Forms.Label labelIDPropietario;
        private System.Windows.Forms.Label CantidadPisos;
        private System.Windows.Forms.Label label1CantidadBaños;
        private System.Windows.Forms.Label label1CantidadHabitaciones;
        private System.Windows.Forms.TextBox textBox1Precio;
        private System.Windows.Forms.TextBox textBox1PrecioMin;
        private System.Windows.Forms.TextBox textBox1RegistrosPublios;
        private System.Windows.Forms.TextBox textBox1IDSetor;
        private System.Windows.Forms.TextBox textBox1IDPropietario;
        private System.Windows.Forms.TextBox textBox1CantidadPisos;
        private System.Windows.Forms.TextBox textBox1CantidadBaños;
        private System.Windows.Forms.TextBox textBox1CantidadHabitaciones;
        private System.Windows.Forms.Button AceptarRegisCasa;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.CheckBox chbPiscina;
        private System.Windows.Forms.CheckBox chbJardin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtAream2;
        private System.Windows.Forms.Label label2;
    }
}
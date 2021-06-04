
namespace ProyectoAltavista
{
    partial class MantenedorDeInmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorDeInmueble));
            this.Fondo = new System.Windows.Forms.PictureBox();
            this.RegistrarInmueble = new System.Windows.Forms.Label();
            this.IngreseTipoDeInmueble = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.AceptarRegisInmueble = new System.Windows.Forms.Button();
            this.btRegresarInmueble = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.Transparent;
            this.Fondo.Image = ((System.Drawing.Image)(resources.GetObject("Fondo.Image")));
            this.Fondo.Location = new System.Drawing.Point(-2, -2);
            this.Fondo.Margin = new System.Windows.Forms.Padding(4);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(805, 455);
            this.Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fondo.TabIndex = 24;
            this.Fondo.TabStop = false;
            // 
            // RegistrarInmueble
            // 
            this.RegistrarInmueble.AutoSize = true;
            this.RegistrarInmueble.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RegistrarInmueble.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarInmueble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegistrarInmueble.Location = new System.Drawing.Point(107, 21);
            this.RegistrarInmueble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegistrarInmueble.Name = "RegistrarInmueble";
            this.RegistrarInmueble.Size = new System.Drawing.Size(581, 97);
            this.RegistrarInmueble.TabIndex = 46;
            this.RegistrarInmueble.Text = "Registrar Inmueble";
            // 
            // IngreseTipoDeInmueble
            // 
            this.IngreseTipoDeInmueble.AutoSize = true;
            this.IngreseTipoDeInmueble.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseTipoDeInmueble.Location = new System.Drawing.Point(78, 172);
            this.IngreseTipoDeInmueble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IngreseTipoDeInmueble.Name = "IngreseTipoDeInmueble";
            this.IngreseTipoDeInmueble.Size = new System.Drawing.Size(319, 27);
            this.IngreseTipoDeInmueble.TabIndex = 47;
            this.IngreseTipoDeInmueble.Text = "Ingrese Tipo De Inmueble";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Casa.",
            "Departamento.",
            "Terreno."});
            this.checkedListBox1.Location = new System.Drawing.Point(124, 227);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(171, 73);
            this.checkedListBox1.TabIndex = 48;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // AceptarRegisInmueble
            // 
            this.AceptarRegisInmueble.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarRegisInmueble.Location = new System.Drawing.Point(507, 172);
            this.AceptarRegisInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.AceptarRegisInmueble.Name = "AceptarRegisInmueble";
            this.AceptarRegisInmueble.Size = new System.Drawing.Size(231, 62);
            this.AceptarRegisInmueble.TabIndex = 53;
            this.AceptarRegisInmueble.Text = "Aceptar";
            this.AceptarRegisInmueble.UseVisualStyleBackColor = true;
            // 
            // btRegresarInmueble
            // 
            this.btRegresarInmueble.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresarInmueble.Location = new System.Drawing.Point(507, 319);
            this.btRegresarInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.btRegresarInmueble.Name = "btRegresarInmueble";
            this.btRegresarInmueble.Size = new System.Drawing.Size(231, 62);
            this.btRegresarInmueble.TabIndex = 54;
            this.btRegresarInmueble.Text = "Regresar";
            this.btRegresarInmueble.UseVisualStyleBackColor = true;
            // 
            // MantenedorDeInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegresarInmueble);
            this.Controls.Add(this.AceptarRegisInmueble);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.IngreseTipoDeInmueble);
            this.Controls.Add(this.RegistrarInmueble);
            this.Controls.Add(this.Fondo);
            this.Name = "MantenedorDeInmueble";
            this.Text = "MantenedorDeInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fondo;
        private System.Windows.Forms.Label RegistrarInmueble;
        private System.Windows.Forms.Label IngreseTipoDeInmueble;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button AceptarRegisInmueble;
        private System.Windows.Forms.Button btRegresarInmueble;
    }
}
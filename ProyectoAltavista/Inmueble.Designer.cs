
namespace ProyectoAltavista
{
    partial class Inmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inmueble));
            this.Fondo = new System.Windows.Forms.PictureBox();
            this.lbInmueble = new System.Windows.Forms.Label();
            this.btRegistrarInmueble = new System.Windows.Forms.Button();
            this.MostrarInmueble = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.Transparent;
            this.Fondo.Image = ((System.Drawing.Image)(resources.GetObject("Fondo.Image")));
            this.Fondo.Location = new System.Drawing.Point(1, -2);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(770, 446);
            this.Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fondo.TabIndex = 23;
            this.Fondo.TabStop = false;
            // 
            // lbInmueble
            // 
            this.lbInmueble.AutoSize = true;
            this.lbInmueble.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbInmueble.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInmueble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbInmueble.Location = new System.Drawing.Point(235, 21);
            this.lbInmueble.Name = "lbInmueble";
            this.lbInmueble.Size = new System.Drawing.Size(242, 79);
            this.lbInmueble.TabIndex = 45;
            this.lbInmueble.Text = "Inmueble";
            // 
            // btRegistrarInmueble
            // 
            this.btRegistrarInmueble.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarInmueble.Location = new System.Drawing.Point(12, 139);
            this.btRegistrarInmueble.Name = "btRegistrarInmueble";
            this.btRegistrarInmueble.Size = new System.Drawing.Size(254, 78);
            this.btRegistrarInmueble.TabIndex = 49;
            this.btRegistrarInmueble.Text = "Registrar Inmueble";
            this.btRegistrarInmueble.UseVisualStyleBackColor = true;
            this.btRegistrarInmueble.Click += new System.EventHandler(this.btRegistrarInmueble_Click);
            // 
            // MostrarInmueble
            // 
            this.MostrarInmueble.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarInmueble.Location = new System.Drawing.Point(439, 139);
            this.MostrarInmueble.Name = "MostrarInmueble";
            this.MostrarInmueble.Size = new System.Drawing.Size(275, 78);
            this.MostrarInmueble.TabIndex = 51;
            this.MostrarInmueble.Text = "Consultar";
            this.MostrarInmueble.UseVisualStyleBackColor = true;
            this.MostrarInmueble.Click += new System.EventHandler(this.MostrarInmueble_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(263, 297);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(173, 50);
            this.btRegresar.TabIndex = 52;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // Inmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 408);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.MostrarInmueble);
            this.Controls.Add(this.btRegistrarInmueble);
            this.Controls.Add(this.lbInmueble);
            this.Controls.Add(this.Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inmueble";
            this.Text = "Inmueble";
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fondo;
        private System.Windows.Forms.Label lbInmueble;
        private System.Windows.Forms.Button btRegistrarInmueble;
        private System.Windows.Forms.Button MostrarInmueble;
        private System.Windows.Forms.Button btRegresar;
    }
}

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
            this.BucarInmueble = new System.Windows.Forms.Button();
            this.MostrarInmueble = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.Transparent;
            this.Fondo.Image = ((System.Drawing.Image)(resources.GetObject("Fondo.Image")));
            this.Fondo.Location = new System.Drawing.Point(1, -3);
            this.Fondo.Margin = new System.Windows.Forms.Padding(4);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(805, 455);
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
            this.lbInmueble.Location = new System.Drawing.Point(240, 21);
            this.lbInmueble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInmueble.Name = "lbInmueble";
            this.lbInmueble.Size = new System.Drawing.Size(303, 97);
            this.lbInmueble.TabIndex = 45;
            this.lbInmueble.Text = "Inmueble";
            // 
            // btRegistrarInmueble
            // 
            this.btRegistrarInmueble.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarInmueble.Location = new System.Drawing.Point(26, 156);
            this.btRegistrarInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.btRegistrarInmueble.Name = "btRegistrarInmueble";
            this.btRegistrarInmueble.Size = new System.Drawing.Size(339, 96);
            this.btRegistrarInmueble.TabIndex = 49;
            this.btRegistrarInmueble.Text = "Registrar Inmueble";
            this.btRegistrarInmueble.UseVisualStyleBackColor = true;
            // 
            // BucarInmueble
            // 
            this.BucarInmueble.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BucarInmueble.Location = new System.Drawing.Point(435, 156);
            this.BucarInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.BucarInmueble.Name = "BucarInmueble";
            this.BucarInmueble.Size = new System.Drawing.Size(339, 96);
            this.BucarInmueble.TabIndex = 50;
            this.BucarInmueble.Text = "Buscar Inmueble";
            this.BucarInmueble.UseVisualStyleBackColor = true;
            // 
            // MostrarInmueble
            // 
            this.MostrarInmueble.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarInmueble.Location = new System.Drawing.Point(26, 292);
            this.MostrarInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.MostrarInmueble.Name = "MostrarInmueble";
            this.MostrarInmueble.Size = new System.Drawing.Size(339, 96);
            this.MostrarInmueble.TabIndex = 51;
            this.MostrarInmueble.Text = "MostrarInmueble";
            this.MostrarInmueble.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(513, 326);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(231, 62);
            this.btRegresar.TabIndex = 52;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // Inmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.MostrarInmueble);
            this.Controls.Add(this.BucarInmueble);
            this.Controls.Add(this.btRegistrarInmueble);
            this.Controls.Add(this.lbInmueble);
            this.Controls.Add(this.Fondo);
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
        private System.Windows.Forms.Button BucarInmueble;
        private System.Windows.Forms.Button MostrarInmueble;
        private System.Windows.Forms.Button btRegresar;
    }
}
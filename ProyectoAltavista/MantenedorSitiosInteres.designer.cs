
namespace ProyectoAltavista
{
    partial class MantenedorSitiosInteres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorSitiosInteres));
            this.btRegistrarSitio = new System.Windows.Forms.Button();
            this.btModificarSitio = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbSitioInteres = new System.Windows.Forms.Label();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegistrarSitio
            // 
            this.btRegistrarSitio.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarSitio.Location = new System.Drawing.Point(45, 171);
            this.btRegistrarSitio.Name = "btRegistrarSitio";
            this.btRegistrarSitio.Size = new System.Drawing.Size(250, 77);
            this.btRegistrarSitio.TabIndex = 58;
            this.btRegistrarSitio.Text = "Registrar Sitio de interés";
            this.btRegistrarSitio.UseVisualStyleBackColor = true;
            this.btRegistrarSitio.Click += new System.EventHandler(this.btRegistrarSitio_Click);
            // 
            // btModificarSitio
            // 
            this.btModificarSitio.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificarSitio.Location = new System.Drawing.Point(460, 171);
            this.btModificarSitio.Name = "btModificarSitio";
            this.btModificarSitio.Size = new System.Drawing.Size(272, 77);
            this.btModificarSitio.TabIndex = 57;
            this.btModificarSitio.Text = "Modificar Sitio de interés";
            this.btModificarSitio.UseVisualStyleBackColor = true;
            this.btModificarSitio.Click += new System.EventHandler(this.btModificarSitio_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(261, 318);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(173, 50);
            this.btRegresar.TabIndex = 56;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // lbSitioInteres
            // 
            this.lbSitioInteres.AutoSize = true;
            this.lbSitioInteres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbSitioInteres.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSitioInteres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSitioInteres.Location = new System.Drawing.Point(210, 33);
            this.lbSitioInteres.Name = "lbSitioInteres";
            this.lbSitioInteres.Size = new System.Drawing.Size(373, 79);
            this.lbSitioInteres.TabIndex = 54;
            this.lbSitioInteres.Text = "Sitio de Interés";
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-20, -7);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 55;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // MantenedorSitiosInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegistrarSitio);
            this.Controls.Add(this.btModificarSitio);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbSitioInteres);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Name = "MantenedorSitiosInteres";
            this.Text = "MantenedorSitiosInteres";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegistrarSitio;
        private System.Windows.Forms.Button btModificarSitio;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbSitioInteres;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
    }
}
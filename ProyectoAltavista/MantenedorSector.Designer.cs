
namespace ProyectoAltavista
{
    partial class MantenedorSector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorSector));
            this.lbRegistrar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbSector = new System.Windows.Forms.Label();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRegistrar
            // 
            this.lbRegistrar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrar.Location = new System.Drawing.Point(20, 176);
            this.lbRegistrar.Name = "lbRegistrar";
            this.lbRegistrar.Size = new System.Drawing.Size(254, 50);
            this.lbRegistrar.TabIndex = 53;
            this.lbRegistrar.Text = "Registrar Sector";
            this.lbRegistrar.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            this.btModificar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(474, 176);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(272, 50);
            this.btModificar.TabIndex = 52;
            this.btModificar.Text = "Modificar Sector";
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(274, 324);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(173, 50);
            this.btRegresar.TabIndex = 51;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // lbSector
            // 
            this.lbSector.AutoSize = true;
            this.lbSector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbSector.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSector.Location = new System.Drawing.Point(299, 44);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(172, 79);
            this.lbSector.TabIndex = 49;
            this.lbSector.Text = "Sector";
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-6, -2);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 50;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // MantenedorSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbRegistrar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbSector);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Name = "MantenedorSector";
            this.Text = "Sector";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbRegistrar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbSector;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
    }
}
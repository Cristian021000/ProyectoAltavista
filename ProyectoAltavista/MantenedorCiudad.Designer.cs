
namespace ProyectoAltavista
{
    partial class MantenedorCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorCiudad));
            this.btRegistrarCiudad = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.btListarCiudad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegistrarCiudad
            // 
            this.btRegistrarCiudad.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarCiudad.Location = new System.Drawing.Point(69, 226);
            this.btRegistrarCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegistrarCiudad.Name = "btRegistrarCiudad";
            this.btRegistrarCiudad.Size = new System.Drawing.Size(363, 62);
            this.btRegistrarCiudad.TabIndex = 52;
            this.btRegistrarCiudad.Text = "Registrar Ciudad";
            this.btRegistrarCiudad.UseVisualStyleBackColor = true;
            this.btRegistrarCiudad.Click += new System.EventHandler(this.btRegistrarCiudad_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(402, 428);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(231, 62);
            this.btRegresar.TabIndex = 51;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMenu.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMenu.Location = new System.Drawing.Point(399, 54);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(210, 97);
            this.lbMenu.TabIndex = 49;
            this.lbMenu.Text = "Menu";
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-27, -9);
            this.pictureBox1Fondo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(1119, 572);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 50;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // btListarCiudad
            // 
            this.btListarCiudad.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarCiudad.Location = new System.Drawing.Point(624, 226);
            this.btListarCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btListarCiudad.Name = "btListarCiudad";
            this.btListarCiudad.Size = new System.Drawing.Size(363, 62);
            this.btListarCiudad.TabIndex = 53;
            this.btListarCiudad.Text = "Listar Ciudad";
            this.btListarCiudad.UseVisualStyleBackColor = true;
            // 
            // MantenedorCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btListarCiudad);
            this.Controls.Add(this.btRegistrarCiudad);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenedorCiudad";
            this.Text = "MantenedorCiudad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRegistrarCiudad;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.Button btListarCiudad;
    }
}
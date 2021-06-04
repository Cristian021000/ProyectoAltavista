
namespace ProyectoAltavista
{
    partial class MantenedorAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorAgente));
            this.lbMenu = new System.Windows.Forms.Label();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.btRegresar = new System.Windows.Forms.Button();
            this.btModificarAgente = new System.Windows.Forms.Button();
            this.btRegistrarAgente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMenu.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMenu.Location = new System.Drawing.Point(314, 42);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(168, 79);
            this.lbMenu.TabIndex = 44;
            this.lbMenu.Text = "Menu";
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-4, -9);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 45;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(290, 323);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(173, 50);
            this.btRegresar.TabIndex = 46;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.bt2_Click);
            // 
            // btModificarAgente
            // 
            this.btModificarAgente.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificarAgente.Location = new System.Drawing.Point(489, 175);
            this.btModificarAgente.Name = "btModificarAgente";
            this.btModificarAgente.Size = new System.Drawing.Size(272, 50);
            this.btModificarAgente.TabIndex = 47;
            this.btModificarAgente.Text = "Modificar Agente";
            this.btModificarAgente.UseVisualStyleBackColor = true;
            // 
            // btRegistrarAgente
            // 
            this.btRegistrarAgente.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarAgente.Location = new System.Drawing.Point(35, 175);
            this.btRegistrarAgente.Name = "btRegistrarAgente";
            this.btRegistrarAgente.Size = new System.Drawing.Size(254, 50);
            this.btRegistrarAgente.TabIndex = 48;
            this.btRegistrarAgente.Text = "Registrar Agente";
            this.btRegistrarAgente.UseVisualStyleBackColor = true;
            // 
            // MantenedorAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegistrarAgente);
            this.Controls.Add(this.btModificarAgente);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenedorAgente";
            this.Text = "MantenedorAgente";
            this.Load += new System.EventHandler(this.MantenedorAgente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btModificarAgente;
        private System.Windows.Forms.Button btRegistrarAgente;
    }
}
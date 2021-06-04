
namespace ProyectoAltavista
{
    partial class MantenedorCliPropietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorCliPropietario));
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btLista = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(36, 176);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(254, 50);
            this.btRegistrar.TabIndex = 58;
            this.btRegistrar.Text = "Registrar ";
            this.btRegistrar.UseVisualStyleBackColor = true;
            // 
            // btLista
            // 
            this.btLista.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLista.Location = new System.Drawing.Point(474, 176);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(272, 50);
            this.btLista.TabIndex = 57;
            this.btLista.Text = "Lista";
            this.btLista.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(274, 324);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(173, 50);
            this.btRegresar.TabIndex = 56;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMenu.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMenu.Location = new System.Drawing.Point(299, 44);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(168, 79);
            this.lbMenu.TabIndex = 54;
            this.lbMenu.Text = "Menu";
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
            // MantenedorCliPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Name = "MantenedorCliPropietario";
            this.Text = "MantenedorCliPropietario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
    }
}
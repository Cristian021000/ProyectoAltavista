
namespace ProyectoAltavista
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbElejirCiudadNuevoSector = new System.Windows.Forms.ComboBox();
            this.txtNombreDelNuevoSector = new System.Windows.Forms.TextBox();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.labelNuevoSector = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbElejirCiudadNuevoSector
            // 
            this.cbElejirCiudadNuevoSector.FormattingEnabled = true;
            this.cbElejirCiudadNuevoSector.Location = new System.Drawing.Point(28, 148);
            this.cbElejirCiudadNuevoSector.Name = "cbElejirCiudadNuevoSector";
            this.cbElejirCiudadNuevoSector.Size = new System.Drawing.Size(280, 21);
            this.cbElejirCiudadNuevoSector.TabIndex = 2;
            // 
            // txtNombreDelNuevoSector
            // 
            this.txtNombreDelNuevoSector.Location = new System.Drawing.Point(28, 240);
            this.txtNombreDelNuevoSector.Name = "txtNombreDelNuevoSector";
            this.txtNombreDelNuevoSector.Size = new System.Drawing.Size(359, 20);
            this.txtNombreDelNuevoSector.TabIndex = 3;
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-20, -7);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 22;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // labelNuevoSector
            // 
            this.labelNuevoSector.AutoSize = true;
            this.labelNuevoSector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelNuevoSector.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoSector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNuevoSector.Location = new System.Drawing.Point(280, 7);
            this.labelNuevoSector.Name = "labelNuevoSector";
            this.labelNuevoSector.Size = new System.Drawing.Size(336, 79);
            this.labelNuevoSector.TabIndex = 23;
            this.labelNuevoSector.Text = "Nuevo Sector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Elija la Cuidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ingrese Nombre del Sector";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(416, 400);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(168, 30);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(615, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 30);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNuevoSector);
            this.Controls.Add(this.txtNombreDelNuevoSector);
            this.Controls.Add(this.cbElejirCiudadNuevoSector);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Name = "Form1";
            this.Text = "Altavista";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbElejirCiudadNuevoSector;
        private System.Windows.Forms.TextBox txtNombreDelNuevoSector;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.Label labelNuevoSector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
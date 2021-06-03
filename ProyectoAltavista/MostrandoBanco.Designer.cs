
namespace ProyectoAltavista
{
    partial class MostrandoBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrandoBanco));
            this.bt2RegistarBanco = new System.Windows.Forms.Button();
            this.bt2Agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1NombreBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1IngresoBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.label1Bnaco = new System.Windows.Forms.Label();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // bt2RegistarBanco
            // 
            this.bt2RegistarBanco.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2RegistarBanco.Location = new System.Drawing.Point(59, 306);
            this.bt2RegistarBanco.Name = "bt2RegistarBanco";
            this.bt2RegistarBanco.Size = new System.Drawing.Size(168, 30);
            this.bt2RegistarBanco.TabIndex = 31;
            this.bt2RegistarBanco.Text = "Guardar";
            this.bt2RegistarBanco.UseVisualStyleBackColor = true;
            // 
            // bt2Agregar
            // 
            this.bt2Agregar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2Agregar.Location = new System.Drawing.Point(59, 251);
            this.bt2Agregar.Name = "bt2Agregar";
            this.bt2Agregar.Size = new System.Drawing.Size(240, 30);
            this.bt2Agregar.TabIndex = 30;
            this.bt2Agregar.Text = "Modificar Nombre Banco";
            this.bt2Agregar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(508, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Datos del Banco";
            // 
            // textBox1NombreBanco
            // 
            this.textBox1NombreBanco.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1NombreBanco.Location = new System.Drawing.Point(28, 190);
            this.textBox1NombreBanco.Multiline = true;
            this.textBox1NombreBanco.Name = "textBox1NombreBanco";
            this.textBox1NombreBanco.Size = new System.Drawing.Size(308, 33);
            this.textBox1NombreBanco.TabIndex = 27;
            this.textBox1NombreBanco.TextChanged += new System.EventHandler(this.textBox1NombreBanco_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ingrese Nuevo Nombre de Banco";
            // 
            // textBox1IngresoBanco
            // 
            this.textBox1IngresoBanco.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1IngresoBanco.Location = new System.Drawing.Point(59, 107);
            this.textBox1IngresoBanco.Multiline = true;
            this.textBox1IngresoBanco.Name = "textBox1IngresoBanco";
            this.textBox1IngresoBanco.Size = new System.Drawing.Size(224, 33);
            this.textBox1IngresoBanco.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ingrese Codigo e Banco";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 303);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(59, 365);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(92, 34);
            this.btSalir.TabIndex = 22;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            // 
            // label1Bnaco
            // 
            this.label1Bnaco.AutoSize = true;
            this.label1Bnaco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1Bnaco.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Bnaco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1Bnaco.Location = new System.Drawing.Point(186, -15);
            this.label1Bnaco.Name = "label1Bnaco";
            this.label1Bnaco.Size = new System.Drawing.Size(453, 79);
            this.label1Bnaco.TabIndex = 20;
            this.label1Bnaco.Text = "Mostrando Banco ";
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(0, -25);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 21;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // MostrandoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.bt2RegistarBanco);
            this.Controls.Add(this.bt2Agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1NombreBanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1IngresoBanco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label1Bnaco);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MostrandoBanco";
            this.Text = "MostarBanco";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt2RegistarBanco;
        private System.Windows.Forms.Button bt2Agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1NombreBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1IngresoBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label1Bnaco;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
    }
}
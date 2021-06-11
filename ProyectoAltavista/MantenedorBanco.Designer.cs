
namespace ProyectoAltavista
{
    partial class MantenedorBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorBanco));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt3MostraBanco = new System.Windows.Forms.Button();
            this.bt2RegistarBanco = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label1Bnaco = new System.Windows.Forms.Label();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 303);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // bt3MostraBanco
            // 
            this.bt3MostraBanco.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3MostraBanco.Location = new System.Drawing.Point(62, 297);
            this.bt3MostraBanco.Name = "bt3MostraBanco";
            this.bt3MostraBanco.Size = new System.Drawing.Size(168, 33);
            this.bt3MostraBanco.TabIndex = 10;
            this.bt3MostraBanco.Text = "Mostrar Banco";
            this.bt3MostraBanco.UseVisualStyleBackColor = true;
            this.bt3MostraBanco.Click += new System.EventHandler(this.bt3MostraBanco_Click);
            // 
            // bt2RegistarBanco
            // 
            this.bt2RegistarBanco.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2RegistarBanco.Location = new System.Drawing.Point(62, 126);
            this.bt2RegistarBanco.Name = "bt2RegistarBanco";
            this.bt2RegistarBanco.Size = new System.Drawing.Size(168, 33);
            this.bt2RegistarBanco.TabIndex = 9;
            this.bt2RegistarBanco.Text = "Registrar Banco";
            this.bt2RegistarBanco.UseVisualStyleBackColor = true;
            this.bt2RegistarBanco.Click += new System.EventHandler(this.bt2RegistarBanco_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(728, 415);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(92, 34);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            // 
            // label1Bnaco
            // 
            this.label1Bnaco.AutoSize = true;
            this.label1Bnaco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1Bnaco.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Bnaco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1Bnaco.Location = new System.Drawing.Point(350, 9);
            this.label1Bnaco.Name = "label1Bnaco";
            this.label1Bnaco.Size = new System.Drawing.Size(190, 79);
            this.label1Bnaco.TabIndex = 6;
            this.label1Bnaco.Text = "Banco ";
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 7;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // MantenedorBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt3MostraBanco);
            this.Controls.Add(this.bt2RegistarBanco);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label1Bnaco);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenedorBanco";
            this.Text = "MantenedorBanco";
            this.Load += new System.EventHandler(this.MantenedorBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt3MostraBanco;
        private System.Windows.Forms.Button bt2RegistarBanco;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label1Bnaco;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
    }
}
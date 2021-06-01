
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
            this.lbSector = new System.Windows.Forms.Label();
            this.btnRegistrarSector = new System.Windows.Forms.Button();
            this.btnMostrarSector = new System.Windows.Forms.Button();
            this.btnRegresarInicioSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSector
            // 
            this.lbSector.AutoSize = true;
            this.lbSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSector.Location = new System.Drawing.Point(316, 32);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(155, 37);
            this.lbSector.TabIndex = 0;
            this.lbSector.Text = "SECTOR";
            this.lbSector.UseMnemonic = false;
            // 
            // btnRegistrarSector
            // 
            this.btnRegistrarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSector.Location = new System.Drawing.Point(69, 117);
            this.btnRegistrarSector.Name = "btnRegistrarSector";
            this.btnRegistrarSector.Size = new System.Drawing.Size(197, 85);
            this.btnRegistrarSector.TabIndex = 1;
            this.btnRegistrarSector.Text = "Registrar Sector";
            this.btnRegistrarSector.UseVisualStyleBackColor = true;
            // 
            // btnMostrarSector
            // 
            this.btnMostrarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSector.Location = new System.Drawing.Point(69, 252);
            this.btnMostrarSector.Name = "btnMostrarSector";
            this.btnMostrarSector.Size = new System.Drawing.Size(197, 90);
            this.btnMostrarSector.TabIndex = 2;
            this.btnMostrarSector.Text = "Mostrar Sector";
            this.btnMostrarSector.UseVisualStyleBackColor = true;
            // 
            // btnRegresarInicioSec
            // 
            this.btnRegresarInicioSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarInicioSec.Location = new System.Drawing.Point(644, 382);
            this.btnRegresarInicioSec.Name = "btnRegresarInicioSec";
            this.btnRegresarInicioSec.Size = new System.Drawing.Size(131, 47);
            this.btnRegresarInicioSec.TabIndex = 3;
            this.btnRegresarInicioSec.Text = "Regresar";
            this.btnRegresarInicioSec.UseVisualStyleBackColor = true;
            this.btnRegresarInicioSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // MantenedorSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarInicioSec);
            this.Controls.Add(this.btnMostrarSector);
            this.Controls.Add(this.btnRegistrarSector);
            this.Controls.Add(this.lbSector);
            this.Name = "MantenedorSector";
            this.Text = "MantenerdorSector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSector;
        private System.Windows.Forms.Button btnRegistrarSector;
        private System.Windows.Forms.Button btnMostrarSector;
        private System.Windows.Forms.Button btnRegresarInicioSec;
    }
}
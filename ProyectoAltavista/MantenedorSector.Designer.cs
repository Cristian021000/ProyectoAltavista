
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoSector = new System.Windows.Forms.Button();
            this.btnMostrarSector = new System.Windows.Forms.Button();
            this.btnRegresarSector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECTOR";
            // 
            // btnNuevoSector
            // 
            this.btnNuevoSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoSector.Location = new System.Drawing.Point(128, 168);
            this.btnNuevoSector.Name = "btnNuevoSector";
            this.btnNuevoSector.Size = new System.Drawing.Size(133, 58);
            this.btnNuevoSector.TabIndex = 1;
            this.btnNuevoSector.Text = "Registrar Sector";
            this.btnNuevoSector.UseVisualStyleBackColor = true;
            // 
            // btnMostrarSector
            // 
            this.btnMostrarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSector.Location = new System.Drawing.Point(538, 168);
            this.btnMostrarSector.Name = "btnMostrarSector";
            this.btnMostrarSector.Size = new System.Drawing.Size(129, 58);
            this.btnMostrarSector.TabIndex = 2;
            this.btnMostrarSector.Text = "Mostrar Sector";
            this.btnMostrarSector.UseVisualStyleBackColor = true;
            // 
            // btnRegresarSector
            // 
            this.btnRegresarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarSector.Location = new System.Drawing.Point(687, 398);
            this.btnRegresarSector.Name = "btnRegresarSector";
            this.btnRegresarSector.Size = new System.Drawing.Size(101, 40);
            this.btnRegresarSector.TabIndex = 3;
            this.btnRegresarSector.Text = "Regresar";
            this.btnRegresarSector.UseVisualStyleBackColor = true;
            // 
            // MantenedorSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarSector);
            this.Controls.Add(this.btnMostrarSector);
            this.Controls.Add(this.btnNuevoSector);
            this.Controls.Add(this.label1);
            this.Name = "MantenedorSector";
            this.Text = "Sector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoSector;
        private System.Windows.Forms.Button btnMostrarSector;
        private System.Windows.Forms.Button btnRegresarSector;
    }
}
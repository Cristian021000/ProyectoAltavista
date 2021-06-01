
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
            this.lbNuevoSector = new System.Windows.Forms.Label();
            this.cbElejirCiudadNuevoSector = new System.Windows.Forms.ComboBox();
            this.txtNombreDelNuevoSector = new System.Windows.Forms.TextBox();
            this.lbElejirCiudad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarNuevoSector = new System.Windows.Forms.Button();
            this.btnCancelarNuevoSector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNuevoSector
            // 
            this.lbNuevoSector.AutoSize = true;
            this.lbNuevoSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevoSector.Location = new System.Drawing.Point(265, 20);
            this.lbNuevoSector.Name = "lbNuevoSector";
            this.lbNuevoSector.Size = new System.Drawing.Size(285, 37);
            this.lbNuevoSector.TabIndex = 1;
            this.lbNuevoSector.Text = "NUEVO SECTOR";
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
            // lbElejirCiudad
            // 
            this.lbElejirCiudad.AutoSize = true;
            this.lbElejirCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElejirCiudad.Location = new System.Drawing.Point(22, 97);
            this.lbElejirCiudad.Name = "lbElejirCiudad";
            this.lbElejirCiudad.Size = new System.Drawing.Size(186, 31);
            this.lbElejirCiudad.TabIndex = 4;
            this.lbElejirCiudad.Text = "Elija la Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el Nombre del Sector";
            // 
            // btnAgregarNuevoSector
            // 
            this.btnAgregarNuevoSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevoSector.Location = new System.Drawing.Point(550, 400);
            this.btnAgregarNuevoSector.Name = "btnAgregarNuevoSector";
            this.btnAgregarNuevoSector.Size = new System.Drawing.Size(105, 38);
            this.btnAgregarNuevoSector.TabIndex = 6;
            this.btnAgregarNuevoSector.Text = "Agregar";
            this.btnAgregarNuevoSector.UseVisualStyleBackColor = true;
            // 
            // btnCancelarNuevoSector
            // 
            this.btnCancelarNuevoSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNuevoSector.Location = new System.Drawing.Point(683, 400);
            this.btnCancelarNuevoSector.Name = "btnCancelarNuevoSector";
            this.btnCancelarNuevoSector.Size = new System.Drawing.Size(105, 38);
            this.btnCancelarNuevoSector.TabIndex = 7;
            this.btnCancelarNuevoSector.Text = "Cancelar";
            this.btnCancelarNuevoSector.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarNuevoSector);
            this.Controls.Add(this.btnAgregarNuevoSector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbElejirCiudad);
            this.Controls.Add(this.txtNombreDelNuevoSector);
            this.Controls.Add(this.cbElejirCiudadNuevoSector);
            this.Controls.Add(this.lbNuevoSector);
            this.Name = "Form1";
            this.Text = "Altavista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNuevoSector;
        private System.Windows.Forms.ComboBox cbElejirCiudadNuevoSector;
        private System.Windows.Forms.TextBox txtNombreDelNuevoSector;
        private System.Windows.Forms.Label lbElejirCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarNuevoSector;
        private System.Windows.Forms.Button btnCancelarNuevoSector;
    }
}
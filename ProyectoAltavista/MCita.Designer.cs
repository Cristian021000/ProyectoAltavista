
namespace ProyectoAltavista
{
    partial class MCita
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
            this.lbCita = new System.Windows.Forms.Label();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.btnMostrarCita = new System.Windows.Forms.Button();
            this.btnRegresarCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCita
            // 
            this.lbCita.AutoSize = true;
            this.lbCita.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCita.Location = new System.Drawing.Point(346, 22);
            this.lbCita.Name = "lbCita";
            this.lbCita.Size = new System.Drawing.Size(126, 57);
            this.lbCita.TabIndex = 0;
            this.lbCita.Text = "CITA";
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCita.Location = new System.Drawing.Point(71, 167);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(177, 68);
            this.btnRegistrarCita.TabIndex = 1;
            this.btnRegistrarCita.Text = "Registrar Cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = true;
            // 
            // btnMostrarCita
            // 
            this.btnMostrarCita.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCita.Location = new System.Drawing.Point(547, 167);
            this.btnMostrarCita.Name = "btnMostrarCita";
            this.btnMostrarCita.Size = new System.Drawing.Size(177, 68);
            this.btnMostrarCita.TabIndex = 2;
            this.btnMostrarCita.Text = "Mostrar Cita";
            this.btnMostrarCita.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCita
            // 
            this.btnRegresarCita.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarCita.Location = new System.Drawing.Point(594, 393);
            this.btnRegresarCita.Name = "btnRegresarCita";
            this.btnRegresarCita.Size = new System.Drawing.Size(130, 34);
            this.btnRegresarCita.TabIndex = 3;
            this.btnRegresarCita.Text = "Regresar";
            this.btnRegresarCita.UseVisualStyleBackColor = true;
            // 
            // MCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarCita);
            this.Controls.Add(this.btnMostrarCita);
            this.Controls.Add(this.btnRegistrarCita);
            this.Controls.Add(this.lbCita);
            this.Name = "MCita";
            this.Text = "MCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCita;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.Button btnMostrarCita;
        private System.Windows.Forms.Button btnRegresarCita;
    }
}
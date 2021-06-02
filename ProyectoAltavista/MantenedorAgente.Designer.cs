
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
            this.btRegresarCiudad = new System.Windows.Forms.Button();
            this.btModificarAgente = new System.Windows.Forms.Button();
            this.btRegistrarAgente = new System.Windows.Forms.Button();
            this.lbMenuCiudad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRegresarCiudad
            // 
            this.btRegresarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresarCiudad.Location = new System.Drawing.Point(313, 302);
            this.btRegresarCiudad.Name = "btRegresarCiudad";
            this.btRegresarCiudad.Size = new System.Drawing.Size(144, 63);
            this.btRegresarCiudad.TabIndex = 10;
            this.btRegresarCiudad.Text = "Regresar";
            this.btRegresarCiudad.UseVisualStyleBackColor = true;
            // 
            // btModificarAgente
            // 
            this.btModificarAgente.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificarAgente.Location = new System.Drawing.Point(448, 175);
            this.btModificarAgente.Name = "btModificarAgente";
            this.btModificarAgente.Size = new System.Drawing.Size(297, 63);
            this.btModificarAgente.TabIndex = 9;
            this.btModificarAgente.Text = "Modificar Agente";
            this.btModificarAgente.UseVisualStyleBackColor = true;
            // 
            // btRegistrarAgente
            // 
            this.btRegistrarAgente.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarAgente.Location = new System.Drawing.Point(56, 175);
            this.btRegistrarAgente.Name = "btRegistrarAgente";
            this.btRegistrarAgente.Size = new System.Drawing.Size(256, 63);
            this.btRegistrarAgente.TabIndex = 8;
            this.btRegistrarAgente.Text = "Registrar Agente";
            this.btRegistrarAgente.UseVisualStyleBackColor = true;
            // 
            // lbMenuCiudad
            // 
            this.lbMenuCiudad.AutoSize = true;
            this.lbMenuCiudad.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuCiudad.Location = new System.Drawing.Point(337, 86);
            this.lbMenuCiudad.Name = "lbMenuCiudad";
            this.lbMenuCiudad.Size = new System.Drawing.Size(112, 42);
            this.lbMenuCiudad.TabIndex = 7;
            this.lbMenuCiudad.Text = "Menú";
            // 
            // MantenedorAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegresarCiudad);
            this.Controls.Add(this.btModificarAgente);
            this.Controls.Add(this.btRegistrarAgente);
            this.Controls.Add(this.lbMenuCiudad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenedorAgente";
            this.Text = "MantenedorAgente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegresarCiudad;
        private System.Windows.Forms.Button btModificarAgente;
        private System.Windows.Forms.Button btRegistrarAgente;
        private System.Windows.Forms.Label lbMenuCiudad;
    }
}
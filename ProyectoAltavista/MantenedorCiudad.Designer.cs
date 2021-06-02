
namespace ProyectoAltavista
{
    partial class MantenedorCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorCiudad));
            this.lbMenuCiudad = new System.Windows.Forms.Label();
            this.btRegistrarCiudad = new System.Windows.Forms.Button();
            this.btListarCiudad = new System.Windows.Forms.Button();
            this.btRegresarCiudad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMenuCiudad
            // 
            this.lbMenuCiudad.AutoSize = true;
            this.lbMenuCiudad.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuCiudad.Location = new System.Drawing.Point(341, 65);
            this.lbMenuCiudad.Name = "lbMenuCiudad";
            this.lbMenuCiudad.Size = new System.Drawing.Size(112, 42);
            this.lbMenuCiudad.TabIndex = 1;
            this.lbMenuCiudad.Text = "Menú";
            // 
            // btRegistrarCiudad
            // 
            this.btRegistrarCiudad.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarCiudad.Location = new System.Drawing.Point(60, 154);
            this.btRegistrarCiudad.Name = "btRegistrarCiudad";
            this.btRegistrarCiudad.Size = new System.Drawing.Size(256, 63);
            this.btRegistrarCiudad.TabIndex = 4;
            this.btRegistrarCiudad.Text = "Registrar Ciudad";
            this.btRegistrarCiudad.UseVisualStyleBackColor = true;
            // 
            // btListarCiudad
            // 
            this.btListarCiudad.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarCiudad.Location = new System.Drawing.Point(472, 154);
            this.btListarCiudad.Name = "btListarCiudad";
            this.btListarCiudad.Size = new System.Drawing.Size(237, 63);
            this.btListarCiudad.TabIndex = 5;
            this.btListarCiudad.Text = "Modificar Ciudad";
            this.btListarCiudad.UseVisualStyleBackColor = true;
            this.btListarCiudad.Click += new System.EventHandler(this.btListarCiudad_Click);
            // 
            // btRegresarCiudad
            // 
            this.btRegresarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresarCiudad.Location = new System.Drawing.Point(317, 281);
            this.btRegresarCiudad.Name = "btRegresarCiudad";
            this.btRegresarCiudad.Size = new System.Drawing.Size(144, 63);
            this.btRegresarCiudad.TabIndex = 6;
            this.btRegresarCiudad.Text = "Regresar";
            this.btRegresarCiudad.UseVisualStyleBackColor = true;
            // 
            // MantenedorCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegresarCiudad);
            this.Controls.Add(this.btListarCiudad);
            this.Controls.Add(this.btRegistrarCiudad);
            this.Controls.Add(this.lbMenuCiudad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenedorCiudad";
            this.Text = "MantenedorCiudad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMenuCiudad;
        private System.Windows.Forms.Button btRegistrarCiudad;
        private System.Windows.Forms.Button btListarCiudad;
        private System.Windows.Forms.Button btRegresarCiudad;
    }
}
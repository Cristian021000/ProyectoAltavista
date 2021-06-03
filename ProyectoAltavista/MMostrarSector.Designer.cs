
namespace ProyectoAltavista
{
    partial class MMostrarSector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMostrarSector));
            this.lbMostrarSector = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificarDatosdelSector = new System.Windows.Forms.Button();
            this.btnSalirMostrarSector = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMostrarSector
            // 
            this.lbMostrarSector.AutoSize = true;
            this.lbMostrarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarSector.Location = new System.Drawing.Point(468, 48);
            this.lbMostrarSector.Name = "lbMostrarSector";
            this.lbMostrarSector.Size = new System.Drawing.Size(330, 37);
            this.lbMostrarSector.TabIndex = 0;
            this.lbMostrarSector.Text = "MOSTRAR SECTOR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnModificarDatosdelSector
            // 
            this.btnModificarDatosdelSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDatosdelSector.Location = new System.Drawing.Point(475, 180);
            this.btnModificarDatosdelSector.Name = "btnModificarDatosdelSector";
            this.btnModificarDatosdelSector.Size = new System.Drawing.Size(122, 53);
            this.btnModificarDatosdelSector.TabIndex = 2;
            this.btnModificarDatosdelSector.Text = "Modificar Datos del Sector";
            this.btnModificarDatosdelSector.UseVisualStyleBackColor = true;
            // 
            // btnSalirMostrarSector
            // 
            this.btnSalirMostrarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMostrarSector.Location = new System.Drawing.Point(666, 180);
            this.btnSalirMostrarSector.Name = "btnSalirMostrarSector";
            this.btnSalirMostrarSector.Size = new System.Drawing.Size(122, 53);
            this.btnSalirMostrarSector.TabIndex = 3;
            this.btnSalirMostrarSector.Text = "Salir";
            this.btnSalirMostrarSector.UseVisualStyleBackColor = true;
            // 
            // MMostrarSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirMostrarSector);
            this.Controls.Add(this.btnModificarDatosdelSector);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbMostrarSector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MMostrarSector";
            this.Text = "Sector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMostrarSector;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificarDatosdelSector;
        private System.Windows.Forms.Button btnSalirMostrarSector;
    }
}
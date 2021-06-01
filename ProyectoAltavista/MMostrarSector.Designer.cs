
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
            this.dgvMostrarSector = new System.Windows.Forms.DataGridView();
            this.btnModificarDatosSector = new System.Windows.Forms.Button();
            this.btnSalirMostrarSector = new System.Windows.Forms.Button();
            this.lbMostrarSector = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarSector)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarSector
            // 
            this.dgvMostrarSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarSector.Location = new System.Drawing.Point(22, 29);
            this.dgvMostrarSector.Name = "dgvMostrarSector";
            this.dgvMostrarSector.Size = new System.Drawing.Size(454, 392);
            this.dgvMostrarSector.TabIndex = 0;
            this.dgvMostrarSector.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnModificarDatosSector
            // 
            this.btnModificarDatosSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDatosSector.Location = new System.Drawing.Point(621, 94);
            this.btnModificarDatosSector.Name = "btnModificarDatosSector";
            this.btnModificarDatosSector.Size = new System.Drawing.Size(188, 52);
            this.btnModificarDatosSector.TabIndex = 1;
            this.btnModificarDatosSector.Text = "Modificar datos Sector";
            this.btnModificarDatosSector.UseVisualStyleBackColor = true;
            // 
            // btnSalirMostrarSector
            // 
            this.btnSalirMostrarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMostrarSector.Location = new System.Drawing.Point(692, 389);
            this.btnSalirMostrarSector.Name = "btnSalirMostrarSector";
            this.btnSalirMostrarSector.Size = new System.Drawing.Size(117, 32);
            this.btnSalirMostrarSector.TabIndex = 2;
            this.btnSalirMostrarSector.Text = "Salir";
            this.btnSalirMostrarSector.UseVisualStyleBackColor = true;
            // 
            // lbMostrarSector
            // 
            this.lbMostrarSector.AutoSize = true;
            this.lbMostrarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarSector.Location = new System.Drawing.Point(482, 29);
            this.lbMostrarSector.Name = "lbMostrarSector";
            this.lbMostrarSector.Size = new System.Drawing.Size(330, 37);
            this.lbMostrarSector.TabIndex = 3;
            this.lbMostrarSector.Text = "MOSTRAR SECTOR";
            // 
            // MMostrarSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.lbMostrarSector);
            this.Controls.Add(this.btnSalirMostrarSector);
            this.Controls.Add(this.btnModificarDatosSector);
            this.Controls.Add(this.dgvMostrarSector);
            this.Name = "MMostrarSector";
            this.Text = "MostrarSector";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarSector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarSector;
        private System.Windows.Forms.Button btnModificarDatosSector;
        private System.Windows.Forms.Button btnSalirMostrarSector;
        private System.Windows.Forms.Label lbMostrarSector;
    }
}
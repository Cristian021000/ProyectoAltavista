
namespace ProyectoAltavista
{
    partial class InmuebleMostrarSector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InmuebleMostrarSector));
            this.pictureBox1FondoSector = new System.Windows.Forms.PictureBox();
            this.lbMostrandoSector = new System.Windows.Forms.Label();
            this.DataGridMostrarSector = new System.Windows.Forms.DataGridView();
            this.btModificarSector = new System.Windows.Forms.Button();
            this.btRegresarSector = new System.Windows.Forms.Button();
            this.bttSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1FondoSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMostrarSector)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1FondoSector
            // 
            this.pictureBox1FondoSector.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1FondoSector.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1FondoSector.Image")));
            this.pictureBox1FondoSector.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1FondoSector.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1FondoSector.Name = "pictureBox1FondoSector";
            this.pictureBox1FondoSector.Size = new System.Drawing.Size(991, 558);
            this.pictureBox1FondoSector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1FondoSector.TabIndex = 56;
            this.pictureBox1FondoSector.TabStop = false;
            // 
            // lbMostrandoSector
            // 
            this.lbMostrandoSector.AutoSize = true;
            this.lbMostrandoSector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMostrandoSector.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrandoSector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMostrandoSector.Location = new System.Drawing.Point(95, 26);
            this.lbMostrandoSector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMostrandoSector.Name = "lbMostrandoSector";
            this.lbMostrandoSector.Size = new System.Drawing.Size(522, 97);
            this.lbMostrandoSector.TabIndex = 57;
            this.lbMostrandoSector.Text = "Mostando Sector";
            // 
            // DataGridMostrarSector
            // 
            this.DataGridMostrarSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMostrarSector.Location = new System.Drawing.Point(22, 145);
            this.DataGridMostrarSector.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridMostrarSector.Name = "DataGridMostrarSector";
            this.DataGridMostrarSector.RowHeadersWidth = 51;
            this.DataGridMostrarSector.Size = new System.Drawing.Size(501, 338);
            this.DataGridMostrarSector.TabIndex = 58;
            // 
            // btModificarSector
            // 
            this.btModificarSector.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificarSector.Location = new System.Drawing.Point(582, 155);
            this.btModificarSector.Margin = new System.Windows.Forms.Padding(4);
            this.btModificarSector.Name = "btModificarSector";
            this.btModificarSector.Size = new System.Drawing.Size(363, 95);
            this.btModificarSector.TabIndex = 59;
            this.btModificarSector.Text = "Modificar Sector";
            this.btModificarSector.UseVisualStyleBackColor = true;
            // 
            // btRegresarSector
            // 
            this.btRegresarSector.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresarSector.Location = new System.Drawing.Point(633, 283);
            this.btRegresarSector.Margin = new System.Windows.Forms.Padding(4);
            this.btRegresarSector.Name = "btRegresarSector";
            this.btRegresarSector.Size = new System.Drawing.Size(231, 62);
            this.btRegresarSector.TabIndex = 60;
            this.btRegresarSector.Text = "Regresar";
            this.btRegresarSector.UseVisualStyleBackColor = true;
            // 
            // bttSalir
            // 
            this.bttSalir.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSalir.Location = new System.Drawing.Point(633, 399);
            this.bttSalir.Margin = new System.Windows.Forms.Padding(4);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(231, 62);
            this.bttSalir.TabIndex = 61;
            this.bttSalir.Text = "Salir";
            this.bttSalir.UseVisualStyleBackColor = true;
            // 
            // InmuebleMostrarSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.bttSalir);
            this.Controls.Add(this.btRegresarSector);
            this.Controls.Add(this.btModificarSector);
            this.Controls.Add(this.DataGridMostrarSector);
            this.Controls.Add(this.lbMostrandoSector);
            this.Controls.Add(this.pictureBox1FondoSector);
            this.Name = "InmuebleMostrarSector";
            this.Text = "MostrarSector";
            this.Load += new System.EventHandler(this.InmuebleMostrarSector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1FondoSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMostrarSector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1FondoSector;
        private System.Windows.Forms.Label lbMostrandoSector;
        private System.Windows.Forms.DataGridView DataGridMostrarSector;
        private System.Windows.Forms.Button btModificarSector;
        private System.Windows.Forms.Button btRegresarSector;
        private System.Windows.Forms.Button bttSalir;
    }
}
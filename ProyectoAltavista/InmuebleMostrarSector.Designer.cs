
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
            this.btAceptarSector = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1FondoSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMostrarSector)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1FondoSector
            // 
            this.pictureBox1FondoSector.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1FondoSector.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1FondoSector.Image")));
            this.pictureBox1FondoSector.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1FondoSector.Name = "pictureBox1FondoSector";
            this.pictureBox1FondoSector.Size = new System.Drawing.Size(743, 453);
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
            this.lbMostrandoSector.Location = new System.Drawing.Point(71, 21);
            this.lbMostrandoSector.Name = "lbMostrandoSector";
            this.lbMostrandoSector.Size = new System.Drawing.Size(416, 79);
            this.lbMostrandoSector.TabIndex = 57;
            this.lbMostrandoSector.Text = "Mostando Sector";
            // 
            // DataGridMostrarSector
            // 
            this.DataGridMostrarSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMostrarSector.Location = new System.Drawing.Point(16, 118);
            this.DataGridMostrarSector.Name = "DataGridMostrarSector";
            this.DataGridMostrarSector.RowHeadersWidth = 51;
            this.DataGridMostrarSector.Size = new System.Drawing.Size(376, 275);
            this.DataGridMostrarSector.TabIndex = 58;
            // 
            // btAceptarSector
            // 
            this.btAceptarSector.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptarSector.Location = new System.Drawing.Point(475, 230);
            this.btAceptarSector.Name = "btAceptarSector";
            this.btAceptarSector.Size = new System.Drawing.Size(173, 50);
            this.btAceptarSector.TabIndex = 60;
            this.btAceptarSector.Text = "Aceptar";
            this.btAceptarSector.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(475, 324);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(173, 50);
            this.btnRegresar.TabIndex = 61;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(466, 175);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(195, 20);
            this.txtCodigo.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ingrese Codigo a Modificar";
            // 
            // InmuebleMostrarSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btAceptarSector);
            this.Controls.Add(this.DataGridMostrarSector);
            this.Controls.Add(this.lbMostrandoSector);
            this.Controls.Add(this.pictureBox1FondoSector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btAceptarSector;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}

namespace ProyectoAltavista
{
    partial class ConsultarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVentas));
            this.lbDatosVentas = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            this.dgvDatosVenta = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDatosVentas
            // 
            this.lbDatosVentas.AutoSize = true;
            this.lbDatosVentas.Font = new System.Drawing.Font("Monotype Corsiva", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosVentas.Location = new System.Drawing.Point(196, 27);
            this.lbDatosVentas.Name = "lbDatosVentas";
            this.lbDatosVentas.Size = new System.Drawing.Size(496, 56);
            this.lbDatosVentas.TabIndex = 0;
            this.lbDatosVentas.Text = "Datos de venta de inmuebles";
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(651, 351);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(119, 66);
            this.btRegresar.TabIndex = 4;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // dgvDatosVenta
            // 
            this.dgvDatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVenta.Location = new System.Drawing.Point(12, 103);
            this.dgvDatosVenta.Name = "dgvDatosVenta";
            this.dgvDatosVenta.Size = new System.Drawing.Size(416, 314);
            this.dgvDatosVenta.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar ID de Venta que desea consultar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(495, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 7;
            // 
            // ConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatosVenta);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbDatosVentas);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarVentas";
            this.Text = "ConsultarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDatosVentas;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.DataGridView dgvDatosVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
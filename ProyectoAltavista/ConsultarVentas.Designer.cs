
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
            this.rbVentaPropia = new System.Windows.Forms.RadioButton();
            this.dbVentaTerceros = new System.Windows.Forms.RadioButton();
            this.btRegresar = new System.Windows.Forms.Button();
            this.dgvDatosVenta = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            // rbVentaPropia
            // 
            this.rbVentaPropia.AutoSize = true;
            this.rbVentaPropia.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVentaPropia.Location = new System.Drawing.Point(68, 99);
            this.rbVentaPropia.Name = "rbVentaPropia";
            this.rbVentaPropia.Size = new System.Drawing.Size(165, 28);
            this.rbVentaPropia.TabIndex = 1;
            this.rbVentaPropia.TabStop = true;
            this.rbVentaPropia.Text = "Venta propia";
            this.rbVentaPropia.UseVisualStyleBackColor = true;
            // 
            // dbVentaTerceros
            // 
            this.dbVentaTerceros.AutoSize = true;
            this.dbVentaTerceros.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbVentaTerceros.Location = new System.Drawing.Point(68, 143);
            this.dbVentaTerceros.Name = "dbVentaTerceros";
            this.dbVentaTerceros.Size = new System.Drawing.Size(214, 28);
            this.dbVentaTerceros.TabIndex = 2;
            this.dbVentaTerceros.TabStop = true;
            this.dbVentaTerceros.Text = "Venta de terceros";
            this.dbVentaTerceros.UseVisualStyleBackColor = true;
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
            this.dgvDatosVenta.Location = new System.Drawing.Point(68, 192);
            this.dgvDatosVenta.Name = "dgvDatosVenta";
            this.dgvDatosVenta.Size = new System.Drawing.Size(554, 225);
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
            // ConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatosVenta);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.dbVentaTerceros);
            this.Controls.Add(this.rbVentaPropia);
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
        private System.Windows.Forms.RadioButton rbVentaPropia;
        private System.Windows.Forms.RadioButton dbVentaTerceros;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.DataGridView dgvDatosVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
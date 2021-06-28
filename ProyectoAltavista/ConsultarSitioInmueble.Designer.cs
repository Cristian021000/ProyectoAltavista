
namespace ProyectoAltavista
{
    partial class ConsultarSitioInmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarSitioInmueble));
            this.datagridSitioInmueble = new System.Windows.Forms.DataGridView();
            this.lbConsultarAgente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSitioInmueble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridSitioInmueble
            // 
            this.datagridSitioInmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSitioInmueble.Location = new System.Drawing.Point(39, 116);
            this.datagridSitioInmueble.Name = "datagridSitioInmueble";
            this.datagridSitioInmueble.RowHeadersWidth = 51;
            this.datagridSitioInmueble.Size = new System.Drawing.Size(479, 309);
            this.datagridSitioInmueble.TabIndex = 5;
            // 
            // lbConsultarAgente
            // 
            this.lbConsultarAgente.AutoSize = true;
            this.lbConsultarAgente.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarAgente.Location = new System.Drawing.Point(70, 19);
            this.lbConsultarAgente.Name = "lbConsultarAgente";
            this.lbConsultarAgente.Size = new System.Drawing.Size(593, 79);
            this.lbConsultarAgente.TabIndex = 3;
            this.lbConsultarAgente.Text = "Consultar Sitio Inmueble";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(668, 399);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(120, 39);
            this.btRegresar.TabIndex = 7;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // ConsultarSitioInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.datagridSitioInmueble);
            this.Controls.Add(this.lbConsultarAgente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConsultarSitioInmueble";
            this.Text = "ConsultarSitioInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.datagridSitioInmueble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridSitioInmueble;
        private System.Windows.Forms.Label lbConsultarAgente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btRegresar;
    }
}
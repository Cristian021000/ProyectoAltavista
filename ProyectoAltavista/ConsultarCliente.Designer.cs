
namespace ProyectoAltavista
{
    partial class ConsultarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCliente));
            this.dgvDatosCliente = new System.Windows.Forms.DataGridView();
            this.txtIngreseDni = new System.Windows.Forms.TextBox();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbConsultar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosCliente
            // 
            this.dgvDatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCliente.Location = new System.Drawing.Point(10, 93);
            this.dgvDatosCliente.Name = "dgvDatosCliente";
            this.dgvDatosCliente.RowHeadersWidth = 51;
            this.dgvDatosCliente.Size = new System.Drawing.Size(454, 346);
            this.dgvDatosCliente.TabIndex = 0;
            this.dgvDatosCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosCliente_CellContentClick_1);
            // 
            // txtIngreseDni
            // 
            this.txtIngreseDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreseDni.Location = new System.Drawing.Point(538, 93);
            this.txtIngreseDni.Name = "txtIngreseDni";
            this.txtIngreseDni.Size = new System.Drawing.Size(224, 31);
            this.txtIngreseDni.TabIndex = 2;
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-20, -7);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 22;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ingrese DNI";
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(560, 140);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(168, 30);
            this.btAceptar.TabIndex = 32;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click_1);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(615, 388);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(168, 30);
            this.btRegresar.TabIndex = 33;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 249);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lbConsultar
            // 
            this.lbConsultar.AutoSize = true;
            this.lbConsultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbConsultar.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbConsultar.Location = new System.Drawing.Point(87, 11);
            this.lbConsultar.Name = "lbConsultar";
            this.lbConsultar.Size = new System.Drawing.Size(422, 79);
            this.lbConsultar.TabIndex = 35;
            this.lbConsultar.Text = "Consultar Cliente";
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbConsultar);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.txtIngreseDni);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatosCliente);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosCliente;
        private System.Windows.Forms.TextBox txtIngreseDni;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbConsultar;
    }
}
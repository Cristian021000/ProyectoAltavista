
namespace ProyectoAltavista
{
    partial class ConsultarInmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarInmueble));
            this.Fondo = new System.Windows.Forms.PictureBox();
            this.dataGridViewConsulInmuble = new System.Windows.Forms.DataGridView();
            this.lbDatosContrato = new System.Windows.Forms.Label();
            this.comboBoxTipoInmueble = new System.Windows.Forms.ComboBox();
            this.labelIngresoDNIDCI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalirInmueble = new System.Windows.Forms.Button();
            this.dtgTipoInmueble = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulInmuble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoInmueble)).BeginInit();
            this.SuspendLayout();
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.Transparent;
            this.Fondo.Image = ((System.Drawing.Image)(resources.GetObject("Fondo.Image")));
            this.Fondo.Location = new System.Drawing.Point(-9, -30);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(813, 691);
            this.Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fondo.TabIndex = 26;
            this.Fondo.TabStop = false;
            // 
            // dataGridViewConsulInmuble
            // 
            this.dataGridViewConsulInmuble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulInmuble.Location = new System.Drawing.Point(12, 96);
            this.dataGridViewConsulInmuble.Name = "dataGridViewConsulInmuble";
            this.dataGridViewConsulInmuble.Size = new System.Drawing.Size(478, 153);
            this.dataGridViewConsulInmuble.TabIndex = 27;
            // 
            // lbDatosContrato
            // 
            this.lbDatosContrato.AutoSize = true;
            this.lbDatosContrato.Font = new System.Drawing.Font("Monotype Corsiva", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosContrato.Location = new System.Drawing.Point(261, 9);
            this.lbDatosContrato.Name = "lbDatosContrato";
            this.lbDatosContrato.Size = new System.Drawing.Size(352, 56);
            this.lbDatosContrato.TabIndex = 28;
            this.lbDatosContrato.Text = "Datos de Inmuebles";
            // 
            // comboBoxTipoInmueble
            // 
            this.comboBoxTipoInmueble.FormattingEnabled = true;
            this.comboBoxTipoInmueble.Items.AddRange(new object[] {
            "Casa",
            "Departamento",
            "Terreno"});
            this.comboBoxTipoInmueble.Location = new System.Drawing.Point(574, 155);
            this.comboBoxTipoInmueble.Name = "comboBoxTipoInmueble";
            this.comboBoxTipoInmueble.Size = new System.Drawing.Size(139, 21);
            this.comboBoxTipoInmueble.TabIndex = 29;
            this.comboBoxTipoInmueble.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoInmueble_SelectedIndexChanged);
            // 
            // labelIngresoDNIDCI
            // 
            this.labelIngresoDNIDCI.AutoSize = true;
            this.labelIngresoDNIDCI.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoDNIDCI.Location = new System.Drawing.Point(550, 108);
            this.labelIngresoDNIDCI.Name = "labelIngresoDNIDCI";
            this.labelIngresoDNIDCI.Size = new System.Drawing.Size(204, 24);
            this.labelIngresoDNIDCI.TabIndex = 30;
            this.labelIngresoDNIDCI.Text = "Tipo de Inmueble:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Codigo inmueble Modifcar";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(574, 284);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(164, 20);
            this.txtCodigo.TabIndex = 32;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(610, 333);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 31);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalirInmueble
            // 
            this.btnSalirInmueble.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirInmueble.Location = new System.Drawing.Point(610, 395);
            this.btnSalirInmueble.Name = "btnSalirInmueble";
            this.btnSalirInmueble.Size = new System.Drawing.Size(103, 31);
            this.btnSalirInmueble.TabIndex = 34;
            this.btnSalirInmueble.Text = "Salir";
            this.btnSalirInmueble.UseVisualStyleBackColor = true;
            this.btnSalirInmueble.Click += new System.EventHandler(this.btnSalirInmueble_Click);
            // 
            // dtgTipoInmueble
            // 
            this.dtgTipoInmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoInmueble.Location = new System.Drawing.Point(12, 276);
            this.dtgTipoInmueble.Name = "dtgTipoInmueble";
            this.dtgTipoInmueble.Size = new System.Drawing.Size(478, 150);
            this.dtgTipoInmueble.TabIndex = 35;
            // 
            // ConsultarInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgTipoInmueble);
            this.Controls.Add(this.btnSalirInmueble);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIngresoDNIDCI);
            this.Controls.Add(this.comboBoxTipoInmueble);
            this.Controls.Add(this.lbDatosContrato);
            this.Controls.Add(this.dataGridViewConsulInmuble);
            this.Controls.Add(this.Fondo);
            this.Name = "ConsultarInmueble";
            this.Text = "ConsultarInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulInmuble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoInmueble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fondo;
        private System.Windows.Forms.DataGridView dataGridViewConsulInmuble;
        private System.Windows.Forms.Label lbDatosContrato;
        private System.Windows.Forms.ComboBox comboBoxTipoInmueble;
        private System.Windows.Forms.Label labelIngresoDNIDCI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalirInmueble;
        private System.Windows.Forms.DataGridView dtgTipoInmueble;
    }
}
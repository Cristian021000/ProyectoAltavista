
namespace ProyectoAltavista
{
    partial class ConsultarAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarAgente));
            this.lbConsultarAgente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvConsultaAgente = new System.Windows.Forms.DataGridView();
            this.lbIngresaDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAgente)).BeginInit();
            this.SuspendLayout();
            // 
            // lbConsultarAgente
            // 
            this.lbConsultarAgente.AutoSize = true;
            this.lbConsultarAgente.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarAgente.Location = new System.Drawing.Point(93, 23);
            this.lbConsultarAgente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsultarAgente.Name = "lbConsultarAgente";
            this.lbConsultarAgente.Size = new System.Drawing.Size(536, 97);
            this.lbConsultarAgente.TabIndex = 0;
            this.lbConsultarAgente.Text = "Consultar Agente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvConsultaAgente
            // 
            this.dgvConsultaAgente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAgente.Location = new System.Drawing.Point(52, 143);
            this.dgvConsultaAgente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConsultaAgente.Name = "dgvConsultaAgente";
            this.dgvConsultaAgente.RowHeadersWidth = 51;
            this.dgvConsultaAgente.Size = new System.Drawing.Size(639, 380);
            this.dgvConsultaAgente.TabIndex = 2;
            // 
            // lbIngresaDni
            // 
            this.lbIngresaDni.AutoSize = true;
            this.lbIngresaDni.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngresaDni.Location = new System.Drawing.Point(816, 94);
            this.lbIngresaDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIngresaDni.Name = "lbIngresaDni";
            this.lbIngresaDni.Size = new System.Drawing.Size(155, 27);
            this.lbIngresaDni.TabIndex = 3;
            this.lbIngresaDni.Text = "Ingrese DNI";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(760, 143);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(267, 34);
            this.txtDni.TabIndex = 4;
            // 
            // btModificar
            // 
            this.btModificar.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(809, 208);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(160, 43);
            this.btModificar.TabIndex = 5;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(868, 475);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(160, 48);
            this.btRegresar.TabIndex = 6;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // ConsultarAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lbIngresaDni);
            this.Controls.Add(this.dgvConsultaAgente);
            this.Controls.Add(this.lbConsultarAgente);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsultarAgente";
            this.Text = "ConsultarAgente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAgente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConsultarAgente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvConsultaAgente;
        private System.Windows.Forms.Label lbIngresaDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btRegresar;
    }
}
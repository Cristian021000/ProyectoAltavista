
namespace ProyectoAltavista
{
    partial class MRegistrarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MRegistrarCita));
            this.label1 = new System.Windows.Forms.Label();
            this.lbIdDelCliente = new System.Windows.Forms.Label();
            this.txtIdDelClienteRegistrarCita = new System.Windows.Forms.TextBox();
            this.btnAceptarRegistrarCita = new System.Windows.Forms.Button();
            this.btnCancelarRegistrarCita = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerCita = new System.Windows.Forms.DateTimePicker();
            this.lbFechaCita = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxHoraCita = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Cita";
            // 
            // lbIdDelCliente
            // 
            this.lbIdDelCliente.AutoSize = true;
            this.lbIdDelCliente.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdDelCliente.Location = new System.Drawing.Point(26, 286);
            this.lbIdDelCliente.Name = "lbIdDelCliente";
            this.lbIdDelCliente.Size = new System.Drawing.Size(155, 24);
            this.lbIdDelCliente.TabIndex = 4;
            this.lbIdDelCliente.Text = "ID del Cliente";
            // 
            // txtIdDelClienteRegistrarCita
            // 
            this.txtIdDelClienteRegistrarCita.Location = new System.Drawing.Point(225, 286);
            this.txtIdDelClienteRegistrarCita.Name = "txtIdDelClienteRegistrarCita";
            this.txtIdDelClienteRegistrarCita.Size = new System.Drawing.Size(447, 20);
            this.txtIdDelClienteRegistrarCita.TabIndex = 5;
            // 
            // btnAceptarRegistrarCita
            // 
            this.btnAceptarRegistrarCita.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarRegistrarCita.Location = new System.Drawing.Point(225, 361);
            this.btnAceptarRegistrarCita.Name = "btnAceptarRegistrarCita";
            this.btnAceptarRegistrarCita.Size = new System.Drawing.Size(159, 64);
            this.btnAceptarRegistrarCita.TabIndex = 6;
            this.btnAceptarRegistrarCita.Text = "Aceptar";
            this.btnAceptarRegistrarCita.UseVisualStyleBackColor = true;
            this.btnAceptarRegistrarCita.Click += new System.EventHandler(this.btnAceptarRegistrarCita_Click);
            // 
            // btnCancelarRegistrarCita
            // 
            this.btnCancelarRegistrarCita.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRegistrarCita.Location = new System.Drawing.Point(494, 361);
            this.btnCancelarRegistrarCita.Name = "btnCancelarRegistrarCita";
            this.btnCancelarRegistrarCita.Size = new System.Drawing.Size(159, 64);
            this.btnCancelarRegistrarCita.TabIndex = 7;
            this.btnCancelarRegistrarCita.Text = "Cancelar";
            this.btnCancelarRegistrarCita.UseVisualStyleBackColor = true;
            this.btnCancelarRegistrarCita.Click += new System.EventHandler(this.btnCancelarRegistrarCita_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePickerCita
            // 
            this.dateTimePickerCita.Location = new System.Drawing.Point(225, 133);
            this.dateTimePickerCita.Name = "dateTimePickerCita";
            this.dateTimePickerCita.Size = new System.Drawing.Size(229, 20);
            this.dateTimePickerCita.TabIndex = 16;
            // 
            // lbFechaCita
            // 
            this.lbFechaCita.AutoSize = true;
            this.lbFechaCita.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaCita.Location = new System.Drawing.Point(26, 129);
            this.lbFechaCita.Name = "lbFechaCita";
            this.lbFechaCita.Size = new System.Drawing.Size(179, 24);
            this.lbFechaCita.TabIndex = 15;
            this.lbFechaCita.Text = "Fecha de la Cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hora de la Cita";
            // 
            // comboBoxHoraCita
            // 
            this.comboBoxHoraCita.FormattingEnabled = true;
            this.comboBoxHoraCita.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.comboBoxHoraCita.Location = new System.Drawing.Point(225, 180);
            this.comboBoxHoraCita.Name = "comboBoxHoraCita";
            this.comboBoxHoraCita.Size = new System.Drawing.Size(147, 21);
            this.comboBoxHoraCita.TabIndex = 17;
            // 
            // MRegistrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxHoraCita);
            this.Controls.Add(this.dateTimePickerCita);
            this.Controls.Add(this.lbFechaCita);
            this.Controls.Add(this.btnCancelarRegistrarCita);
            this.Controls.Add(this.btnAceptarRegistrarCita);
            this.Controls.Add(this.txtIdDelClienteRegistrarCita);
            this.Controls.Add(this.lbIdDelCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MRegistrarCita";
            this.Text = "MRegistrarCita";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIdDelCliente;
        private System.Windows.Forms.TextBox txtIdDelClienteRegistrarCita;
        private System.Windows.Forms.Button btnAceptarRegistrarCita;
        private System.Windows.Forms.Button btnCancelarRegistrarCita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerCita;
        private System.Windows.Forms.Label lbFechaCita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxHoraCita;
    }
}
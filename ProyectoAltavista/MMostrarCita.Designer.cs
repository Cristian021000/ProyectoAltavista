
namespace ProyectoAltavista
{
    partial class MMostrarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMostrarCita));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalirMostrarCita = new System.Windows.Forms.Button();
            this.txtIDClienteCita = new System.Windows.Forms.TextBox();
            this.lbDniClienteCita = new System.Windows.Forms.Label();
            this.dataGridViewMostrarCita = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarCita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Cita";
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-19, -19);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 493);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 24;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(542, 219);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(132, 31);
            this.btnAceptar.TabIndex = 28;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalirMostrarCita
            // 
            this.btnSalirMostrarCita.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMostrarCita.Location = new System.Drawing.Point(683, 377);
            this.btnSalirMostrarCita.Name = "btnSalirMostrarCita";
            this.btnSalirMostrarCita.Size = new System.Drawing.Size(82, 37);
            this.btnSalirMostrarCita.TabIndex = 27;
            this.btnSalirMostrarCita.Text = "Salir";
            this.btnSalirMostrarCita.UseVisualStyleBackColor = true;
            this.btnSalirMostrarCita.Click += new System.EventHandler(this.btnSalirMostrarCita_Click);
            // 
            // txtIDClienteCita
            // 
            this.txtIDClienteCita.Location = new System.Drawing.Point(467, 161);
            this.txtIDClienteCita.Name = "txtIDClienteCita";
            this.txtIDClienteCita.Size = new System.Drawing.Size(298, 20);
            this.txtIDClienteCita.TabIndex = 26;
            // 
            // lbDniClienteCita
            // 
            this.lbDniClienteCita.AutoSize = true;
            this.lbDniClienteCita.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDniClienteCita.Location = new System.Drawing.Point(559, 110);
            this.lbDniClienteCita.Name = "lbDniClienteCita";
            this.lbDniClienteCita.Size = new System.Drawing.Size(82, 24);
            this.lbDniClienteCita.TabIndex = 25;
            this.lbDniClienteCita.Text = "ID Cita";
            // 
            // dataGridViewMostrarCita
            // 
            this.dataGridViewMostrarCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrarCita.Location = new System.Drawing.Point(25, 82);
            this.dataGridViewMostrarCita.Name = "dataGridViewMostrarCita";
            this.dataGridViewMostrarCita.Size = new System.Drawing.Size(422, 356);
            this.dataGridViewMostrarCita.TabIndex = 29;
            // 
            // MMostrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMostrarCita);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalirMostrarCita);
            this.Controls.Add(this.txtIDClienteCita);
            this.Controls.Add(this.lbDniClienteCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MMostrarCita";
            this.Text = "MMostrarCita";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalirMostrarCita;
        private System.Windows.Forms.TextBox txtIDClienteCita;
        private System.Windows.Forms.Label lbDniClienteCita;
        private System.Windows.Forms.DataGridView dataGridViewMostrarCita;
    }
}

namespace ProyectoAltavista
{
    partial class MMostrarSector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMostrarSector));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.label1Bnaco = new System.Windows.Forms.Label();
            this.bt2Agregar = new System.Windows.Forms.Button();
            this.bt2RegistarBanco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(579, 468);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-13, -13);
            this.pictureBox1Fondo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(1119, 572);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 22;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // label1Bnaco
            // 
            this.label1Bnaco.AutoSize = true;
            this.label1Bnaco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1Bnaco.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Bnaco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1Bnaco.Location = new System.Drawing.Point(646, 34);
            this.label1Bnaco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Bnaco.Name = "label1Bnaco";
            this.label1Bnaco.Size = new System.Drawing.Size(405, 72);
            this.label1Bnaco.TabIndex = 23;
            this.label1Bnaco.Text = "Mostrando Sector";
            // 
            // bt2Agregar
            // 
            this.bt2Agregar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2Agregar.Location = new System.Drawing.Point(680, 210);
            this.bt2Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.bt2Agregar.Name = "bt2Agregar";
            this.bt2Agregar.Size = new System.Drawing.Size(320, 37);
            this.bt2Agregar.TabIndex = 31;
            this.bt2Agregar.Text = "Modificar Datos del Sector";
            this.bt2Agregar.UseVisualStyleBackColor = true;
            // 
            // bt2RegistarBanco
            // 
            this.bt2RegistarBanco.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2RegistarBanco.Location = new System.Drawing.Point(741, 367);
            this.bt2RegistarBanco.Margin = new System.Windows.Forms.Padding(4);
            this.bt2RegistarBanco.Name = "bt2RegistarBanco";
            this.bt2RegistarBanco.Size = new System.Drawing.Size(224, 37);
            this.bt2RegistarBanco.TabIndex = 32;
            this.bt2RegistarBanco.Text = "Salir";
            this.bt2RegistarBanco.UseVisualStyleBackColor = true;
            // 
            // MMostrarSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bt2RegistarBanco);
            this.Controls.Add(this.bt2Agregar);
            this.Controls.Add(this.label1Bnaco);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MMostrarSector";
            this.Text = "Sector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.Label label1Bnaco;
        private System.Windows.Forms.Button bt2Agregar;
        private System.Windows.Forms.Button bt2RegistarBanco;
    }
}
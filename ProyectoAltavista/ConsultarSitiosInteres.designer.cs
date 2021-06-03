
namespace ProyectoAltavista
{
    partial class ConsultarSitiosInteres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarSitiosInteres));
            this.DataGridVerSitioInteres = new System.Windows.Forms.DataGridView();
            this.label1Bnaco = new System.Windows.Forms.Label();
            this.textBox1IngresoBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt2 = new System.Windows.Forms.Button();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerSitioInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridVerSitioInteres
            // 
            this.DataGridVerSitioInteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVerSitioInteres.Location = new System.Drawing.Point(25, 165);
            this.DataGridVerSitioInteres.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridVerSitioInteres.Name = "DataGridVerSitioInteres";
            this.DataGridVerSitioInteres.RowHeadersWidth = 51;
            this.DataGridVerSitioInteres.Size = new System.Drawing.Size(576, 366);
            this.DataGridVerSitioInteres.TabIndex = 0;
            // 
            // label1Bnaco
            // 
            this.label1Bnaco.AutoSize = true;
            this.label1Bnaco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1Bnaco.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Bnaco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1Bnaco.Location = new System.Drawing.Point(230, 26);
            this.label1Bnaco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Bnaco.Name = "label1Bnaco";
            this.label1Bnaco.Size = new System.Drawing.Size(643, 97);
            this.label1Bnaco.TabIndex = 21;
            this.label1Bnaco.Text = "Visita sitios e Interés";
            // 
            // textBox1IngresoBanco
            // 
            this.textBox1IngresoBanco.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1IngresoBanco.Location = new System.Drawing.Point(631, 203);
            this.textBox1IngresoBanco.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1IngresoBanco.Multiline = true;
            this.textBox1IngresoBanco.Name = "textBox1IngresoBanco";
            this.textBox1IngresoBanco.Size = new System.Drawing.Size(390, 36);
            this.textBox1IngresoBanco.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ingrese Codigo de Interés a Modificar";
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(709, 279);
            this.bt2.Margin = new System.Windows.Forms.Padding(4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(224, 37);
            this.bt2.TabIndex = 41;
            this.bt2.Text = "Aceptar";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-6, -3);
            this.pictureBox1Fondo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(1119, 572);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 42;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // ConsultarSitiosInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1IngresoBanco);
            this.Controls.Add(this.label1Bnaco);
            this.Controls.Add(this.DataGridVerSitioInteres);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarSitiosInteres";
            this.Text = "MVerSitiosInteres";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerSitioInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridVerSitioInteres;
        private System.Windows.Forms.Label label1Bnaco;
        private System.Windows.Forms.TextBox textBox1IngresoBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
    }
}

namespace ProyectoAltavista
{
    partial class MModificarTerreno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MModificarTerreno));
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPrecioMinimo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelModificarTerreno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chbAgua = new System.Windows.Forms.CheckBox();
            this.chbAlcantarillado = new System.Windows.Forms.CheckBox();
            this.chbDesague = new System.Windows.Forms.CheckBox();
            this.chbLuz = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-1, 6);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(709, 438);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 53;
            this.pictureBox1Fondo.TabStop = false;
            this.pictureBox1Fondo.Click += new System.EventHandler(this.pictureBox1Fondo_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(189, 77);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(224, 33);
            this.txtPrecio.TabIndex = 65;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtPrecioMinimo
            // 
            this.txtPrecioMinimo.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMinimo.Location = new System.Drawing.Point(209, 116);
            this.txtPrecioMinimo.Multiline = true;
            this.txtPrecioMinimo.Name = "txtPrecioMinimo";
            this.txtPrecioMinimo.Size = new System.Drawing.Size(224, 33);
            this.txtPrecioMinimo.TabIndex = 66;
            this.txtPrecioMinimo.TextChanged += new System.EventHandler(this.txtPrecioMinimo_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(148, 382);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(168, 30);
            this.btnAceptar.TabIndex = 71;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(423, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 30);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelModificarTerreno
            // 
            this.labelModificarTerreno.AutoSize = true;
            this.labelModificarTerreno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelModificarTerreno.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarTerreno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelModificarTerreno.Location = new System.Drawing.Point(117, 6);
            this.labelModificarTerreno.Name = "labelModificarTerreno";
            this.labelModificarTerreno.Size = new System.Drawing.Size(330, 57);
            this.labelModificarTerreno.TabIndex = 73;
            this.labelModificarTerreno.Text = "Modificar Terreno";
            this.labelModificarTerreno.Click += new System.EventHandler(this.labelModificarTerreno_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 74;
            this.label6.Text = "Precio:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 22);
            this.label7.TabIndex = 75;
            this.label7.Text = "Precio Minimo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chbAgua
            // 
            this.chbAgua.AutoSize = true;
            this.chbAgua.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAgua.Location = new System.Drawing.Point(47, 219);
            this.chbAgua.Name = "chbAgua";
            this.chbAgua.Size = new System.Drawing.Size(77, 26);
            this.chbAgua.TabIndex = 76;
            this.chbAgua.Text = "Agua";
            this.chbAgua.UseVisualStyleBackColor = true;
            // 
            // chbAlcantarillado
            // 
            this.chbAlcantarillado.AutoSize = true;
            this.chbAlcantarillado.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAlcantarillado.Location = new System.Drawing.Point(47, 262);
            this.chbAlcantarillado.Name = "chbAlcantarillado";
            this.chbAlcantarillado.Size = new System.Drawing.Size(164, 26);
            this.chbAlcantarillado.TabIndex = 77;
            this.chbAlcantarillado.Text = "Alcantarillado";
            this.chbAlcantarillado.UseVisualStyleBackColor = true;
            // 
            // chbDesague
            // 
            this.chbDesague.AutoSize = true;
            this.chbDesague.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDesague.Location = new System.Drawing.Point(47, 304);
            this.chbDesague.Name = "chbDesague";
            this.chbDesague.Size = new System.Drawing.Size(110, 26);
            this.chbDesague.TabIndex = 78;
            this.chbDesague.Text = "Desague";
            this.chbDesague.UseVisualStyleBackColor = true;
            // 
            // chbLuz
            // 
            this.chbLuz.AutoSize = true;
            this.chbLuz.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLuz.Location = new System.Drawing.Point(47, 348);
            this.chbLuz.Name = "chbLuz";
            this.chbLuz.Size = new System.Drawing.Size(64, 26);
            this.chbLuz.TabIndex = 79;
            this.chbLuz.Text = "Luz";
            this.chbLuz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 80;
            this.label1.Text = "Área:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(127, 170);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(150, 20);
            this.txtArea.TabIndex = 81;
            // 
            // MModificarTerreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 435);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbLuz);
            this.Controls.Add(this.chbDesague);
            this.Controls.Add(this.chbAlcantarillado);
            this.Controls.Add(this.chbAgua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelModificarTerreno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecioMinimo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MModificarTerreno";
            this.Text = "MModificarTerreno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPrecioMinimo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelModificarTerreno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbAgua;
        private System.Windows.Forms.CheckBox chbAlcantarillado;
        private System.Windows.Forms.CheckBox chbDesague;
        private System.Windows.Forms.CheckBox chbLuz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArea;
    }
}
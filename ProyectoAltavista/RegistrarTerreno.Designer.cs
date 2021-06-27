
namespace ProyectoAltavista
{
    partial class RegistrarTerreno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarTerreno));
            this.FondoT = new System.Windows.Forms.PictureBox();
            this.lbRegistrarTerreno = new System.Windows.Forms.Label();
            this.DireccionT = new System.Windows.Forms.Label();
            this.PrecioT = new System.Windows.Forms.Label();
            this.PrecioMinT = new System.Windows.Forms.Label();
            this.NumRegisPublicosT = new System.Windows.Forms.Label();
            this.txtDireccionT = new System.Windows.Forms.TextBox();
            this.txtPrecioT = new System.Windows.Forms.TextBox();
            this.txtPrecioMinT = new System.Windows.Forms.TextBox();
            this.txtRegisPubliT = new System.Windows.Forms.TextBox();
            this.AceptarRegisTerreno = new System.Windows.Forms.Button();
            this.RegresarTerreno = new System.Windows.Forms.Button();
            this.chbAgua = new System.Windows.Forms.CheckBox();
            this.chbAlcantarillado = new System.Windows.Forms.CheckBox();
            this.chbDesague = new System.Windows.Forms.CheckBox();
            this.chbLuz = new System.Windows.Forms.CheckBox();
            this.comboBoxPropietario = new System.Windows.Forms.ComboBox();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.labelIDPropietarioD = new System.Windows.Forms.Label();
            this.label1IdSectorD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FondoT)).BeginInit();
            this.SuspendLayout();
            // 
            // FondoT
            // 
            this.FondoT.BackColor = System.Drawing.Color.Transparent;
            this.FondoT.Image = ((System.Drawing.Image)(resources.GetObject("FondoT.Image")));
            this.FondoT.Location = new System.Drawing.Point(-2, -88);
            this.FondoT.Name = "FondoT";
            this.FondoT.Size = new System.Drawing.Size(592, 745);
            this.FondoT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FondoT.TabIndex = 27;
            this.FondoT.TabStop = false;
            // 
            // lbRegistrarTerreno
            // 
            this.lbRegistrarTerreno.AutoSize = true;
            this.lbRegistrarTerreno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbRegistrarTerreno.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrarTerreno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRegistrarTerreno.Location = new System.Drawing.Point(113, 7);
            this.lbRegistrarTerreno.Name = "lbRegistrarTerreno";
            this.lbRegistrarTerreno.Size = new System.Drawing.Size(423, 79);
            this.lbRegistrarTerreno.TabIndex = 51;
            this.lbRegistrarTerreno.Text = "Registrar Terreno";
            // 
            // DireccionT
            // 
            this.DireccionT.AutoSize = true;
            this.DireccionT.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionT.Location = new System.Drawing.Point(42, 119);
            this.DireccionT.Name = "DireccionT";
            this.DireccionT.Size = new System.Drawing.Size(105, 22);
            this.DireccionT.TabIndex = 52;
            this.DireccionT.Text = "Direccion:";
            // 
            // PrecioT
            // 
            this.PrecioT.AutoSize = true;
            this.PrecioT.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioT.Location = new System.Drawing.Point(42, 170);
            this.PrecioT.Name = "PrecioT";
            this.PrecioT.Size = new System.Drawing.Size(73, 22);
            this.PrecioT.TabIndex = 53;
            this.PrecioT.Text = "Precio:";
            // 
            // PrecioMinT
            // 
            this.PrecioMinT.AutoSize = true;
            this.PrecioMinT.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioMinT.Location = new System.Drawing.Point(42, 227);
            this.PrecioMinT.Name = "PrecioMinT";
            this.PrecioMinT.Size = new System.Drawing.Size(148, 22);
            this.PrecioMinT.TabIndex = 54;
            this.PrecioMinT.Text = "Precio Minimo:";
            // 
            // NumRegisPublicosT
            // 
            this.NumRegisPublicosT.AutoSize = true;
            this.NumRegisPublicosT.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumRegisPublicosT.Location = new System.Drawing.Point(42, 275);
            this.NumRegisPublicosT.Name = "NumRegisPublicosT";
            this.NumRegisPublicosT.Size = new System.Drawing.Size(293, 22);
            this.NumRegisPublicosT.TabIndex = 55;
            this.NumRegisPublicosT.Text = "Numero de Registros Publicos:";
            // 
            // txtDireccionT
            // 
            this.txtDireccionT.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionT.Location = new System.Drawing.Point(148, 116);
            this.txtDireccionT.Multiline = true;
            this.txtDireccionT.Name = "txtDireccionT";
            this.txtDireccionT.Size = new System.Drawing.Size(397, 33);
            this.txtDireccionT.TabIndex = 63;
            // 
            // txtPrecioT
            // 
            this.txtPrecioT.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioT.Location = new System.Drawing.Point(148, 170);
            this.txtPrecioT.Multiline = true;
            this.txtPrecioT.Name = "txtPrecioT";
            this.txtPrecioT.Size = new System.Drawing.Size(397, 33);
            this.txtPrecioT.TabIndex = 64;
            // 
            // txtPrecioMinT
            // 
            this.txtPrecioMinT.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMinT.Location = new System.Drawing.Point(181, 224);
            this.txtPrecioMinT.Multiline = true;
            this.txtPrecioMinT.Name = "txtPrecioMinT";
            this.txtPrecioMinT.Size = new System.Drawing.Size(364, 33);
            this.txtPrecioMinT.TabIndex = 65;
            // 
            // txtRegisPubliT
            // 
            this.txtRegisPubliT.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisPubliT.Location = new System.Drawing.Point(341, 272);
            this.txtRegisPubliT.Multiline = true;
            this.txtRegisPubliT.Name = "txtRegisPubliT";
            this.txtRegisPubliT.Size = new System.Drawing.Size(216, 33);
            this.txtRegisPubliT.TabIndex = 66;
            // 
            // AceptarRegisTerreno
            // 
            this.AceptarRegisTerreno.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarRegisTerreno.Location = new System.Drawing.Point(61, 573);
            this.AceptarRegisTerreno.Name = "AceptarRegisTerreno";
            this.AceptarRegisTerreno.Size = new System.Drawing.Size(173, 50);
            this.AceptarRegisTerreno.TabIndex = 73;
            this.AceptarRegisTerreno.Text = "Aceptar";
            this.AceptarRegisTerreno.UseVisualStyleBackColor = true;
            this.AceptarRegisTerreno.Click += new System.EventHandler(this.AceptarRegisTerreno_Click);
            // 
            // RegresarTerreno
            // 
            this.RegresarTerreno.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresarTerreno.Location = new System.Drawing.Point(350, 573);
            this.RegresarTerreno.Name = "RegresarTerreno";
            this.RegresarTerreno.Size = new System.Drawing.Size(173, 50);
            this.RegresarTerreno.TabIndex = 74;
            this.RegresarTerreno.Text = "Regresar";
            this.RegresarTerreno.UseVisualStyleBackColor = true;
            this.RegresarTerreno.Click += new System.EventHandler(this.RegresarTerreno_Click);
            // 
            // chbAgua
            // 
            this.chbAgua.AutoSize = true;
            this.chbAgua.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAgua.Location = new System.Drawing.Point(50, 420);
            this.chbAgua.Name = "chbAgua";
            this.chbAgua.Size = new System.Drawing.Size(77, 26);
            this.chbAgua.TabIndex = 75;
            this.chbAgua.Text = "Agua";
            this.chbAgua.UseVisualStyleBackColor = true;
            // 
            // chbAlcantarillado
            // 
            this.chbAlcantarillado.AutoSize = true;
            this.chbAlcantarillado.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAlcantarillado.Location = new System.Drawing.Point(50, 452);
            this.chbAlcantarillado.Name = "chbAlcantarillado";
            this.chbAlcantarillado.Size = new System.Drawing.Size(164, 26);
            this.chbAlcantarillado.TabIndex = 76;
            this.chbAlcantarillado.Text = "Alcantarillado";
            this.chbAlcantarillado.UseVisualStyleBackColor = true;
            // 
            // chbDesague
            // 
            this.chbDesague.AutoSize = true;
            this.chbDesague.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDesague.Location = new System.Drawing.Point(46, 484);
            this.chbDesague.Name = "chbDesague";
            this.chbDesague.Size = new System.Drawing.Size(110, 26);
            this.chbDesague.TabIndex = 77;
            this.chbDesague.Text = "Desague";
            this.chbDesague.UseVisualStyleBackColor = true;
            // 
            // chbLuz
            // 
            this.chbLuz.AutoSize = true;
            this.chbLuz.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLuz.Location = new System.Drawing.Point(46, 516);
            this.chbLuz.Name = "chbLuz";
            this.chbLuz.Size = new System.Drawing.Size(64, 26);
            this.chbLuz.TabIndex = 78;
            this.chbLuz.Text = "Luz";
            this.chbLuz.UseVisualStyleBackColor = true;
            // 
            // comboBoxPropietario
            // 
            this.comboBoxPropietario.FormattingEnabled = true;
            this.comboBoxPropietario.Location = new System.Drawing.Point(171, 367);
            this.comboBoxPropietario.Name = "comboBoxPropietario";
            this.comboBoxPropietario.Size = new System.Drawing.Size(234, 21);
            this.comboBoxPropietario.TabIndex = 82;
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(124, 322);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(172, 21);
            this.comboBoxSector.TabIndex = 81;
            // 
            // labelIDPropietarioD
            // 
            this.labelIDPropietarioD.AutoSize = true;
            this.labelIDPropietarioD.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDPropietarioD.Location = new System.Drawing.Point(45, 367);
            this.labelIDPropietarioD.Name = "labelIDPropietarioD";
            this.labelIDPropietarioD.Size = new System.Drawing.Size(120, 22);
            this.labelIDPropietarioD.TabIndex = 80;
            this.labelIDPropietarioD.Text = "Propietario:";
            // 
            // label1IdSectorD
            // 
            this.label1IdSectorD.AutoSize = true;
            this.label1IdSectorD.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1IdSectorD.Location = new System.Drawing.Point(45, 318);
            this.label1IdSectorD.Name = "label1IdSectorD";
            this.label1IdSectorD.Size = new System.Drawing.Size(73, 22);
            this.label1IdSectorD.TabIndex = 79;
            this.label1IdSectorD.Text = "Sector:";
            // 
            // RegistrarTerreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 652);
            this.Controls.Add(this.comboBoxPropietario);
            this.Controls.Add(this.comboBoxSector);
            this.Controls.Add(this.labelIDPropietarioD);
            this.Controls.Add(this.label1IdSectorD);
            this.Controls.Add(this.chbLuz);
            this.Controls.Add(this.chbDesague);
            this.Controls.Add(this.chbAlcantarillado);
            this.Controls.Add(this.chbAgua);
            this.Controls.Add(this.RegresarTerreno);
            this.Controls.Add(this.AceptarRegisTerreno);
            this.Controls.Add(this.txtRegisPubliT);
            this.Controls.Add(this.txtPrecioMinT);
            this.Controls.Add(this.txtPrecioT);
            this.Controls.Add(this.txtDireccionT);
            this.Controls.Add(this.NumRegisPublicosT);
            this.Controls.Add(this.PrecioMinT);
            this.Controls.Add(this.PrecioT);
            this.Controls.Add(this.DireccionT);
            this.Controls.Add(this.lbRegistrarTerreno);
            this.Controls.Add(this.FondoT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarTerreno";
            this.Text = "RegistrarTerreno";
            ((System.ComponentModel.ISupportInitialize)(this.FondoT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FondoT;
        private System.Windows.Forms.Label lbRegistrarTerreno;
        private System.Windows.Forms.Label DireccionT;
        private System.Windows.Forms.Label PrecioT;
        private System.Windows.Forms.Label PrecioMinT;
        private System.Windows.Forms.Label NumRegisPublicosT;
        private System.Windows.Forms.TextBox txtDireccionT;
        private System.Windows.Forms.TextBox txtPrecioT;
        private System.Windows.Forms.TextBox txtPrecioMinT;
        private System.Windows.Forms.TextBox txtRegisPubliT;
        private System.Windows.Forms.Button AceptarRegisTerreno;
        private System.Windows.Forms.Button RegresarTerreno;
        private System.Windows.Forms.CheckBox chbAgua;
        private System.Windows.Forms.CheckBox chbAlcantarillado;
        private System.Windows.Forms.CheckBox chbDesague;
        private System.Windows.Forms.CheckBox chbLuz;
        private System.Windows.Forms.ComboBox comboBoxPropietario;
        private System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.Label labelIDPropietarioD;
        private System.Windows.Forms.Label label1IdSectorD;
    }
}
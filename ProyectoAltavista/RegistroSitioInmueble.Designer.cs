
namespace ProyectoAltavista
{
    partial class RegistroSitioInmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroSitioInmueble));
            this.txtIdInmuebleC = new System.Windows.Forms.TextBox();
            this.IdInmueble = new System.Windows.Forms.Label();
            this.btnCancerlarModificarSI = new System.Windows.Forms.Button();
            this.LbSitioine = new System.Windows.Forms.Label();
            this.labelModificarSitioInteres = new System.Windows.Forms.Label();
            this.IdSitioDeInteres = new System.Windows.Forms.Label();
            this.txtIdSitioInteress = new System.Windows.Forms.TextBox();
            this.LbInmuebles = new System.Windows.Forms.Label();
            this.BtRegistrarSiti = new System.Windows.Forms.Button();
            this.InmueblesVista = new System.Windows.Forms.DataGridView();
            this.SitioDeInteresVista = new System.Windows.Forms.DataGridView();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            this.txtDsitancia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoInmueble = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.InmueblesVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SitioDeInteresVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdInmuebleC
            // 
            this.txtIdInmuebleC.Location = new System.Drawing.Point(281, 70);
            this.txtIdInmuebleC.Name = "txtIdInmuebleC";
            this.txtIdInmuebleC.Size = new System.Drawing.Size(213, 20);
            this.txtIdInmuebleC.TabIndex = 21;
            // 
            // IdInmueble
            // 
            this.IdInmueble.AutoSize = true;
            this.IdInmueble.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdInmueble.Location = new System.Drawing.Point(29, 68);
            this.IdInmueble.Name = "IdInmueble";
            this.IdInmueble.Size = new System.Drawing.Size(246, 22);
            this.IdInmueble.TabIndex = 20;
            this.IdInmueble.Text = "Ingrese ID del Inmueble:";
            // 
            // btnCancerlarModificarSI
            // 
            this.btnCancerlarModificarSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancerlarModificarSI.Location = new System.Drawing.Point(623, 333);
            this.btnCancerlarModificarSI.Name = "btnCancerlarModificarSI";
            this.btnCancerlarModificarSI.Size = new System.Drawing.Size(130, 54);
            this.btnCancerlarModificarSI.TabIndex = 18;
            this.btnCancerlarModificarSI.Text = "Cancelar";
            this.btnCancerlarModificarSI.UseVisualStyleBackColor = true;
            this.btnCancerlarModificarSI.Click += new System.EventHandler(this.btnCancerlarModificarSI_Click);
            // 
            // LbSitioine
            // 
            this.LbSitioine.AutoSize = true;
            this.LbSitioine.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSitioine.Location = new System.Drawing.Point(29, 335);
            this.LbSitioine.Name = "LbSitioine";
            this.LbSitioine.Size = new System.Drawing.Size(157, 22);
            this.LbSitioine.TabIndex = 14;
            this.LbSitioine.Text = "Sitio de Interes";
            this.LbSitioine.Click += new System.EventHandler(this.LbSitioine_Click);
            // 
            // labelModificarSitioInteres
            // 
            this.labelModificarSitioInteres.AutoSize = true;
            this.labelModificarSitioInteres.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarSitioInteres.Location = new System.Drawing.Point(229, 2);
            this.labelModificarSitioInteres.Name = "labelModificarSitioInteres";
            this.labelModificarSitioInteres.Size = new System.Drawing.Size(448, 57);
            this.labelModificarSitioInteres.TabIndex = 11;
            this.labelModificarSitioInteres.Text = "Registrar Sitio Inmueble ";
            // 
            // IdSitioDeInteres
            // 
            this.IdSitioDeInteres.AutoSize = true;
            this.IdSitioDeInteres.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdSitioDeInteres.Location = new System.Drawing.Point(29, 104);
            this.IdSitioDeInteres.Name = "IdSitioDeInteres";
            this.IdSitioDeInteres.Size = new System.Drawing.Size(310, 22);
            this.IdSitioDeInteres.TabIndex = 22;
            this.IdSitioDeInteres.Text = "Ingrese ID del Sitio de Interes :";
            // 
            // txtIdSitioInteress
            // 
            this.txtIdSitioInteress.Location = new System.Drawing.Point(345, 104);
            this.txtIdSitioInteress.Name = "txtIdSitioInteress";
            this.txtIdSitioInteress.Size = new System.Drawing.Size(213, 20);
            this.txtIdSitioInteress.TabIndex = 23;
            // 
            // LbInmuebles
            // 
            this.LbInmuebles.AutoSize = true;
            this.LbInmuebles.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInmuebles.Location = new System.Drawing.Point(29, 196);
            this.LbInmuebles.Name = "LbInmuebles";
            this.LbInmuebles.Size = new System.Drawing.Size(109, 22);
            this.LbInmuebles.TabIndex = 25;
            this.LbInmuebles.Text = "Inmuebles";
            this.LbInmuebles.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtRegistrarSiti
            // 
            this.BtRegistrarSiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegistrarSiti.Location = new System.Drawing.Point(623, 240);
            this.BtRegistrarSiti.Name = "BtRegistrarSiti";
            this.BtRegistrarSiti.Size = new System.Drawing.Size(130, 54);
            this.BtRegistrarSiti.TabIndex = 26;
            this.BtRegistrarSiti.Text = "Registrar";
            this.BtRegistrarSiti.UseVisualStyleBackColor = true;
            this.BtRegistrarSiti.Click += new System.EventHandler(this.BtRegistrarSiti_Click);
            // 
            // InmueblesVista
            // 
            this.InmueblesVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InmueblesVista.Location = new System.Drawing.Point(33, 219);
            this.InmueblesVista.Name = "InmueblesVista";
            this.InmueblesVista.Size = new System.Drawing.Size(450, 113);
            this.InmueblesVista.TabIndex = 28;
            // 
            // SitioDeInteresVista
            // 
            this.SitioDeInteresVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SitioDeInteresVista.Location = new System.Drawing.Point(33, 358);
            this.SitioDeInteresVista.Name = "SitioDeInteresVista";
            this.SitioDeInteresVista.Size = new System.Drawing.Size(450, 89);
            this.SitioDeInteresVista.TabIndex = 29;
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-11, -3);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 30;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // txtDsitancia
            // 
            this.txtDsitancia.Location = new System.Drawing.Point(137, 142);
            this.txtDsitancia.Name = "txtDsitancia";
            this.txtDsitancia.Size = new System.Drawing.Size(213, 20);
            this.txtDsitancia.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Distancia:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ingrese Tipo Inmueble : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxTipoInmueble
            // 
            this.comboBoxTipoInmueble.FormattingEnabled = true;
            this.comboBoxTipoInmueble.Items.AddRange(new object[] {
            "Casa",
            "Departamento ",
            "Terreno"});
            this.comboBoxTipoInmueble.Location = new System.Drawing.Point(281, 169);
            this.comboBoxTipoInmueble.Name = "comboBoxTipoInmueble";
            this.comboBoxTipoInmueble.Size = new System.Drawing.Size(213, 21);
            this.comboBoxTipoInmueble.TabIndex = 34;
            this.comboBoxTipoInmueble.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoInmueble_SelectedIndexChanged);
            // 
            // RegistroSitioInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 459);
            this.Controls.Add(this.comboBoxTipoInmueble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDsitancia);
            this.Controls.Add(this.SitioDeInteresVista);
            this.Controls.Add(this.InmueblesVista);
            this.Controls.Add(this.BtRegistrarSiti);
            this.Controls.Add(this.LbInmuebles);
            this.Controls.Add(this.txtIdSitioInteress);
            this.Controls.Add(this.IdSitioDeInteres);
            this.Controls.Add(this.txtIdInmuebleC);
            this.Controls.Add(this.IdInmueble);
            this.Controls.Add(this.btnCancerlarModificarSI);
            this.Controls.Add(this.LbSitioine);
            this.Controls.Add(this.labelModificarSitioInteres);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroSitioInmueble";
            this.Text = "RegistroSitioInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.InmueblesVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SitioDeInteresVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdInmuebleC;
        private System.Windows.Forms.Label IdInmueble;
        private System.Windows.Forms.Button btnCancerlarModificarSI;
        private System.Windows.Forms.Label LbSitioine;
        private System.Windows.Forms.Label labelModificarSitioInteres;
        private System.Windows.Forms.Label IdSitioDeInteres;
        private System.Windows.Forms.TextBox txtIdSitioInteress;
        private System.Windows.Forms.Label LbInmuebles;
        private System.Windows.Forms.Button BtRegistrarSiti;
        private System.Windows.Forms.DataGridView InmueblesVista;
        private System.Windows.Forms.DataGridView SitioDeInteresVista;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
        private System.Windows.Forms.TextBox txtDsitancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoInmueble;
    }
}

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
            this.LbSitioDeInteres = new System.Windows.Forms.Label();
            this.labelModificarSitioInteres = new System.Windows.Forms.Label();
            this.IdSitioDeInteres = new System.Windows.Forms.Label();
            this.txtIdSitioInteress = new System.Windows.Forms.TextBox();
            this.LbInmuebles = new System.Windows.Forms.Label();
            this.BtRegistrarSiti = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InmueblesVista = new System.Windows.Forms.DataGridView();
            this.SitioDeInteresVista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InmueblesVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SitioDeInteresVista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdInmuebleC
            // 
            this.txtIdInmuebleC.Location = new System.Drawing.Point(270, 73);
            this.txtIdInmuebleC.Name = "txtIdInmuebleC";
            this.txtIdInmuebleC.ReadOnly = true;
            this.txtIdInmuebleC.Size = new System.Drawing.Size(213, 20);
            this.txtIdInmuebleC.TabIndex = 21;
            // 
            // IdInmueble
            // 
            this.IdInmueble.AutoSize = true;
            this.IdInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdInmueble.Location = new System.Drawing.Point(29, 71);
            this.IdInmueble.Name = "IdInmueble";
            this.IdInmueble.Size = new System.Drawing.Size(183, 20);
            this.IdInmueble.TabIndex = 20;
            this.IdInmueble.Text = "Ingrese ID del Inmueble:";
            // 
            // btnCancerlarModificarSI
            // 
            this.btnCancerlarModificarSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancerlarModificarSI.Location = new System.Drawing.Point(683, 404);
            this.btnCancerlarModificarSI.Name = "btnCancerlarModificarSI";
            this.btnCancerlarModificarSI.Size = new System.Drawing.Size(105, 34);
            this.btnCancerlarModificarSI.TabIndex = 18;
            this.btnCancerlarModificarSI.Text = "Cancelar";
            this.btnCancerlarModificarSI.UseVisualStyleBackColor = true;
            // 
            // LbSitioine
            // 
            this.LbSitioine.AutoSize = true;
            this.LbSitioine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSitioine.Location = new System.Drawing.Point(29, 281);
            this.LbSitioine.Name = "LbSitioine";
            this.LbSitioine.Size = new System.Drawing.Size(116, 20);
            this.LbSitioine.TabIndex = 14;
            this.LbSitioine.Text = "Sitio de Interes";
            this.LbSitioine.Click += new System.EventHandler(this.LbSitioine_Click);
            // 
            // LbSitioDeInteres
            // 
            this.LbSitioDeInteres.AutoSize = true;
            this.LbSitioDeInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSitioDeInteres.Location = new System.Drawing.Point(502, 71);
            this.LbSitioDeInteres.Name = "LbSitioDeInteres";
            this.LbSitioDeInteres.Size = new System.Drawing.Size(111, 20);
            this.LbSitioDeInteres.TabIndex = 12;
            this.LbSitioDeInteres.Text = "Sitio-Inmueble";
            // 
            // labelModificarSitioInteres
            // 
            this.labelModificarSitioInteres.AutoSize = true;
            this.labelModificarSitioInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarSitioInteres.Location = new System.Drawing.Point(277, 25);
            this.labelModificarSitioInteres.Name = "labelModificarSitioInteres";
            this.labelModificarSitioInteres.Size = new System.Drawing.Size(271, 25);
            this.labelModificarSitioInteres.TabIndex = 11;
            this.labelModificarSitioInteres.Text = "Registrar Sitio Inmueble ";
            // 
            // IdSitioDeInteres
            // 
            this.IdSitioDeInteres.AutoSize = true;
            this.IdSitioDeInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdSitioDeInteres.Location = new System.Drawing.Point(29, 104);
            this.IdSitioDeInteres.Name = "IdSitioDeInteres";
            this.IdSitioDeInteres.Size = new System.Drawing.Size(228, 20);
            this.IdSitioDeInteres.TabIndex = 22;
            this.IdSitioDeInteres.Text = "Ingrese ID del Sitio de Interes :";
            // 
            // txtIdSitioInteress
            // 
            this.txtIdSitioInteress.Location = new System.Drawing.Point(270, 106);
            this.txtIdSitioInteress.Name = "txtIdSitioInteress";
            this.txtIdSitioInteress.ReadOnly = true;
            this.txtIdSitioInteress.Size = new System.Drawing.Size(213, 20);
            this.txtIdSitioInteress.TabIndex = 23;
            // 
            // LbInmuebles
            // 
            this.LbInmuebles.AutoSize = true;
            this.LbInmuebles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInmuebles.Location = new System.Drawing.Point(29, 142);
            this.LbInmuebles.Name = "LbInmuebles";
            this.LbInmuebles.Size = new System.Drawing.Size(83, 20);
            this.LbInmuebles.TabIndex = 25;
            this.LbInmuebles.Text = "Inmuebles";
            this.LbInmuebles.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtRegistrarSiti
            // 
            this.BtRegistrarSiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegistrarSiti.Location = new System.Drawing.Point(548, 404);
            this.BtRegistrarSiti.Name = "BtRegistrarSiti";
            this.BtRegistrarSiti.Size = new System.Drawing.Size(105, 34);
            this.BtRegistrarSiti.TabIndex = 26;
            this.BtRegistrarSiti.Text = "Registrar";
            this.BtRegistrarSiti.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(235, 268);
            this.dataGridView1.TabIndex = 27;
            // 
            // InmueblesVista
            // 
            this.InmueblesVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InmueblesVista.Location = new System.Drawing.Point(33, 165);
            this.InmueblesVista.Name = "InmueblesVista";
            this.InmueblesVista.Size = new System.Drawing.Size(450, 113);
            this.InmueblesVista.TabIndex = 28;
            // 
            // SitioDeInteresVista
            // 
            this.SitioDeInteresVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SitioDeInteresVista.Location = new System.Drawing.Point(33, 304);
            this.SitioDeInteresVista.Name = "SitioDeInteresVista";
            this.SitioDeInteresVista.Size = new System.Drawing.Size(450, 104);
            this.SitioDeInteresVista.TabIndex = 29;
            // 
            // RegistroSitioInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 459);
            this.Controls.Add(this.SitioDeInteresVista);
            this.Controls.Add(this.InmueblesVista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtRegistrarSiti);
            this.Controls.Add(this.LbInmuebles);
            this.Controls.Add(this.txtIdSitioInteress);
            this.Controls.Add(this.IdSitioDeInteres);
            this.Controls.Add(this.txtIdInmuebleC);
            this.Controls.Add(this.IdInmueble);
            this.Controls.Add(this.btnCancerlarModificarSI);
            this.Controls.Add(this.LbSitioine);
            this.Controls.Add(this.LbSitioDeInteres);
            this.Controls.Add(this.labelModificarSitioInteres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroSitioInmueble";
            this.Text = "RegistroSitioInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InmueblesVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SitioDeInteresVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdInmuebleC;
        private System.Windows.Forms.Label IdInmueble;
        private System.Windows.Forms.Button btnCancerlarModificarSI;
        private System.Windows.Forms.Label LbSitioine;
        private System.Windows.Forms.Label LbSitioDeInteres;
        private System.Windows.Forms.Label labelModificarSitioInteres;
        private System.Windows.Forms.Label IdSitioDeInteres;
        private System.Windows.Forms.TextBox txtIdSitioInteress;
        private System.Windows.Forms.Label LbInmuebles;
        private System.Windows.Forms.Button BtRegistrarSiti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView InmueblesVista;
        private System.Windows.Forms.DataGridView SitioDeInteresVista;
    }
}
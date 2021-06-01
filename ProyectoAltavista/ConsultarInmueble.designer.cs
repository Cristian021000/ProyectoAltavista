
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
            this.dgvConsultarInmueble = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNuevoInmueble = new System.Windows.Forms.Button();
            this.btnRegistrarInmueble = new System.Windows.Forms.Button();
            this.btnMostrarInmueble = new System.Windows.Forms.Button();
            this.btnModificarInmueble = new System.Windows.Forms.Button();
            this.btnInhabilitarInmueble = new System.Windows.Forms.Button();
            this.btnConsultarInmueble = new System.Windows.Forms.Button();
            this.btnSalirInmueble = new System.Windows.Forms.Button();
            this.comboBoxInmueble = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreInmueble = new System.Windows.Forms.TextBox();
            this.txtDescripcionInmueble = new System.Windows.Forms.TextBox();
            this.txtPrecioInmueble = new System.Windows.Forms.TextBox();
            this.txtCiudadInmueble = new System.Windows.Forms.TextBox();
            this.txtSectorInmueble = new System.Windows.Forms.TextBox();
            this.txtUbicacionInmueble = new System.Windows.Forms.TextBox();
            this.txtReferenciaInmueble = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId_Inmueble = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEstadoInmueble = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarInmueble)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultarInmueble
            // 
            this.dgvConsultarInmueble.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvConsultarInmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarInmueble.Location = new System.Drawing.Point(33, 298);
            this.dgvConsultarInmueble.Name = "dgvConsultarInmueble";
            this.dgvConsultarInmueble.RowHeadersWidth = 62;
            this.dgvConsultarInmueble.RowTemplate.Height = 28;
            this.dgvConsultarInmueble.Size = new System.Drawing.Size(878, 192);
            this.dgvConsultarInmueble.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descricion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sector";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ubicacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Referencia";
            // 
            // btnNuevoInmueble
            // 
            this.btnNuevoInmueble.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNuevoInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoInmueble.Location = new System.Drawing.Point(13, 517);
            this.btnNuevoInmueble.Name = "btnNuevoInmueble";
            this.btnNuevoInmueble.Size = new System.Drawing.Size(88, 49);
            this.btnNuevoInmueble.TabIndex = 10;
            this.btnNuevoInmueble.Text = "NUEVO";
            this.btnNuevoInmueble.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarInmueble
            // 
            this.btnRegistrarInmueble.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRegistrarInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarInmueble.Location = new System.Drawing.Point(135, 512);
            this.btnRegistrarInmueble.Name = "btnRegistrarInmueble";
            this.btnRegistrarInmueble.Size = new System.Drawing.Size(125, 54);
            this.btnRegistrarInmueble.TabIndex = 11;
            this.btnRegistrarInmueble.Text = "REGISTRAR";
            this.btnRegistrarInmueble.UseVisualStyleBackColor = false;
            // 
            // btnMostrarInmueble
            // 
            this.btnMostrarInmueble.BackColor = System.Drawing.Color.SpringGreen;
            this.btnMostrarInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInmueble.Location = new System.Drawing.Point(282, 517);
            this.btnMostrarInmueble.Name = "btnMostrarInmueble";
            this.btnMostrarInmueble.Size = new System.Drawing.Size(110, 49);
            this.btnMostrarInmueble.TabIndex = 12;
            this.btnMostrarInmueble.Text = "MOSTRAR";
            this.btnMostrarInmueble.UseVisualStyleBackColor = false;
            // 
            // btnModificarInmueble
            // 
            this.btnModificarInmueble.BackColor = System.Drawing.Color.SpringGreen;
            this.btnModificarInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarInmueble.Location = new System.Drawing.Point(413, 517);
            this.btnModificarInmueble.Name = "btnModificarInmueble";
            this.btnModificarInmueble.Size = new System.Drawing.Size(128, 49);
            this.btnModificarInmueble.TabIndex = 13;
            this.btnModificarInmueble.Text = "MODIFICAR";
            this.btnModificarInmueble.UseVisualStyleBackColor = false;
            // 
            // btnInhabilitarInmueble
            // 
            this.btnInhabilitarInmueble.BackColor = System.Drawing.Color.SpringGreen;
            this.btnInhabilitarInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarInmueble.Location = new System.Drawing.Point(562, 517);
            this.btnInhabilitarInmueble.Name = "btnInhabilitarInmueble";
            this.btnInhabilitarInmueble.Size = new System.Drawing.Size(134, 49);
            this.btnInhabilitarInmueble.TabIndex = 14;
            this.btnInhabilitarInmueble.Text = "INHABILITAR";
            this.btnInhabilitarInmueble.UseVisualStyleBackColor = false;
            // 
            // btnConsultarInmueble
            // 
            this.btnConsultarInmueble.BackColor = System.Drawing.Color.SpringGreen;
            this.btnConsultarInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarInmueble.Location = new System.Drawing.Point(719, 517);
            this.btnConsultarInmueble.Name = "btnConsultarInmueble";
            this.btnConsultarInmueble.Size = new System.Drawing.Size(125, 49);
            this.btnConsultarInmueble.TabIndex = 15;
            this.btnConsultarInmueble.Text = "CONSULTAR";
            this.btnConsultarInmueble.UseVisualStyleBackColor = false;
            // 
            // btnSalirInmueble
            // 
            this.btnSalirInmueble.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSalirInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirInmueble.Location = new System.Drawing.Point(864, 517);
            this.btnSalirInmueble.Name = "btnSalirInmueble";
            this.btnSalirInmueble.Size = new System.Drawing.Size(115, 49);
            this.btnSalirInmueble.TabIndex = 16;
            this.btnSalirInmueble.Text = "SALIR";
            this.btnSalirInmueble.UseVisualStyleBackColor = false;
            // 
            // comboBoxInmueble
            // 
            this.comboBoxInmueble.FormattingEnabled = true;
            this.comboBoxInmueble.Items.AddRange(new object[] {
            "-----",
            "Propios",
            "Terceros"});
            this.comboBoxInmueble.Location = new System.Drawing.Point(177, 25);
            this.comboBoxInmueble.Name = "comboBoxInmueble";
            this.comboBoxInmueble.Size = new System.Drawing.Size(121, 28);
            this.comboBoxInmueble.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inmueble";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreInmueble
            // 
            this.txtNombreInmueble.Location = new System.Drawing.Point(177, 106);
            this.txtNombreInmueble.Name = "txtNombreInmueble";
            this.txtNombreInmueble.Size = new System.Drawing.Size(270, 26);
            this.txtNombreInmueble.TabIndex = 21;
            // 
            // txtDescripcionInmueble
            // 
            this.txtDescripcionInmueble.Location = new System.Drawing.Point(177, 144);
            this.txtDescripcionInmueble.Name = "txtDescripcionInmueble";
            this.txtDescripcionInmueble.Size = new System.Drawing.Size(270, 26);
            this.txtDescripcionInmueble.TabIndex = 22;
            // 
            // txtPrecioInmueble
            // 
            this.txtPrecioInmueble.Location = new System.Drawing.Point(177, 195);
            this.txtPrecioInmueble.Name = "txtPrecioInmueble";
            this.txtPrecioInmueble.Size = new System.Drawing.Size(270, 26);
            this.txtPrecioInmueble.TabIndex = 23;
            // 
            // txtCiudadInmueble
            // 
            this.txtCiudadInmueble.Location = new System.Drawing.Point(612, 16);
            this.txtCiudadInmueble.Name = "txtCiudadInmueble";
            this.txtCiudadInmueble.Size = new System.Drawing.Size(270, 26);
            this.txtCiudadInmueble.TabIndex = 24;
            // 
            // txtSectorInmueble
            // 
            this.txtSectorInmueble.Location = new System.Drawing.Point(612, 60);
            this.txtSectorInmueble.Name = "txtSectorInmueble";
            this.txtSectorInmueble.Size = new System.Drawing.Size(270, 26);
            this.txtSectorInmueble.TabIndex = 25;
            // 
            // txtUbicacionInmueble
            // 
            this.txtUbicacionInmueble.Location = new System.Drawing.Point(612, 103);
            this.txtUbicacionInmueble.Name = "txtUbicacionInmueble";
            this.txtUbicacionInmueble.Size = new System.Drawing.Size(270, 26);
            this.txtUbicacionInmueble.TabIndex = 26;
            // 
            // txtReferenciaInmueble
            // 
            this.txtReferenciaInmueble.Location = new System.Drawing.Point(612, 147);
            this.txtReferenciaInmueble.Name = "txtReferenciaInmueble";
            this.txtReferenciaInmueble.Size = new System.Drawing.Size(270, 26);
            this.txtReferenciaInmueble.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "MOSTRAR DATOS";
            // 
            // txtId_Inmueble
            // 
            this.txtId_Inmueble.Location = new System.Drawing.Point(177, 63);
            this.txtId_Inmueble.Name = "txtId_Inmueble";
            this.txtId_Inmueble.Size = new System.Drawing.Size(270, 26);
            this.txtId_Inmueble.TabIndex = 31;
            this.txtId_Inmueble.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Id_Inmueble";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cmbEstadoInmueble
            // 
            this.cmbEstadoInmueble.FormattingEnabled = true;
            this.cmbEstadoInmueble.Items.AddRange(new object[] {
            "------",
            "Vendido",
            "Disponible",
            "EnTramite"});
            this.cmbEstadoInmueble.Location = new System.Drawing.Point(612, 193);
            this.cmbEstadoInmueble.Name = "cmbEstadoInmueble";
            this.cmbEstadoInmueble.Size = new System.Drawing.Size(149, 28);
            this.cmbEstadoInmueble.TabIndex = 32;
            // 
            // ConsultarInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1004, 601);
            this.Controls.Add(this.cmbEstadoInmueble);
            this.Controls.Add(this.txtId_Inmueble);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtReferenciaInmueble);
            this.Controls.Add(this.txtUbicacionInmueble);
            this.Controls.Add(this.txtSectorInmueble);
            this.Controls.Add(this.txtCiudadInmueble);
            this.Controls.Add(this.txtPrecioInmueble);
            this.Controls.Add(this.txtDescripcionInmueble);
            this.Controls.Add(this.txtNombreInmueble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxInmueble);
            this.Controls.Add(this.btnSalirInmueble);
            this.Controls.Add(this.btnConsultarInmueble);
            this.Controls.Add(this.btnInhabilitarInmueble);
            this.Controls.Add(this.btnModificarInmueble);
            this.Controls.Add(this.btnMostrarInmueble);
            this.Controls.Add(this.btnRegistrarInmueble);
            this.Controls.Add(this.btnNuevoInmueble);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvConsultarInmueble);
            this.Name = "ConsultarInmueble";
            this.Text = "ConsultarInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarInmueble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarInmueble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNuevoInmueble;
        private System.Windows.Forms.Button btnRegistrarInmueble;
        private System.Windows.Forms.Button btnMostrarInmueble;
        private System.Windows.Forms.Button btnModificarInmueble;
        private System.Windows.Forms.Button btnInhabilitarInmueble;
        private System.Windows.Forms.Button btnConsultarInmueble;
        private System.Windows.Forms.Button btnSalirInmueble;
        private System.Windows.Forms.ComboBox comboBoxInmueble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreInmueble;
        private System.Windows.Forms.TextBox txtDescripcionInmueble;
        private System.Windows.Forms.TextBox txtPrecioInmueble;
        private System.Windows.Forms.TextBox txtCiudadInmueble;
        private System.Windows.Forms.TextBox txtSectorInmueble;
        private System.Windows.Forms.TextBox txtUbicacionInmueble;
        private System.Windows.Forms.TextBox txtReferenciaInmueble;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId_Inmueble;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEstadoInmueble;
    }
}
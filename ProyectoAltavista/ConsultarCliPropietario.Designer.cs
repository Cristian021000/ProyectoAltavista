
namespace ProyectoAltavista
{
    partial class ConsultarCliPropietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCliPropietario));
            this.dgvConsultarCliPropietario = new System.Windows.Forms.DataGridView();
            this.lbIngreseDni = new System.Windows.Forms.Label();
            this.txtIngreseDni = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliPropietario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultarCliPropietario
            // 
            this.dgvConsultarCliPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCliPropietario.Location = new System.Drawing.Point(31, 32);
            this.dgvConsultarCliPropietario.Name = "dgvConsultarCliPropietario";
            this.dgvConsultarCliPropietario.Size = new System.Drawing.Size(460, 383);
            this.dgvConsultarCliPropietario.TabIndex = 0;
            // 
            // lbIngreseDni
            // 
            this.lbIngreseDni.AutoSize = true;
            this.lbIngreseDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreseDni.Location = new System.Drawing.Point(574, 60);
            this.lbIngreseDni.Name = "lbIngreseDni";
            this.lbIngreseDni.Size = new System.Drawing.Size(160, 31);
            this.lbIngreseDni.TabIndex = 1;
            this.lbIngreseDni.Text = "Ingrese DNI";
            // 
            // txtIngreseDni
            // 
            this.txtIngreseDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreseDni.Location = new System.Drawing.Point(532, 113);
            this.txtIngreseDni.Name = "txtIngreseDni";
            this.txtIngreseDni.Size = new System.Drawing.Size(234, 29);
            this.txtIngreseDni.TabIndex = 2;
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(592, 181);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(130, 51);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(637, 361);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(142, 54);
            this.btRegresar.TabIndex = 4;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // ConsultarCliPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txtIngreseDni);
            this.Controls.Add(this.lbIngreseDni);
            this.Controls.Add(this.dgvConsultarCliPropietario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarCliPropietario";
            this.Text = "ConsultarCliPropietario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliPropietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarCliPropietario;
        private System.Windows.Forms.Label lbIngreseDni;
        private System.Windows.Forms.TextBox txtIngreseDni;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btRegresar;
    }
}
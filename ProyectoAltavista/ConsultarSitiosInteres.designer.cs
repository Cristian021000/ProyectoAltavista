
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
            this.DataGridVerSitioInteres = new System.Windows.Forms.DataGridView();
            this.labelVerSi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodSitioInteres = new System.Windows.Forms.TextBox();
            this.btnCodVerSitioInteres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerSitioInteres)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridVerSitioInteres
            // 
            this.DataGridVerSitioInteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVerSitioInteres.Location = new System.Drawing.Point(12, 141);
            this.DataGridVerSitioInteres.Name = "DataGridVerSitioInteres";
            this.DataGridVerSitioInteres.Size = new System.Drawing.Size(432, 297);
            this.DataGridVerSitioInteres.TabIndex = 0;
            // 
            // labelVerSi
            // 
            this.labelVerSi.AutoSize = true;
            this.labelVerSi.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerSi.Location = new System.Drawing.Point(275, 51);
            this.labelVerSi.Name = "labelVerSi";
            this.labelVerSi.Size = new System.Drawing.Size(327, 26);
            this.labelVerSi.TabIndex = 1;
            this.labelVerSi.Text = "VISTA SITIOS DE INTERÉS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo de sitio de interés a modifcar";
            // 
            // txtCodSitioInteres
            // 
            this.txtCodSitioInteres.Location = new System.Drawing.Point(498, 267);
            this.txtCodSitioInteres.Name = "txtCodSitioInteres";
            this.txtCodSitioInteres.Size = new System.Drawing.Size(260, 20);
            this.txtCodSitioInteres.TabIndex = 3;
            // 
            // btnCodVerSitioInteres
            // 
            this.btnCodVerSitioInteres.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodVerSitioInteres.Location = new System.Drawing.Point(579, 355);
            this.btnCodVerSitioInteres.Name = "btnCodVerSitioInteres";
            this.btnCodVerSitioInteres.Size = new System.Drawing.Size(97, 32);
            this.btnCodVerSitioInteres.TabIndex = 4;
            this.btnCodVerSitioInteres.Text = "Aceptar";
            this.btnCodVerSitioInteres.UseVisualStyleBackColor = true;
            // 
            // MVerSitiosInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCodVerSitioInteres);
            this.Controls.Add(this.txtCodSitioInteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelVerSi);
            this.Controls.Add(this.DataGridVerSitioInteres);
            this.Name = "MVerSitiosInteres";
            this.Text = "MVerSitiosInteres";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerSitioInteres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridVerSitioInteres;
        private System.Windows.Forms.Label labelVerSi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodSitioInteres;
        private System.Windows.Forms.Button btnCodVerSitioInteres;
    }
}
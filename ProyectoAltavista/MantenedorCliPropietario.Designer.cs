
namespace ProyectoAltavista
{
    partial class MantenedorCliPropietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorCliPropietario));
            this.lbMenu = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            this.btLista = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(351, 43);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(87, 33);
            this.lbMenu.TabIndex = 0;
            this.lbMenu.Text = "Menú";
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(337, 276);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(144, 63);
            this.btRegresar.TabIndex = 1;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // btLista
            // 
            this.btLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLista.Location = new System.Drawing.Point(468, 129);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(144, 63);
            this.btLista.TabIndex = 2;
            this.btLista.Text = "Lista";
            this.btLista.UseVisualStyleBackColor = true;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(185, 129);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(144, 63);
            this.btRegistrar.TabIndex = 3;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            // 
            // MantenedorCliPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenedorCliPropietario";
            this.Text = "MantenedorCliPropietario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.Button btRegistrar;
    }
}
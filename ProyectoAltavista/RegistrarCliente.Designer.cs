
namespace ProyectoAltavista
{
    partial class RegistrarCliente
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
            this.lbRegistrarCliente = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtEdadCliente = new System.Windows.Forms.TextBox();
            this.txtCelularCliente = new System.Windows.Forms.TextBox();
            this.btRegistrarDatCli = new System.Windows.Forms.Button();
            this.btCancelarDatClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRegistrarCliente
            // 
            this.lbRegistrarCliente.AutoSize = true;
            this.lbRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrarCliente.Location = new System.Drawing.Point(248, 36);
            this.lbRegistrarCliente.Name = "lbRegistrarCliente";
            this.lbRegistrarCliente.Size = new System.Drawing.Size(295, 42);
            this.lbRegistrarCliente.TabIndex = 0;
            this.lbRegistrarCliente.Text = "Registrar Cliente";
            this.lbRegistrarCliente.Click += new System.EventHandler(this.lbRegistrarCliente_Click);
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(56, 147);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(46, 24);
            this.lbDni.TabIndex = 1;
            this.lbDni.Text = "DNI:";
            this.lbDni.Click += new System.EventHandler(this.lbDni_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(56, 200);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(84, 24);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre:";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(56, 256);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(84, 24);
            this.lbApellido.TabIndex = 3;
            this.lbApellido.Text = "Apellido:";
            this.lbApellido.Click += new System.EventHandler(this.lbApellido_Click);
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(56, 318);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(60, 24);
            this.lbEdad.TabIndex = 4;
            this.lbEdad.Text = "Edad:";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(56, 378);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(74, 24);
            this.lbCelular.TabIndex = 5;
            this.lbCelular.Text = "Celular:";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(183, 147);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(360, 20);
            this.txtDniCliente.TabIndex = 6;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(183, 200);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(360, 20);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(183, 256);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(360, 20);
            this.txtApellidoCliente.TabIndex = 8;
            // 
            // txtEdadCliente
            // 
            this.txtEdadCliente.Location = new System.Drawing.Point(183, 318);
            this.txtEdadCliente.Name = "txtEdadCliente";
            this.txtEdadCliente.Size = new System.Drawing.Size(360, 20);
            this.txtEdadCliente.TabIndex = 9;
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Location = new System.Drawing.Point(183, 378);
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.Size = new System.Drawing.Size(360, 20);
            this.txtCelularCliente.TabIndex = 10;
            // 
            // btRegistrarDatCli
            // 
            this.btRegistrarDatCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarDatCli.Location = new System.Drawing.Point(625, 169);
            this.btRegistrarDatCli.Name = "btRegistrarDatCli";
            this.btRegistrarDatCli.Size = new System.Drawing.Size(138, 73);
            this.btRegistrarDatCli.TabIndex = 11;
            this.btRegistrarDatCli.Text = "Registrar";
            this.btRegistrarDatCli.UseVisualStyleBackColor = true;
            this.btRegistrarDatCli.Click += new System.EventHandler(this.btRegistrarDatCli_Click);
            // 
            // btCancelarDatClientes
            // 
            this.btCancelarDatClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarDatClientes.Location = new System.Drawing.Point(625, 293);
            this.btCancelarDatClientes.Name = "btCancelarDatClientes";
            this.btCancelarDatClientes.Size = new System.Drawing.Size(138, 70);
            this.btCancelarDatClientes.TabIndex = 12;
            this.btCancelarDatClientes.Text = "Cancelar";
            this.btCancelarDatClientes.UseVisualStyleBackColor = true;
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCancelarDatClientes);
            this.Controls.Add(this.btRegistrarDatCli);
            this.Controls.Add(this.txtCelularCliente);
            this.Controls.Add(this.txtEdadCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbRegistrarCliente);
            this.Name = "RegistrarCliente";
            this.Text = "Registrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegistrarCliente;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtEdadCliente;
        private System.Windows.Forms.TextBox txtCelularCliente;
        private System.Windows.Forms.Button btRegistrarDatCli;
        private System.Windows.Forms.Button btCancelarDatClientes;
    }
}
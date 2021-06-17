﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAltavista
{
    public partial class MantenedorCiudad : Form
    {
        MenuPrincipal principal;
        RegistrarCiudad registroCiudad;
        public MantenedorCiudad(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void btRegistrarCiudad_Click(object sender, EventArgs e)
        {
            if (registroCiudad == null)
            {
                registroCiudad = new RegistrarCiudad(this);
            }
            registroCiudad.Show();
            this.Hide();
        }


        private void btRegresar_Click(object sender, EventArgs e)
        {
            
            principal.Show();
            this.Hide();
        }
    }
}

using System;
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
    public partial class MenuVentas : Form
    {
        MenuPrincipal principal;
        public MenuVentas(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }
    }
}

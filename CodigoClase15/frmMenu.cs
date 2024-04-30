using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoClase15
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {           
             Form1 form1 = new Form1();
            form1.ShowDialog();                    
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario frmRegistroUsuario = new frmRegistroUsuario();
            frmRegistroUsuario.ShowDialog();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmRegistroProducto frmRegistroProducto = new frmRegistroProducto();
            frmRegistroProducto.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

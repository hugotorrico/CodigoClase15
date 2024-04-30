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
    public partial class frmMenuFinal : Form
    {
        public frmMenuFinal()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProducto frmRegistroProducto = new frmRegistroProducto();
            frmRegistroProducto.ShowDialog();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario frmRegistroUsuario = new frmRegistroUsuario();
            frmRegistroUsuario.ShowDialog();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarProductos frmListarProductos = new frmListarProductos();
            frmListarProductos.ShowDialog();
        }

        private void frmMenuFinal_Load(object sender, EventArgs e)
        {

        }

        private void enBlancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}

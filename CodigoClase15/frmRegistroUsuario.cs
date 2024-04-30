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
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (cbCasado.Checked)
                lblCasado.BackColor = Color.Green;
            else
                lblCasado.BackColor = Color.Red;


            if (dtpFechaNacimiento.Value.Year < 2006)
                lblMayorEdad.BackColor = Color.Green;
            else
                lblMayorEdad.BackColor = Color.Red;

        }

       
    }
}

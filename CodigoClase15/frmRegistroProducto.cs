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
    public partial class frmRegistroProducto : Form
    {
        List<Producto> productos = new List<Producto>();

        public frmRegistroProducto()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cbCategoria.Text = "";
            dgvProductos.DataSource = null;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
         

            Producto producto = new Producto
            {
                Nombre = txtNombre.Text,
                Precio = Convert.ToDouble(txtPrecio.Text),               
                Categoria =Convert.ToString( cbCategoria.SelectedItem)
            };          
            productos.Add(producto);
            
            Limpiar();
            dgvProductos.DataSource = productos;


        }
    }
}

namespace CodigoClase15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Diseño 
        //Eventos/Funciones
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "htorrico" && txtPassword.Text == "123456")
            {
                MessageBox.Show("Bienvenido al Sistema");
            }
            else
            {
                MessageBox.Show("Eror de Usuario y/o Password");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

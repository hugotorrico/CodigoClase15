namespace CodigoClase15
{
    partial class frmMenu
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
            btnLogin = new Button();
            btnRegistro = new Button();
            btnProductos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(76, 71);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(135, 57);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Ir al Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(76, 149);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(135, 57);
            btnRegistro.TabIndex = 1;
            btnRegistro.Text = "Ir Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(76, 227);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(135, 57);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Ir a Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(76, 306);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(135, 57);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnProductos);
            Controls.Add(btnRegistro);
            Controls.Add(btnLogin);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnRegistro;
        private Button btnProductos;
        private Button btnSalir;
    }
}
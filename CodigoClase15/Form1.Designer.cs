namespace CodigoClase15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsuario = new TextBox();
            btnIniciarSesion = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            btnSalir = new Button();
            btnPrueba = new Button();
            btnNuevo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 68);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(179, 68);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 1;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(68, 190);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(115, 29);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 123);
            label2.Name = "label2";
            label2.Size = new Size(139, 44);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(179, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(189, 190);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(314, 190);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(94, 29);
            btnPrueba.TabIndex = 6;
            btnPrueba.Text = "Prueba";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(71, 236);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 294);
            Controls.Add(btnNuevo);
            Controls.Add(btnPrueba);
            Controls.Add(btnSalir);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Button btnIniciarSesion;
        private Label label2;
        private TextBox txtPassword;
        private Button btnSalir;
        private Button btnPrueba;
        private Button btnNuevo;
        
    }
}

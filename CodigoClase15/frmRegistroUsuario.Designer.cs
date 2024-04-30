namespace CodigoClase15
{
    partial class frmRegistroUsuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cbCasado = new CheckBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnAnalizar = new Button();
            lblMayorEdad = new Label();
            lblCasado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 26);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 70);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 117);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 3;
            label3.Text = "FechaNacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 168);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 4;
            label4.Text = "EsCasado";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(179, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(288, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(182, 67);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(285, 27);
            txtApellido.TabIndex = 6;
            // 
            // cbCasado
            // 
            cbCasado.AutoSize = true;
            cbCasado.Location = new Point(182, 171);
            cbCasado.Name = "cbCasado";
            cbCasado.Size = new Size(18, 17);
            cbCasado.TabIndex = 7;
            cbCasado.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(182, 110);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(285, 27);
            dtpFechaNacimiento.TabIndex = 8;
            // 
            // btnAnalizar
            // 
            btnAnalizar.BackColor = SystemColors.ActiveCaption;
            btnAnalizar.Location = new Point(182, 222);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(123, 50);
            btnAnalizar.TabIndex = 9;
            btnAnalizar.Text = "Analizar";
            btnAnalizar.UseVisualStyleBackColor = false;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // lblMayorEdad
            // 
            lblMayorEdad.AutoSize = true;
            lblMayorEdad.BackColor = Color.Yellow;
            lblMayorEdad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMayorEdad.Location = new Point(63, 330);
            lblMayorEdad.Name = "lblMayorEdad";
            lblMayorEdad.Size = new Size(169, 41);
            lblMayorEdad.TabIndex = 10;
            lblMayorEdad.Text = "MayorEdad";
            // 
            // lblCasado
            // 
            lblCasado.AutoSize = true;
            lblCasado.BackColor = Color.Yellow;
            lblCasado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCasado.Location = new Point(262, 330);
            lblCasado.Name = "lblCasado";
            lblCasado.Size = new Size(116, 41);
            lblCasado.TabIndex = 11;
            lblCasado.Text = "Casado";
            // 
            // frmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 417);
            Controls.Add(lblCasado);
            Controls.Add(lblMayorEdad);
            Controls.Add(btnAnalizar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(cbCasado);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistroUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private CheckBox cbCasado;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnAnalizar;
        private Label lblMayorEdad;
        private Label lblCasado;
    }
}
namespace CodigoClase15
{
    partial class frmRegistroProducto
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPrecio = new TextBox();
            Categoria = new Label();
            cbCategoria = new ComboBox();
            btnGrabar = new Button();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 70);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(298, 71);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 3;
            // 
            // Categoria
            // 
            Categoria.AutoSize = true;
            Categoria.Location = new Point(444, 78);
            Categoria.Name = "Categoria";
            Categoria.Size = new Size(74, 20);
            Categoria.TabIndex = 4;
            Categoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Frutas", "Verduras", "Electro" });
            cbCategoria.Location = new Point(533, 75);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(151, 28);
            cbCategoria.TabIndex = 5;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(694, 74);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(102, 153);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(582, 188);
            dgvProductos.TabIndex = 7;
            // 
            // frmRegistroProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductos);
            Controls.Add(btnGrabar);
            Controls.Add(cbCategoria);
            Controls.Add(Categoria);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "frmRegistroProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistroProducto";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtPrecio;
        private Label Categoria;
        private ComboBox cbCategoria;
        private Button btnGrabar;
        private DataGridView dgvProductos;
    }
}
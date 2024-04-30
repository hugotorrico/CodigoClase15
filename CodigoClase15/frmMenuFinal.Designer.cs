namespace CodigoClase15
{
    partial class frmMenuFinal
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
            menuStrip1 = new MenuStrip();
            productoToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem1 = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            enBlancoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productoToolStripMenuItem, usuarioToolStripMenuItem, enBlancoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroToolStripMenuItem, listarToolStripMenuItem });
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(83, 24);
            productoToolStripMenuItem.Text = "Producto";
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(147, 26);
            registroToolStripMenuItem.Text = "Registro";
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(147, 26);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroToolStripMenuItem1, loginToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(73, 24);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // registroToolStripMenuItem1
            // 
            registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            registroToolStripMenuItem1.Size = new Size(224, 26);
            registroToolStripMenuItem1.Text = "Registro";
            registroToolStripMenuItem1.Click += registroToolStripMenuItem1_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(224, 26);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // enBlancoToolStripMenuItem
            // 
            enBlancoToolStripMenuItem.Name = "enBlancoToolStripMenuItem";
            enBlancoToolStripMenuItem.Size = new Size(88, 24);
            enBlancoToolStripMenuItem.Text = "En Blanco";
            enBlancoToolStripMenuItem.Click += enBlancoToolStripMenuItem_Click;
            // 
            // frmMenuFinal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenuFinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenuFinal";
            Load += frmMenuFinal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem enBlancoToolStripMenuItem;
    }
}
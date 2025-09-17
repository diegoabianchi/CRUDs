namespace TPGestionEmpresa
{
    partial class frmPrincipal
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
            btnProveedores = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            SuspendLayout();
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(72, 53);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(148, 52);
            btnProveedores.TabIndex = 0;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(72, 138);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(148, 52);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(72, 226);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(148, 52);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 353);
            Controls.Add(btnProductos);
            Controls.Add(btnClientes);
            Controls.Add(btnProveedores);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProveedores;
        private Button btnClientes;
        private Button btnProductos;
    }
}

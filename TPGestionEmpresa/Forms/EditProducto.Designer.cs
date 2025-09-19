namespace TPGestionEmpresa.Forms
{
    partial class EditProducto
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
            label4 = new Label();
            btnGuardar = new Button();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboProveedor = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 188);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 23;
            label4.Text = "Proveedor";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(210, 240);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(150, 137);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(135, 23);
            txtStock.TabIndex = 21;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(150, 97);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(135, 23);
            txtPrecio.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(135, 23);
            txtNombre.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 140);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 18;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 100);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 17;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 57);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre";
            // 
            // comboProveedor
            // 
            comboProveedor.FormattingEnabled = true;
            comboProveedor.Location = new Point(150, 185);
            comboProveedor.Name = "comboProveedor";
            comboProveedor.Size = new Size(135, 23);
            comboProveedor.TabIndex = 24;
            // 
            // EditProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 354);
            Controls.Add(comboProveedor);
            Controls.Add(label4);
            Controls.Add(btnGuardar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditProducto";
            Text = "EditProducto";
            Load += EditProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnGuardar;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboProveedor;
    }
}
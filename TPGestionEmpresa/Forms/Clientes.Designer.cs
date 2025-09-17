namespace TPGestionEmpresa
{
    partial class Clientes
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
            btnEliminar = new Button();
            btnAgregar = new Button();
            dataGridClientes = new DataGridView();
            btnEditar2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(245, 37);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(40, 37);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridClientes
            // 
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Location = new Point(40, 78);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientes.Size = new Size(719, 335);
            dataGridClientes.TabIndex = 5;
            // 
            // btnEditar2
            // 
            btnEditar2.Location = new Point(138, 37);
            btnEditar2.Name = "btnEditar2";
            btnEditar2.Size = new Size(75, 23);
            btnEditar2.TabIndex = 11;
            btnEditar2.Text = "Editar";
            btnEditar2.UseVisualStyleBackColor = true;
            btnEditar2.Click += btnEditar2_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 447);
            Controls.Add(btnEditar2);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridClientes);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView dataGridClientes;
        private Button btnEditar2;
    }
}
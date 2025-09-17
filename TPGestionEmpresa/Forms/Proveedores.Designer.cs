namespace TPGestionEmpresa
{
    partial class Proveedores
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
            dataGridProveedores = new DataGridView();
            btnTest = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProveedores).BeginInit();
            SuspendLayout();
            // 
            // dataGridProveedores
            // 
            dataGridProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProveedores.Location = new Point(29, 88);
            dataGridProveedores.Name = "dataGridProveedores";
            dataGridProveedores.ReadOnly = true;
            dataGridProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProveedores.Size = new Size(586, 335);
            dataGridProveedores.TabIndex = 0;
            dataGridProveedores.CellContentClick += dataGridProveedores_CellContentClick;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(500, 47);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(115, 23);
            btnTest.TabIndex = 1;
            btnTest.Text = "Probar Conexión";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(29, 47);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(123, 47);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(220, 47);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 460);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnTest);
            Controls.Add(dataGridProveedores);
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridProveedores;
        private Button btnTest;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}
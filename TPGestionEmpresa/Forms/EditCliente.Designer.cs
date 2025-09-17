namespace TPGestionEmpresa
{
    partial class EditCliente
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
            btnGuardar = new Button();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            dateTimePickerFecNac = new DateTimePicker();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(229, 259);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(169, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(135, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(169, 117);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(135, 23);
            txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(135, 23);
            txtNombre.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 160);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 120);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 76);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 199);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 14;
            label4.Text = "Fecha Nacimiento";
            // 
            // dateTimePickerFecNac
            // 
            dateTimePickerFecNac.Format = DateTimePickerFormat.Short;
            dateTimePickerFecNac.Location = new Point(169, 193);
            dateTimePickerFecNac.Name = "dateTimePickerFecNac";
            dateTimePickerFecNac.Size = new Size(135, 23);
            dateTimePickerFecNac.TabIndex = 15;
            // 
            // EditCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 355);
            Controls.Add(dateTimePickerFecNac);
            Controls.Add(label4);
            Controls.Add(btnGuardar);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCliente";
            Load += EditCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DateTimePicker dateTimePickerFecNac;
    }
}
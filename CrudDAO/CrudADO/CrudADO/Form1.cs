namespace CrudADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            AlumnoDB alumnoDB = new AlumnoDB();
            if (alumnoDB.TestConnection())
            {
                MessageBox.Show("OK!");
            }
            else
            {
                MessageBox.Show("Error al intentar conectar con la BD");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            AlumnoDB alumnoDB = new AlumnoDB();
            dataGridView1.DataSource = alumnoDB.Get();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                Form2 edit = new Form2(Id);
                edit.ShowDialog();
                Refresh();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        #region HELPER
        private int GetId()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            }
            return 0;
        }
        #endregion HELPER

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();  
            if (Id != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AlumnoDB alumnoDB = new AlumnoDB();
                    alumnoDB.Delete((int)Id);
                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }
    }
}

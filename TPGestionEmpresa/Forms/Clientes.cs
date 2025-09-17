using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPGestionEmpresa
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DataAccess.dsClientesTableAdapters.ClientesTableAdapter ta = new DataAccess.dsClientesTableAdapters.ClientesTableAdapter();
            DataAccess.dsClientes.ClientesDataTable dt = ta.GetData();

            dataGridClientes.DataSource = dt;
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridClientes.Rows[dataGridClientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EditCliente frm = new EditCliente();
            frm.ShowDialog();
            Refresh();
        }
        private void btnEditar2_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                EditCliente frm = new EditCliente(id);
                frm.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                DataAccess.dsClientesTableAdapters.ClientesTableAdapter ta = new DataAccess.dsClientesTableAdapters.ClientesTableAdapter();
                ta.Remove((int)id);
                Refresh();
            }
        }


    }
}

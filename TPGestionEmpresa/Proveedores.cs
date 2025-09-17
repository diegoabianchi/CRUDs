using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGestionEmpresa.ADO;


namespace TPGestionEmpresa
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            ProveedoresDB proveedorDB = new ProveedoresDB();
            dataGridProveedores.DataSource = proveedorDB.Get();
        }

        #region HELPER
        private int GetId()
        {
            if (dataGridProveedores.SelectedRows.Count > 0)
            {
                return (int)dataGridProveedores.SelectedRows[0].Cells["IdProveedor"].Value;
            }
            return 0;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ProveedoresDB proveedorDB = new ProveedoresDB();
            if (proveedorDB.TestConnection())
            {
                MessageBox.Show("OK!");
            }
            else
            {
                MessageBox.Show("Error al intentar conectar con la DB");
            }
        }
        #endregion HELPER

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEditProveedor frmEditProveedor = new FrmEditProveedor();
            frmEditProveedor.ShowDialog();
            Refresh();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                FrmEditProveedor frmEditProveedor = new FrmEditProveedor(Id);
                frmEditProveedor.ShowDialog();
                Refresh();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ProveedoresDB proveedorDB = new ProveedoresDB();
                    proveedorDB.Delete((int)Id);
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

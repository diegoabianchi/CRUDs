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
    public partial class FrmEditProveedor : Form
    {

        private int? Id;

        public FrmEditProveedor(int? id = null)
        {
            InitializeComponent();
            this.Id = id;
            if (this.Id != null)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            ProveedoresDB proveedorDB = new ProveedoresDB();
            Proveedor proveedor = proveedorDB.Get((int)Id);
            txtNombre.Text = proveedor.Nombre;
            txtApellido.Text = proveedor.Apellido;
            txtTelefono.Text = proveedor.Telefono;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProveedoresDB proveedorDB = new ProveedoresDB();
            try
            {
                if (Id == null)
                {
                    Proveedor proveedor = new Proveedor
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Telefono = txtTelefono.Text
                    };
                    proveedorDB.Add(proveedor);
                    //MessageBox.Show("Proveedor agregado con éxito");
                }
                else
                {
                    Proveedor proveedor = new Proveedor
                    {
                        IdProveedor = (int)Id,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Telefono = txtTelefono.Text
                    };
                    proveedorDB.Update(proveedor);
                    //MessageBox.Show("Proveedor modificado con éxito");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

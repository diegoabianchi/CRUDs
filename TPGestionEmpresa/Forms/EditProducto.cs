using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPGestionEmpresa.Forms
{
    public partial class EditProducto : Form
    {
        public int? id;
        Models.Producto oProducto = null;
        public EditProducto(int? id = null)
        {
            InitializeComponent();
            CargarProveedores();
            this.id = id;
            if (id != null)
            {
                CargaDatosProducto();
            }
        }
        private void CargaDatosProducto()
        {
            using (var context = new Models.GestionEmpresaContext())
            {
                oProducto = context.Productos.Find(id);
                txtNombre.Text = oProducto.NombreProducto.ToString();
                txtPrecio.Text = oProducto.Precio.ToString();
                txtStock.Text = oProducto.Stock.ToString();
                comboProveedor.SelectedValue = oProducto.IdProveedor;
            }
        }
        private void CargarProveedores()
        {
            using (var context = new Models.GestionEmpresaContext())
            {
                var proveedores = context.Proveedores.ToList();
                comboProveedor.DataSource = proveedores;
                comboProveedor.DisplayMember = "NombreCompleto"; // Nombre a mostrar
                comboProveedor.ValueMember = "IdProveedor"; // Valor asociado
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new Models.GestionEmpresaContext())
            {
                if (oProducto == null)
                {
                    // Creacion de nuevo alumno
                    Models.Producto newProducto = new Models.Producto
                    {
                        NombreProducto = txtNombre.Text,
                        Precio = decimal.Parse(txtPrecio.Text),
                        Stock = int.Parse(txtStock.Text),
                        IdProveedor = (int)comboProveedor.SelectedValue // Asigna el proveedor seleccionado
                    };
                    context.Productos.Add(newProducto);
                }
                else
                {
                    // Modificacion 
                    oProducto.NombreProducto = txtNombre.Text;
                    oProducto.Precio = decimal.Parse(txtPrecio.Text);
                    oProducto.Stock = int.Parse(txtStock.Text);
                    oProducto.IdProveedor = (int)comboProveedor.SelectedValue; // Actualizar el proveedor
                    context.Entry(oProducto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }

                context.SaveChanges();
                this.Close();
            }
        }

        private void EditProducto_Load(object sender, EventArgs e)
        {
            return;
        }
    }
}

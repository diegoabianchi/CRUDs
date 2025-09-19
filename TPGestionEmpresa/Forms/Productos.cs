using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGestionEmpresa.Models;

namespace TPGestionEmpresa.Forms
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EditProducto frm = new EditProducto();
            frm.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                EditProducto frm = new EditProducto(id);
                frm.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (var context = new Models.GestionEmpresaContext())
                {
                    var prod = context.Productos.Find(id);
                    if (prod != null)
                    {
                        context.Productos.Remove(prod);
                        context.SaveChanges();
                    }
                }
                Refresh();
            }
        }



        #region HELPER
        private void Refresh()
        {
            using (var context = new Models.GestionEmpresaContext())
            {
                /*var listProductos = context.Productos.ToList();
                dataGridProductos.DataSource = listProductos;*/

                var lst = context.Productos
                            .Join(context.Proveedores,
                                  p => p.IdProveedor,
                                  pr => pr.IdProveedor,
                                  (p, pr) => new ProductoViewModel
                                  {
                                      IdProducto = p.IdProducto,
                                      NombreProducto = p.NombreProducto,
                                      Precio = p.Precio,
                                      Stock = (int) p.Stock,
                                      NombreProveedor = pr.NombreCompleto
                                  })
                            .ToList();


                /*from p in context.Productos
                      join pr in context.Proveedores on p.IdProveedor equals pr.IdProveedor
                      select new ProductoViewModel
                      {
                          IdProducto = p.IdProducto,
                          NombreProducto = p.NombreProducto,
                          Precio = p.Precio,
                          Stock = p.Stock,
                          NombreProveedor = pr.Nombre
                      };*/

                dataGridProductos.DataSource = lst;

            }
        }
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridProductos.Rows[dataGridProductos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}

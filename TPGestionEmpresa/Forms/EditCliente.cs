using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TPGestionEmpresa
{
    public partial class EditCliente : Form
    {
        private int? id;
        public EditCliente(int? id = null)
        {
            InitializeComponent();
            this.id = id;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataAccess.dsClientesTableAdapters.ClientesTableAdapter ta = new DataAccess.dsClientesTableAdapters.ClientesTableAdapter();
            if (id == null)
            {
                ta.Add(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtEmail.Text.Trim(), dateTimePickerFecNac.Value.ToString());
            }
            else
            {
                ta.Edit(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtEmail.Text.Trim(), dateTimePickerFecNac.Value.ToString(), (int)id);
            }

            this.Close();
        }

        private void EditCliente_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                DataAccess.dsClientesTableAdapters.ClientesTableAdapter ta = new DataAccess.dsClientesTableAdapters.ClientesTableAdapter();
                DataAccess.dsClientes.ClientesDataTable dt = ta.GetDataById((int)id);
                DataAccess.dsClientes.ClientesRow row = (DataAccess.dsClientes.ClientesRow)dt.Rows[0];
                txtNombre.Text = row.Nombre;
                txtApellido.Text = row.Apellido;
                txtEmail.Text = row.Email;
                dateTimePickerFecNac.Value = row.FechaNacimiento;
            }
        }
    }
}

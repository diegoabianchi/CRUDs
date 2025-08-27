using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudDS
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DataSet1TableAdapters.AlumnosTableAdapter ta = new DataSet1TableAdapters.AlumnosTableAdapter();
            DataSet1.AlumnosDataTable dt = ta.GetData();
            dataGridView1.DataSource = dt;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAlumnos frm = new FrmAlumnos();
            frm.ShowDialog();
            Refresh();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch 
            { 
                return null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null) {
                FrmAlumnos frm = new FrmAlumnos(id);
                frm.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                DataSet1TableAdapters.AlumnosTableAdapter ta = new DataSet1TableAdapters.AlumnosTableAdapter();
                ta.Remove((int)id);
                Refresh();
            }
        }
    }
}

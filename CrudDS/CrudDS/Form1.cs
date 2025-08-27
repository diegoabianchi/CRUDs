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
    }
}

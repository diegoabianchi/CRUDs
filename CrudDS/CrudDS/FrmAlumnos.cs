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
    public partial class FrmAlumnos : Form
    {
        private int? id;
        public FrmAlumnos(int? id=null)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AlumnosTableAdapter ta = new DataSet1TableAdapters.AlumnosTableAdapter();
            if (id == null)
            {
                ta.Add(txtName.Text.Trim(), txtLastname.Text.Trim(), int.Parse(txtAge.Text));
            }
            else
            {
                ta.Edit(txtName.Text.Trim(), txtLastname.Text.Trim(), int.Parse(txtAge.Text), (int)id);
            }

            this.Close();
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            if(id != null)
            {
                DataSet1TableAdapters.AlumnosTableAdapter ta = new DataSet1TableAdapters.AlumnosTableAdapter();
                DataSet1.AlumnosDataTable dt = ta.GetDataById((int)id);
                DataSet1.AlumnosRow row = (DataSet1.AlumnosRow) dt.Rows[0];
                txtName.Text = row.name;
                txtLastname.Text = row.lastname;
                txtAge.Text = row.age.ToString();
            }
        }
    }
}

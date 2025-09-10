using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crudEntityFramework.Models;

namespace crudEntityFramework
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Presentation.FrmAlumno frm = new Presentation.FrmAlumno();
            frm.ShowDialog();
            refresh();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Presentation.FrmAlumno frmTabla = new Presentation.FrmAlumno(id);
                frmTabla.ShowDialog();
                refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (CrudWindowsFormEntities db = new CrudWindowsFormEntities())
                {
                    Alumnos oAlumno = db.Alumnos.Find(id);
                    db.Alumnos.Remove(oAlumno);
                    db.SaveChanges();
                }
                refresh();
            }
        }

        #region HELPER
        private void refresh() //Esto seria como el SELECT * de la tabla
        {
            using (CrudWindowsFormEntities db = new CrudWindowsFormEntities())
            {
                var lst = from a in db.Alumnos
                          select a;
                dataGridView1.DataSource = lst.ToList();
            }
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
        #endregion


    }
}

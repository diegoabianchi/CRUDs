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

namespace crudEntityFramework.Presentation
{
    public partial class FrmAlumno : Form
    {
        public int? id;
        Alumnos oAlumno = null;
        public FrmAlumno(int? id=null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
            {
                CargaDatosAlumno();
            }
        }

        private void CargaDatosAlumno()
        {
            using (CrudWindowsFormEntities db = new CrudWindowsFormEntities())
            {
                oAlumno = db.Alumnos.Find(id);
                txtApellido.Text = oAlumno.lastname.ToString();
                txtNombre.Text = oAlumno.name.ToString();
                txtEdad.Text = oAlumno.age.ToString();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (CrudWindowsFormEntities db = new CrudWindowsFormEntities())
            {
                
                if (oAlumno == null)
                {
                    // Creacion de nuevo alumno
                    Alumnos newAlumno = new Alumnos();
                    newAlumno.name = txtNombre.Text;
                    newAlumno.lastname = txtApellido.Text;
                    newAlumno.age = int.Parse(txtEdad.Text);

                    db.Alumnos.Add(newAlumno);
                }
                else
                {
                    // Modificacion 
                    oAlumno.name = txtNombre.Text;
                    oAlumno.lastname = txtApellido.Text;
                    oAlumno.age = int.Parse(txtEdad.Text);

                    db.Entry(oAlumno).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                this.Close();
            }

        }

        private void FrmTabla_Load(object sender, EventArgs e)
        {

        }
    }
}

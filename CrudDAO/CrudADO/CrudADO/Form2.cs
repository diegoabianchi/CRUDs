using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudADO
{
    public partial class Form2 : Form
    {
        private int? Id;

        public Form2(int? id=null)
        {
            InitializeComponent();
            this.Id = id;
            if(this.Id != null)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            AlumnoDB alumnoDB = new AlumnoDB();
            Alumno alumno = alumnoDB.Get((int)Id);
            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;  
            txtEdad.Text = alumno.Edad.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AlumnoDB alumnoDB = new AlumnoDB();
            try
            {
                if(Id == null)
                {
                    Alumno alumno = new Alumno
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Edad = int.Parse(txtEdad.Text)
                    };
                    alumnoDB.Add(alumno);
                    MessageBox.Show("Alumno agregado con éxito");
                }
                else
                {
                    Alumno alumno = new Alumno
                    {
                        Id = (int)Id,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Edad = int.Parse(txtEdad.Text)
                    };
                    alumnoDB.Update(alumno);
                    MessageBox.Show("Alumno modificado con éxito");
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

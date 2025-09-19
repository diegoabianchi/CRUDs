using TPGestionEmpresa.Forms;

namespace TPGestionEmpresa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        //Menu principal
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Proveedores());
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Clientes());
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Productos());
        }


        // Metodo para abrir formularios dentro de un panel
        private void AbrirFormEnPanel(Form formHijo)
        {
            // Elimino cualquier control que ya esté dentro del panel
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);
            }

            // Configuro el formulario hijo
            formHijo.TopLevel = false; // Muy importante: lo hace un "control"
            formHijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes ni barra de título
            formHijo.Dock = DockStyle.Fill; // Para que ocupe todo el panel

            // Agrego el form al panel y lo muestro
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leguanjes de última generación\nTP Gestión de Empresa\n\nDesarrollado por Diego Ariel Bianchi\nAño 2025", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

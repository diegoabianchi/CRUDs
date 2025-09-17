namespace TPGestionEmpresa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores frmProveed = new Proveedores();
            frmProveed.ShowDialog();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes frmClientes = new Clientes();
            frmClientes.ShowDialog();
        }
    }
}

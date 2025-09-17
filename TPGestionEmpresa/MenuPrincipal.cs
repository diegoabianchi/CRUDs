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
    }
}

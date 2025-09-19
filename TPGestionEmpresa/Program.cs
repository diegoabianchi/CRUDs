namespace TPGestionEmpresa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPrincipal());

            using (var context = new Models.GestionEmpresaContext())
            {
                var listProductos = context.Productos.ToList();
                foreach (var prod in listProductos)
                {
                    Console.WriteLine($"IdProducto: {prod.IdProducto}, Producto: {prod.NombreProducto}, Precio: {prod.Precio}");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TPGestionEmpresa.ADO
{
    internal class ProveedoresDB
    {
        private string connectionString = "Server=localhost;Database=GestionEmpresa;User Id=sa;Password=123456;TrustServerCertificate=True;";

        public bool TestConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public List<Proveedor> Get()
        {
            List<Proveedor> listProveedor = new List<Proveedor>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT IdProveedor, Nombre, Apellido, Telefono FROM Proveedores";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Proveedor proveedor = new Proveedor
                                {
                                    IdProveedor = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Apellido = reader.GetString(2),
                                    Telefono = reader.GetString(3)
                                };
                                listProveedor.Add(proveedor);
                            }
                            reader.Close();
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listProveedor;
        }

        public Proveedor Get(int IdProveed)
        {
            Proveedor proveedor = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT IdProveedor, Nombre, Apellido, Telefono FROM Proveedores WHERE IdProveedor = @idProveed";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idProveed", IdProveed);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                proveedor = new Proveedor
                                {
                                    IdProveedor = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Apellido = reader.GetString(2),
                                    Telefono = reader.GetString(3)
                                };
                            }
                            reader.Close();
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return proveedor;
        }

        public void Add(Proveedor proveedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Proveedores (Nombre, Apellido, Telefono) VALUES (@nombre, @apellido, @telefono)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                        command.Parameters.AddWithValue("@apellido", proveedor.Apellido);
                        command.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(Proveedor proveedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Proveedores SET Nombre = @nombre, Apellido = @apellido, Telefono = @telefono WHERE IdProveedor = @idProveed";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                        command.Parameters.AddWithValue("@apellido", proveedor.Apellido);
                        command.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                        command.Parameters.AddWithValue("@idProveed", proveedor.IdProveedor);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int IdProveed)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Proveedores WHERE IdProveedor = @IdProveed";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@IdProveed", IdProveed);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
    }

}

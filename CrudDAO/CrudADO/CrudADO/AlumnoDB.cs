using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CrudADO
{
    public class AlumnoDB
    {
        private string connectionString = "Server=localhost;Database=CrudWindowsForm;User Id=sa;Password=123456;TrustServerCertificate=True;";

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

        public List<Alumno> Get()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT id, name, lastname, age FROM Alumnos";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Alumno alumno = new Alumno
                                {
                                    Id = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Apellido = reader.GetString(2),
                                    Edad = reader.GetInt32(3)
                                };
                                alumnos.Add(alumno);
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
            return alumnos;
        }

        public Alumno Get(int Id)
        {
            Alumno alumno = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT id, name, lastname, age FROM Alumnos WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", Id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                alumno = new Alumno
                                {
                                    Id = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Apellido = reader.GetString(2),
                                    Edad = reader.GetInt32(3)
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
            return alumno;
        }

        public void Add(Alumno alumno)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Alumnos (name, lastname, age) VALUES (@name, @lastname, @age)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", alumno.Nombre);
                        command.Parameters.AddWithValue("@lastname", alumno.Apellido);
                        command.Parameters.AddWithValue("@age", alumno.Edad);
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

        public void Update(Alumno alumno)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Alumnos SET name = @name, lastname = @lastname, age = @age WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", alumno.Nombre);
                        command.Parameters.AddWithValue("@lastname", alumno.Apellido);
                        command.Parameters.AddWithValue("@age", alumno.Edad);
                        command.Parameters.AddWithValue("@id", alumno.Id);
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

        public void Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Alumnos WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
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

    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}

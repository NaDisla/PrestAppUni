/*using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PrestApp.Generic;
namespace PrestApp.Clases
{
    public static class ClDataBase
    {
        static string connectionString = @"data source=(localdb)\Server Local;initial catalog=DB_PrestApp;user id=sa_v2;password=nd-123456;Connect Timeout=60";
        public static List<ClRoles> ObtenerRoles()
        {
            List<ClRoles> listaRoles = new List<ClRoles>();
            string sql = "SELECT * FROM Roles";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClRoles rol = new ClRoles()
                            {
                                Rol_ID = reader.GetInt32(0),
                                Rol_Nombre = reader.GetString(1),
                            };
                            listaRoles.Add(rol);
                        }
                    }
                }
                con.Close();
                return listaRoles;
            }
        }
        public static void AgregarRol(ClRoles rol)
        {
            string sql = "INSERT INTO Empleados (Nombre,Salario) VALUES(@nombre, @salario)";
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    comando.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = empleado.Nombre;
                    comando.Parameters.Add("@salario", SqlDbType.Decimal).Value = empleado.Salario;
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        public static void ModificarEmpleado(Empleados empleado)
        {
            string sql = "UPDATE Empleados set Nombre = @nombre, Salario = @salario WHERE ID = @id";
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();
                    using (SqlCommand comando = new SqlCommand(sql, con))
                    {
                        comando.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = empleado.Nombre;
                        comando.Parameters.Add("@salario", SqlDbType.Decimal).Value = empleado.Salario;
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = empleado.ID;
                        comando.CommandType = CommandType.Text;
                        comando.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }
        public static void EliminarEmpleado(Empleados empleado)
        {
            string sql = "DELETE FROM Empleados WHERE ID = @id";
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand(sql, con))
                {
                    comando.Parameters.Add("@id", SqlDbType.Int).Value = empleado.ID;
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
*/

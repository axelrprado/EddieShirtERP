using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
       public List<Usuario> Listar(){
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //Revisar
                    string query = "SELECT * FROM Usuario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    // Para leer los registros
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) {
                            // Agregar los registros a la lista
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                NombreUsuario = Convert.ToString(dr["NombreUsuario"]),
                                NombreCompleto = Convert.ToString(dr["NombreCompleto"]),
                                Correo = Convert.ToString(dr["Correo"]),
                                Clave = Convert.ToString(dr["Clave"]),
                            });
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            // Regresar los registros
            return lista;
        }
    }
}

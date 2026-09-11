using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Competiciones.Repositorio
{
    public abstract class RepositorioMaestro : repositorio
    {
        private DataTable dtTablaDatos; //Aqui se establece la tabla de datos para las consultas
        public int EjecucionNonQuery(string _comandoTexto, List<OdbcParameter> _parametros, CommandType _comandoTipo)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var ocComando = new OdbcCommand())
                {
                    ocComando.Connection = conexion;
                    ocComando.CommandText = _comandoTexto;
                    ocComando.CommandType = _comandoTipo;
                    ocComando.Parameters.AddRange(_parametros.ToArray()); //Agrega los parámetros al comando
                    return ocComando.ExecuteNonQuery();
                }
            }
        }
        public DataTable EjecucionConsulta(string _comandoTexto, CommandType _comandoTipo)
        {
            dtTablaDatos = new DataTable();
            using (var conexion = ObtenerConexion()) // Obtener la conexión de la BD
            {
                conexion.Open();
                using (var ocComando = new OdbcCommand())
                {
                    ocComando.Connection = conexion;
                    ocComando.CommandText = _comandoTexto;
                    ocComando.CommandType = _comandoTipo;
                    using(var reader = ocComando.ExecuteReader())
                        dtTablaDatos.Load(reader); // llenar la tabla de datos con el resultado de la consulta
                }
                return dtTablaDatos; // Retorna la tabla de datos con el resultado de la consulta
            }
        }
    } 
    
}
        


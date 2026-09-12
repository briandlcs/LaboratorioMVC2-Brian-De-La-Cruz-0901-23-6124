using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Competiciones.Repositorio
{
    public abstract class repositorio
    {
        public readonly string connectionString;
        public repositorio()
        {
           connectionString = "Dsn=Local Instance MySQL80;Uid=root;Pwd=localhost123";
        }
        protected OdbcConnection ObtenerConexion()
        {
            return new OdbcConnection(connectionString);
        }
    }
}

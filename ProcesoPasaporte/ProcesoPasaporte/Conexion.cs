using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesoPasaporte
{
    class Conexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=Pasport");// creacion de la conexion via ODBC
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No hay conexion!");
            }
            return conn;
        }
    }
}

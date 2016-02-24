using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Database
    {
        private SqlConnection conn;

        public SqlConnection ConectaDb()
        {
            try
            {
                //Integrated Security=True: Que se estan conectando al SQL SERVER
                //con Autenticacion Windows
                string cadenadeconexion = "Data Source=localhost;Initial Catalog=dbObjetosPerdidos;Integrated Security=True";
                conn = new SqlConnection(cadenadeconexion);
                conn.Open();
                return conn;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public void DesconectaDb()
        {
            conn.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dObjetoEncontrado
    {
        Database db = new Database();

        public string Insertar(ObjetoEncontrado o)
        {
            try
            {
                //TODO: :)
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("Insert into Obj_Perdido(Nombre_Objeto,Fecha) values('{0}','{1}')", o.NombreObjetoEncontrado, o.Fecha);//**aumentado recién
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Objeto registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                // SIEMPRE SE VA A EJECUTAR=EXITO O FRACASO
                db.DesconectaDb();
            }
        }

        public string Modificar(ObjetoEncontrado o)
        {
            try
            {
                //TODO: :)
                SqlConnection con = db.ConectaDb();
                string update = string.Format("UPDATE Obj_Perdido SET Nombre_Objeto='{0}', Fecha='{1}' where IdObjPerdido='{2}'", o.NombreObjetoEncontrado, o.Fecha, o.IdObjetoEncontrado);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Objeto modificado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                //TODO: :)
                SqlConnection con = db.ConectaDb();
                string delete = string.Format("DELETE from Obj_Perdido WHERE IdObjPerdido={0}", id);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Objeto eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        public ObjetoEncontrado BuscarPorId(int id)
        {
            try
            {
                ObjetoEncontrado objeto = null;
                SqlConnection con = db.ConectaDb();
                string select = string.Format("select IdObjPerdido,Nombre_Objeto,Fecha from Obj_Perdido where IdObjPerdido={0}", id);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    objeto = new ObjetoEncontrado();
                    objeto.IdObjetoEncontrado = (int)reader["IdObjPerdido"];
                    objeto.NombreObjetoEncontrado = (string)reader["Nombre_Objeto"];
                    objeto.Fecha = (string)reader["Fecha"];
                }
                reader.Close();
                return objeto;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        public List<ObjetoEncontrado> ListarTodo()
        {
            try
            {
                //TODO: :))
                List<ObjetoEncontrado> lsObjetoEncontrado = new List<ObjetoEncontrado>();
                ObjetoEncontrado objeto = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select IdObjPerdido,Nombre_Objeto,Fecha from Obj_Perdido", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objeto = new ObjetoEncontrado();
                    objeto.IdObjetoEncontrado = (int)reader["IdObjPerdido"];
                    objeto.NombreObjetoEncontrado = (string)reader["Nombre_Objeto"];
                    objeto.Fecha = (string)reader["Fecha"];
                    lsObjetoEncontrado.Add(objeto);
                }
                reader.Close();
                return lsObjetoEncontrado;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}

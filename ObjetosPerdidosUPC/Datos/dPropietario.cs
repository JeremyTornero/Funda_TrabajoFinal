using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    class dPropietario
    {
        Database db = new Database();
        public string Insertar(Propietario o)
        {
            try
            {
                //TODO: :)
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("Insert into Propietario(Nombre, Apellidos, IdObjPerdido, Fecha) values('{0}','{1}',{2},{3})", o.Nombre, o.Apellido, o.Objeto.IdObjetoEncontrado, o.Fecha);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "El propietario fue registrado correctamente";
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

        public string Modificar(Propietario o)
        {
            try
            {
                //TODO: :)
                SqlConnection con = db.ConectaDb();
                string update = string.Format("UPDATE Propietario SET Nombre='{0}', Apellidos='{1}',IdObjPerdido={2} where IdAlumno={3}", o.Nombre, o.Apellido, o.Objeto.IdObjetoEncontrado, o.IdPropietario);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "El nombre del propietario fue modificado correctamente)";
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
                string delete = string.Format("DELETE from Propietario WHERE IdAlumno={0}", id);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "El nombre del propietario fue eliminado correctamente";
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

        public Propietario BuscarPorId(int id)
        {
            try
            {
                Propietario propietario = null;
                ObjetoEncontrado objeto = null;
                SqlConnection con = db.ConectaDb();
                string select = string.Format("select prop.IdAlumno,prop.Nombre, prop.Apellidos, obj.Nombre_Objeto as Obj_Perdido,obj.IdObjPerdido  from Obj_Perdido as obj,Propietario as prop  where obj.IdObjPerdido=prop.IdObjPerdido and prop.IdAlumno={0}", id);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    propietario = new Propietario();
                    objeto = new ObjetoEncontrado();
                    propietario.IdPropietario = (int)reader["IdAlumno"];
                    propietario.Nombre = (string)reader["Nombre"];
                    propietario.Apellido = (string)reader["Apellidos"];
                    //propietario.Fecha = (DateTime)reader["Fecha"];
                    objeto.NombreObjetoEncontrado = (string)reader["Obj_Perdido"];
                    propietario.Objeto = objeto;
                }
                reader.Close();
                return propietario;
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

        public List<Propietario> ListarTodo()
        {
            try
            {
                //TODO: :))
                List<Propietario> lsPropietario = new List<Propietario>();
                Propietario propietario = null;
                ObjetoEncontrado objeto = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select prop.IdAlumno,prop.Nombre, prop.Apellidos, obj.Nombre_Objeto, prop.Fecha as Obj_Perdido,obj.IdObjPerdido  from Obj_Perdido as obj,Propietario as prop  where obj.IdObjPerdido=prop.IdObjPerdido", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    propietario = new Propietario();
                    objeto = new ObjetoEncontrado();
                    propietario.IdPropietario = (int)reader["IdAlumno"];
                    propietario.Nombre = (string)reader["Nombre"];
                    propietario.Apellido = (string)reader["Apellidos"];
                    //propietario.Fecha = (DateTime)reader["Fecha"];
                    objeto.NombreObjetoEncontrado = (string)reader["Obj_Perdido"];
                    propietario.Objeto = objeto;

                    lsPropietario.Add(propietario);
                }
                reader.Close();
                return lsPropietario;
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

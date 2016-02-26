using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dPropietario
    {
        Database db = new Database();
        public string Insertar(Propietario o)
        {
            try
            {
                //TODO: :)
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("Insert into Propietario(Nombre, Apellidos, IdObjPerdido, Fecha, Fecha_Devolucion) values('{0}','{1}','{2}','{3}','{4}')", o.Nombre, o.Apellidos, o.Objeto.IdObjetoEncontrado, o.Fecha_Ingreso,o.Fecha_Devolucion);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "El propietario fue registrado correctamente.";
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
                string update = string.Format("UPDATE Propietario SET Nombre='{0}', Apellidos='{1}',IdObjPerdido='{2}',Fecha='{3}', Fecha_Devolucion='{4}' where IdAlumno='{5}'", o.Nombre, o.Apellidos, o.Objeto.IdObjetoEncontrado, o.Fecha_Ingreso, o.Fecha_Devolucion, o.IdPropietario);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "El nombre del propietario fue modificado correctamente.";
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
                return "El nombre del propietario fue eliminado correctamente.";
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
                string select = string.Format("select prop.IdAlumno,prop.Nombre, prop.Apellidos, obj.Nombre_Objeto, obj.Fecha, prop.Fecha_Devolucion as Obj_Perdido,obj.IdObjPerdido  from Obj_Perdido as obj,Propietario as prop  where obj.IdObjPerdido=prop.IdObjPerdido and prop.IdAlumno={0}", id);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    propietario = new Propietario();
                    objeto = new ObjetoEncontrado();
                    propietario.IdPropietario = (int)reader["IdAlumno"];
                    propietario.Nombre = (string)reader["Nombre"];
                    propietario.Apellidos = (string)reader["Apellidos"];
                    objeto.NombreObjetoEncontrado = (string)reader["Obj_Perdido"];
                    objeto.Fecha = (string)reader["Fecha"];
                    propietario.Fecha_Devolucion = (string)reader["Fecha_Devolucion"];
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
                SqlCommand cmd = new SqlCommand("select prop.IdAlumno,prop.Nombre, prop.Apellidos, obj.Nombre_Objeto, obj.Fecha , prop.Fecha_Devolucion ,obj.IdObjPerdido  from Obj_Perdido as obj,Propietario as prop  where obj.IdObjPerdido=prop.IdObjPerdido", con);//, prop.Fecha
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    propietario = new Propietario();
                    objeto = new ObjetoEncontrado();
                    propietario.IdPropietario = (int)reader["IdAlumno"];
                    propietario.Nombre = (string)reader["Nombre"];
                    propietario.Apellidos = (string)reader["Apellidos"];
                    objeto.NombreObjetoEncontrado = (string)reader["Nombre_Objeto"];
                    objeto.Fecha = (string)reader["Fecha"];
                    propietario.Fecha_Devolucion = (string)reader["Fecha_Devolucion"];
                    propietario.Fecha_Ingreso = objeto.Fecha;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sol_Almacen.Presentacion
{
    public class D_Categorias
    {
        public DataTable Listado_ca(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                string sql_tarea = "SELECT codigo_ca," +
                                    " descripcion_ca" +
                                    " FROM tb_categorias" +
                                    " WHERE descripcion_ca LIKE '" + cTexto + "' " +
                                    " AND estado=1" +
                                    " ORDER BY codigo_ca";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);

                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Guardar_ca(int nOpcion, P_Categorias oCa)
        {
            string Rpta = "";
            string SqlTarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                if (nOpcion == 1) // Nuevo registro
                {
                    SqlTarea = "INSERT INTO tb_categorias(descripcion_ca, " +
                                                        " estado)" +
                                                        " VALUES('" + oCa.Descripcion_ca + "', 1)";
                }
                else // Actualizar registro
                {
                    SqlTarea = "UPDATE tb_categorias set descripcion_ca='" + oCa.Descripcion_ca + "'" +
                                                        " WHERE codigo_ca='" + oCa.Codigo_ca + "'";
                }
                MySqlCommand Comando = new MySqlCommand(SqlTarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro.";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return Rpta;
        }

        public string Eliminar_ar(int nCodigo_ca)
        {
            string Rpta = "";
            string SqlTarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                SqlTarea = "UPDATE tb_categorias SET estado=0 WHERE codigo_ca='" + nCodigo_ca + "'";

                MySqlCommand Comando = new MySqlCommand(SqlTarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro.";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return Rpta;
        }
    }
}

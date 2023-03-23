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
    public class D_UnidadMedida
    {

        public DataTable Listado_um(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                string sql_tarea = "SELECT codigo_um," +
                                    " descripcion_um" +
                                    " FROM tb_unidades_medida" +
                                    " WHERE descripcion_um LIKE '" + cTexto + "' " +
                                    " AND estado=1" +
                                    " ORDER BY codigo_um";
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

        public string Guardar_um(int nOpcion, P_UnidadMedida oUm)
        {
            string Rpta = "";
            string SqlTarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                if (nOpcion == 1) // Nuevo registro
                {
                    SqlTarea = "INSERT INTO tb_unidades_medida(descripcion_um, " +
                                                                " estado)" +
                                                                " VALUES('" + oUm.Descripcion_um + "', 1)";
                }
                else // Actualizar registro
                {
                    SqlTarea = "UPDATE tb_unidades_medida set descripcion_um='" + oUm.Descripcion_um + "'" +
                                                        " WHERE codigo_um='" + oUm.Codigo_um + "'";
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


        public string Eliminar_um(int nCodigo_um)
        {
            string Rpta = "";
            string SqlTarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                SqlTarea = "UPDATE tb_unidades_medida SET estado=0 WHERE codigo_um='" + nCodigo_um + "'";

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

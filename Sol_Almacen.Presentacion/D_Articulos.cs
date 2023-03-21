﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sol_Almacen.Presentacion
{
    public class D_Articulos
    {
        public DataTable Listado_ar(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                string sql_tarea = "SELECT a.codigo_ar," +
                                    " a.descripcion_ar," +
                                    " a.marca_ar," +
                                    " b.descripcion_um," +
                                    " c.descripcion_ca," +
                                    " a.stock_actual," +
                                    " a.codigo_um," +
                                    " a.codigo_ca" +
                                    " FROM tb_articulos a" +
                                    " INNER JOIN tb_unidades_medida b ON a.codigo_um=b.codigo_um" +
                                    " INNER JOIN tb_categorias c ON a.codigo_ca=c.codigo_ca" +
                                    " WHERE a.descripcion_ar LIKE '" + cTexto + "' " +
                                    " ORDER BY a.codigo_ar";
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

        public string Guardar_ar(int nOpcion,P_Articulos oAr)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                if (nOpcion==1) // Nuevo registro
                {

                }
                else // Actualizar registro
                {

                }
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

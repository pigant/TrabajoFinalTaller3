using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Servicios.servicios
{
    class ConexionDB
    {
        /**********************************************************/
        /* Definicion de parametros de clase */
        /**********************************************************/
        #region
        SqlConnection con;
        private string stringConexion1 = "Data Source=mssql4.gear.host; Initial Catalog=tallerprogra3;User ID=tallerprogra3; Password=Nx6ClP0U?42?";
        // private string stringConexion2 = "workstation id=tallerprogra3.mssql.somee.com;packet size=4096;user id=pigant_SQLLogin_1;pwd=f9k5lv77uy;data source=tallerprogra3.mssql.somee.com;initial catalog=tallerprogra3";
        #endregion

        /**********************************************************/
        /* Definicion de constructores */
        /**********************************************************/
        #region
        public ConexionDB() { }
        #endregion

        /**********************************************************/
        /* Definicion de metodos */
        /**********************************************************/
        #region
        
        /**
         * Permite la obtencion de listas por medio del select
         */
        public List<Object[]> ObtenerLista(String comando)
        {
            List<Object[]> lista = new List<object[]>();
            try
            {
                Conectar();
                lista = _ObtenerLista(comando);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
        private List<Object[]> _ObtenerLista(String comando)
        {
            List<Object[]> lista = new List<object[]>();
            SqlCommand comand = new SqlCommand(comando, con);
            SqlDataReader listaRaw = comand.ExecuteReader();
            if (listaRaw.HasRows)
            {
                while (listaRaw.Read())
                {
                    Object[] objs = new Object[listaRaw.FieldCount];
                    listaRaw.GetValues(objs);
                    lista.Add(objs);
                }
            }
            listaRaw.Close();
            return lista;
        }

        /**
         * Permite las operaciones  NonQuery
         */
        public void OperacionesNonQuery(String comando)
        {
            Action<String> funcion = _OperacionesNonQuery;
            Ejecutar(funcion, comando);
        }
        public void _OperacionesNonQuery(String comando)
        {
            SqlCommand comand = new SqlCommand(comando, con);
            comand.ExecuteNonQuery();
        }
        public Int32 OperacionesNonQueryReturnId(String comando)
        {
            Int32 salida = -1;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("select scope_identity();", con);
                salida =  Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Desconectar();
            }
            return salida;
        }

        private void Conectar()
        {
            con = new SqlConnection(stringConexion1);
            con.Open();
        }

        private void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    con.Close();
                }
                catch (SqlException)
                {

                }
            }
        }

        private void Ejecutar(Action<String> f, String parametro)
        {
            try
            {
                Conectar();
                f(parametro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Desconectar();
            }
        }
        public void EjecutarScript(String url)
        {
            Action<String> funcion = _EjecutarScript;
            Ejecutar(funcion, url);
        }

        private void _EjecutarScript(String url)
        {
            string script = File.ReadAllText(url);

            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"\r\nGO(\r\n|$)",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        using (var command = new SqlCommand(commandString, con))
                        {
                            Console.WriteLine("Ejecutando: {0}", commandString);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                Console.WriteLine("Se termino de ejecutar el script");
        }
        #endregion

        /**********************************************************/
        /* Definicion de Propiedades */
        /**********************************************************/
        #region
        #endregion


    }
}

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
        SqlConnection con;
        private string stringConexion1 = "Data Source=mssql4.gear.host; Initial Catalog=tallerprogra3;User ID=tallerprogra3; Password=Nx6ClP0U?42?";
        // private string stringConexion2 = "workstation id=tallerprogra3.mssql.somee.com;packet size=4096;user id=pigant_SQLLogin_1;pwd=f9k5lv77uy;data source=tallerprogra3.mssql.somee.com;initial catalog=tallerprogra3";

        public void Conectar()
        {
            con = new SqlConnection(stringConexion1);
            con.Open();
        }

        public void Desconectar()
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

        public void Ejecutar(Action<String> f, String parametro)
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
            funcion(url);
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
    }
}

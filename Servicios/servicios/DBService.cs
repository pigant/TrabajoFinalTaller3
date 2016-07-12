using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.servicios
{
    public class DBService
    {
        public static void ejecutarScript(String url)
        {
            ConexionDB db = new ConexionDB();
            db.EjecutarScript(url);
        }
    }
}

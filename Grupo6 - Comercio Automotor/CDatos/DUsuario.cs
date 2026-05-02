using CEntidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class DUsuario
    {
        // 1. Instancia Singleton
        private static DUsuario _instancia = null;

        // 2. Constructor privado
        private DUsuario() { }

        // 3. Propiedad para obtener la instancia única
        public static DUsuario Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new DUsuario();
                return _instancia;
            }
        }

        public EUsuario IniciarSesion(string user, string pass)
        {
            EUsuario objUsuario = null;
            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(Conexion.Instancia.CrearParametro("@Usuario", user));
            p.Add(Conexion.Instancia.CrearParametro("@Password", pass));

            DataTable dt = Conexion.Instancia.LeerStoredProcedure("sp_Login", p);

            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];
                objUsuario = new EUsuario
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Nombre = fila["Nombre"].ToString(),
                    Cuenta = fila["Usuario"].ToString(),
                    Correo = fila["Email"].ToString()
                };
            }
            return objUsuario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos;

namespace CNegocio
{
    public class NLogin
    {
        // 1. Instancia Singleton
        private static NLogin _instancia = null;

        // 2. Constructor privado
        private NLogin() { }

        // 3. Propiedad para obtener la instancia única
        public static NLogin Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new NLogin();
                return _instancia;
            }
        }

        public EUsuario ValidarAcceso(string usuario, string clave)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
                throw new Exception("El usuario y la contraseña son obligatorios.");

            // Uso del Singleton de la capa de datos
            EUsuario logueado = DUsuario.Instancia.IniciarSesion(usuario, clave);

            if (logueado == null)
                throw new Exception("Usuario o contraseña incorrectos.");

            return logueado;
        }
    }
}

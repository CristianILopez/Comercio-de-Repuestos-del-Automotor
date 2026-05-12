using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using CEntidades;
using CDatos;

// ============================================================
// 1. CLASE DE CREDENCIALES: Centraliza los datos de acceso
// ============================================================
public class CredencialesDB
{
    // Coloca aquí los datos de tu servidor
    public string Servidor = "TU_SERVIDOR";
    public string BaseDatos = "NOMBRE_DB";
    public string Usuario = "TU_USUARIO";
    public string Password = "TU_PASSWORD";

    // Genera la cadena de conexión completa para SQL Server
    public string ObtenerCadena()
    {
        return $"Server={Servidor}; Database={BaseDatos}; User Id={Usuario}; Password={Password}; Encrypt=False;";
    }
}

// ============================================================
// 2. CLASE DE CONEXIÓN (SINGLETON): Único punto de acceso a la DB
// ============================================================
public class Conexion
{
    // Instancia única (Singleton)
    private static Conexion _instancia = null;

    // Objeto con los datos de acceso
    private CredencialesDB _datos = new CredencialesDB();

    // Constructor privado para evitar el uso de 'new' fuera de la clase
    private Conexion() { }

    // Propiedad global para obtener la instancia única
    public static Conexion Instancia
    {
        get
        {
            if (_instancia == null) _instancia = new Conexion();
            return _instancia;
        }
    }

    // Método para abrir la conexión a la base de datos
    public SqlConnection Conectar()
    {
        SqlConnection cn = new SqlConnection(_datos.ObtenerCadena());
        cn.Open(); // Abre la conexión física
        return cn;
    }

    // Método auxiliar para crear parámetros de SQL rápidamente
    public SqlParameter CrearParametro(string nombre, object valor)
    {
        return new SqlParameter(nombre, valor ?? DBNull.Value);
    }

    // Método para ejecutar Stored Procedures de CONSULTA (SELECT)
    public DataTable LeerStoredProcedure(string nombreSP, List<SqlParameter> parametros = null)
    {
        DataTable tabla = new DataTable();
        using (SqlConnection cn = Conectar())
        {
            using (SqlCommand cmd = new SqlCommand(nombreSP, cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null) cmd.Parameters.AddRange(parametros.ToArray());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabla); // Llena la tabla con los resultados
            }
        } // El cierre automático ocurre aquí gracias al bloque 'using'
        return tabla;
    }

    // Método para ejecutar Stored Procedures de ACCIÓN (Insert, Update, Delete)
    public int EjecutarStoredProcedure(string nombreSP, List<SqlParameter> parametros)
    {
        int filasAfectadas = 0;
        using (SqlConnection cn = Conectar())
        {
            using (SqlCommand cmd = new SqlCommand(nombreSP, cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null) cmd.Parameters.AddRange(parametros.ToArray());

                filasAfectadas = cmd.ExecuteNonQuery(); // Ejecuta la acción
            }
        } // El cierre automático ocurre aquí gracias al bloque 'using'
        return filasAfectadas;
    }
}

// ============================================================
// 3. CLASE DE ACCESO A DATOS (DAL): Lógica de negocio de Productos
// ============================================================
public class ProductoDAL
{
    // Obtiene todos los productos llamando al SP
    public DataTable Listar()
    {
        return Conexion.Instancia.LeerStoredProcedure("sp_ListarProductos");
    }

    // Inserta un producto pasando los parámetros correspondientes
    public void Insertar(string nombre, decimal precio)
    {
        List<SqlParameter> p = new List<SqlParameter>();
        p.Add(Conexion.Instancia.CrearParametro("@Nombre", nombre));
        p.Add(Conexion.Instancia.CrearParametro("@Precio", precio));

        Conexion.Instancia.EjecutarStoredProcedure("sp_InsertarProducto", p);
    }

    // Actualiza un producto existente
    public void Actualizar(int id, string nombre, decimal precio)
    {
        List<SqlParameter> p = new List<SqlParameter>();
        p.Add(Conexion.Instancia.CrearParametro("@Id", id));
        p.Add(Conexion.Instancia.CrearParametro("@Nombre", nombre));
        p.Add(Conexion.Instancia.CrearParametro("@Precio", precio));

        Conexion.Instancia.EjecutarStoredProcedure("sp_ActualizarProducto", p);
    }

    // Elimina un producto por su ID
    public void Eliminar(int id)
    {
        List<SqlParameter> p = new List<SqlParameter>();
        p.Add(Conexion.Instancia.CrearParametro("@Id", id));

        Conexion.Instancia.EjecutarStoredProcedure("sp_EliminarProducto", p);
    }
}


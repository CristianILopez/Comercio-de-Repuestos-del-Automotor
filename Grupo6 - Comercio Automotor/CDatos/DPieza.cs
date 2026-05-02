using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos
{
    public class DPieza
    {
        public bool InsertarPiezaCarrito(EPieza pieza)
        {
            // Aquí usas tu método Conectar() que ya vimos
            using (SqlConnection cn = Conectar())
            {
                string query = "INSERT INTO Piezas (Nombre, Cantidad) VALUES (@nom, @cant)";
                SqlCommand cmd = new SqlCommand(query, cn);

                // Usamos parámetros para evitar SQL Injection
                cmd.Parameters.AddWithValue("@nom", pieza.Nombre);
                cmd.Parameters.AddWithValue("@cant", pieza.Cantidad);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }
    }
}

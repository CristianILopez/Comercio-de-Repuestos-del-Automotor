using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos;

namespace CNegocio
{
    internal class NPieza
    {
        public bool GuardarPieza(EPieza pieza)
        {
            // Validaciones de negocio
            if (string.IsNullOrEmpty(pieza.Nombre))
                throw new Exception("El nombre de la pieza es obligatorio.");

            if (pieza.Cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor a cero.");

            // Si pasa las reglas, llamamos a la capa de datos
            DPieza datos = new DPieza();
            return InsertarPiezaCarrito(pieza);
        }
    }
}

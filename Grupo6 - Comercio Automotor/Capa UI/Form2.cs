using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CNegocio;

namespace Capa_UI
{
    public partial class FRMCarrito : Form
    {
        public FRMCarrito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Aquí puedes limpiar los datos si quieres
            // Y luego cerramos de forma definitiva
            this.Dispose(); // Esto libera los recursos y cierra la ventana de verdad
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMNuevoPedido FRM = new FRMNuevoPedido();
            FRM.Show();
        }

        private void FRMCarrito_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si el usuario cerró la ventana (por la X o botón atrás)
            // y NO presionó el botón específico de "Cancelar"
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancelamos el cierre real
                this.Hide();     // Solo la ocultamos
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Creamos la entidad y la cargamos con lo que el usuario escribió
                PiezaEntidad nuevaPieza = new PiezaEntidad();
                nuevaPieza.Nombre = txtNombre.Text;
                nuevaPieza.Cantidad = int.Parse(txtCantidad.Text);

                // 2. Instanciamos la capa de negocio y pasamos la entidad
                PiezaNegocio negocio = new PiezaNegocio();
                bool exito = negocio.GuardarPieza(nuevaPieza);

                if (exito)
                {
                    MessageBox.Show("Pieza agregada correctamente");
                    LimpiarControles(); // Método opcional para vaciar los campos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_UI
{
    public partial class FRMVentas : Form
    {
        private FRMCarrito frm = null;

        public FRMVentas()
        {
            InitializeComponent();
        }

        private void BTNFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("finalizó la venta...Procediendo a facturar");

        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            //tendria que enviar a otra ventana o limpiar toda la lista para una nueva busqueda
            this.Close();
        }

        private void BTNCarro_Click(object sender, EventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new FRMCarrito();
            }

            // 3. La mostramos
            frm.Show();
            frm.BringToFront(); // Esto asegura que se vea si quedó detrás de otra ventana
        }

        private void DGVListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            /*realizar la busqueda en la base de datos*/
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            /*agregar pieza y cantidad al carrito*/

            MessageBox.Show("Agrega pieza N°... con X unidades");
        }

        private void FRMVentas_Load(object sender, EventArgs e)
        {

        }
    }
}

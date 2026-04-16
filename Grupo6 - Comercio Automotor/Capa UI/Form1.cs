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
    public partial class FRMVendedor : Form
    {
        public FRMVendedor()
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
            FRMCarrito FRM = new FRMCarrito();
            FRM.Show();
        }
    }
}

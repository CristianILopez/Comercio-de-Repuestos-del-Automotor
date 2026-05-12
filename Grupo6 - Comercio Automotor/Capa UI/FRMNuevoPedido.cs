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
    public partial class FRMNuevoPedido : Form
    {
        public FRMNuevoPedido()
        {
            InitializeComponent();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Generar Factura, agregar datos en la db y mostrar mensaje de confirmacion en pantalla*/
            MessageBox.Show("Compra realizada con exito, Generando factura.");
        }
    }
}

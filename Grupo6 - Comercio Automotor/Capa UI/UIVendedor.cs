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
    public partial class UIVendedor : Form
    {
        public UIVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FRMNuevoPedido();
            frm.ShowDialog();
        }

        private void BTNbuscarPieza_Click(object sender, EventArgs e)
        {
            var frm = new FRMBuscarPieza();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

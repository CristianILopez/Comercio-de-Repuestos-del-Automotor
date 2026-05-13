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
    public partial class UIAdminSistema : Form
    {
        public UIAdminSistema()
        {
            InitializeComponent();
        }

        private void BTNPedido_Click(object sender, EventArgs e)
        {
            var frm = new FRMAgregarNuevoUsuario();
            frm.ShowDialog();
        }

        private void BTNbuscarPieza_Click(object sender, EventArgs e)
        {
            var frm = new FRMBuscarUsuario();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FRMGenerarReporte();
            frm.ShowDialog();
        }
    }
}

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
    public partial class FRMPrecios : Form
    {
        public FRMPrecios()
        {
            InitializeComponent();
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            FRMModPrecio frm = new FRMModPrecio();
            frm.ShowDialog();
        }
    }
}

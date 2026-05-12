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
    public partial class FRMConsultarPrecio : Form
    {
        public FRMConsultarPrecio()
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

        private void FRMConsultarPrecio_Load(object sender, EventArgs e)
        {

        }
    }
}

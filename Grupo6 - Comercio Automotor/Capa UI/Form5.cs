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
    public partial class FRMBuscarStock : Form
    {
        public FRMBuscarStock()
        {
            InitializeComponent();
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            FRMModPieza fRM = new FRMModPieza("Modificar Pieza");
            fRM.Show();
        }

        private void BTNCarro_Click(object sender, EventArgs e)
        {
            /*Buscar Pieza en bd y eliminarla mediante un procedimiento*/
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FrmPrincipalStock : Form
    {
        public FrmPrincipalStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMBuscarStock FRM = new FRMBuscarStock();
            FRM.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNStock_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMModPieza FRM = new FRMModPieza("Nueva Pieza");
            FRM.ShowDialog();
        }
    }
}

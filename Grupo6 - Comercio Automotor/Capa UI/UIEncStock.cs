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
    public partial class UIEncStock : Form
    {
        public UIEncStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMBuscarPieza FRM = new FRMBuscarPieza();
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
            FRMModificarPieza FRM = new FRMModificarPieza("Nueva Pieza");
            FRM.ShowDialog();
        }
    }
}

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

    public partial class FRMModificarPieza : Form
    {
        private string operacion;
        public FRMModificarPieza(string modo)
        {
            InitializeComponent();
            this.operacion = modo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Se almacena en la db los cambios*/
            MessageBox.Show("modificacion completo");
            /*Limpiar datos del panel*/
        }

        private void FRMModPieza_Load(object sender, EventArgs e)
        {
            if (operacion == "Nueva Pieza")
            {
                BTNAgregarPieza.Visible = true;
                BTNModPieza.Visible = false;
                this.Text = "Registrar Nueva Pieza";
            }
            else if (operacion == "Modificar Pieza")
            {
                BTNAgregarPieza.Visible = false;
                BTNModPieza.Visible = true;
                this.Text = "Modificar Pieza Existente";

                // Acá podrías bloquear el ID INTERNO para que no lo editen
                TxtIdInterno.Enabled = false;
            }
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

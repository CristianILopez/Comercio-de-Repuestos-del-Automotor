using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CNegocio;

namespace Capa_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Captura de datos de la interfaz
                string usuario = TxtUsuario.Text;
                string password = TxtPass.Text;

                // 2. Validación a través de la Capa de Negocio (Singleton)
                EUsuario usuarioLogueado = NLogin.Instancia.ValidarAcceso(usuario, password);

                // 3. Respuesta al usuario
                MessageBox.Show($"¡Bienvenido {usuarioLogueado.Nombre}!", "Acceso Permitido",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Lógica de navegación (opcional)
                // FormPrincipal main = new FormPrincipal();
                // main.Show();
                // this.Hide();
            }
            catch (Exception ex)
            {
                // Manejo de errores (Usuario incorrecto, campos vacíos, etc.)
                MessageBox.Show(ex.Message, "Error de Inicio de Sesión",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormAltaCliente : Form
    {
        public FormAltaCliente()
        {
            InitializeComponent();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            ClienteDTV nuevoCliente = new ClienteDTV(textBoxDNI.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxDireccion.Text);
            FormUsuario.formValidarCliente.Show();
            this.Hide();
        }
        private void FormAltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormValidarCliente formValidarCliente = new FormValidarCliente();
            formValidarCliente.Show();
            this.Hide();
        }
    }
}

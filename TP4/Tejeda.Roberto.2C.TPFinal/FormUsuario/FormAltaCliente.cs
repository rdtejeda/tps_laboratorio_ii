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
using PersistirDatos;

namespace Formularios
{
    public partial class FormAltaCliente : Form
    {
        ClienteDTV nuevoCliente;
        public FormAltaCliente()
        {
            InitializeComponent();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDNI.Text != string.Empty && textBoxNombre.Text != string.Empty
                && textBoxApellido.Text != string.Empty && textBoxDireccion.Text != string.Empty)
                {
                    nuevoCliente = new ClienteDTV(textBoxDNI.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxDireccion.Text);
                }
                else
                {
                    MessageBox.Show("DEBE COMPLETAR TODOS LOS CAMPOS");
                }
                ClienteDTV.AgregarNuevoCliente(nuevoCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tu excepción es: {ex.Message}");
            }   
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

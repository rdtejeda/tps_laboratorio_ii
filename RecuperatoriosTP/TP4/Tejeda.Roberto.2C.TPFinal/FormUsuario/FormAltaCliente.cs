using Entidades;
using System;
using System.Windows.Forms;
using PersistirDatos;
using static System.Environment;
using Excepciones;

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
                    if (!ClienteDTV.BuscarEnListaClientes(textBoxDNI.Text))
                    {
                        nuevoCliente = new ClienteDTV(textBoxDNI.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxDireccion.Text);
                        ClienteDTV.AgregarNuevoCliente(nuevoCliente);
                        MessageBox.Show($"Se ha dado de alta al cliente {nuevoCliente.ToString()} y a registrado en el archivo NuevoUsuario.txt");
                        Logger.Log($"El DNI {textBoxDNI.Text} se ha dado de alta clinete", "NuevoUsuario.txt");
                    }
                    else
                    {
                        Logger.Log($"El DNI {textBoxDNI.Text} ya esta registardo como clinete","UsuarioExistente.txt");
                        MessageBox.Show("El Dni ingresado ya esta registardo como clinete se dejo Acentado en archivo Log.txt");
                    }
                }
                else
                {
                    MessageBox.Show("DEBE COMPLETAR TODOS LOS CAMPOS");
                }
            }
            catch (DatosException ex)
            {
                MessageBox.Show(ex.Message);
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

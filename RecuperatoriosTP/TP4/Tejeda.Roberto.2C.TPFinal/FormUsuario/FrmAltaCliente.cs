using Entidades;
using Excepciones;
using PersistirDatos;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmAltaCliente : Form
    {
        ClienteDTV nuevoCliente;
        public FrmAltaCliente()
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
                        ClientesDTVDAO.Guardar(nuevoCliente);
                        Logger.Log($"El DNI {textBoxDNI.Text} se ha dado de alta clinete", "NuevoCliente.txt");
                        MessageBox.Show($"Se ha dado de alta al clienteAuxiliar {nuevoCliente.ToString()} Se ha incorporado a la base de datos SQL, al bakUp XML y se a registrado en el archivo NuevoCliente.txt");

                    }
                    else
                    {
                        Logger.Log($"El DNI {textBoxDNI.Text} ya esta registardo como clinete", "ClienteExistente.txt");
                        MessageBox.Show("El Dni ingresado ya esta registardo como clinete se dejo Acentado en archivo ClienteExistente.txt");
                    }
                }
                else
                {
                    MessageBox.Show("DEBE COMPLETAR TODOS LOS CAMPOS");
                }
            }
            catch (ClienteNoDisponibleException ex)
            {
                MessageBox.Show($"Tu excepción es: {ex.Message}");
            }
            catch (DatosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tu excepción es: {ex.Message}");
            }
            this.Hide();
        }
        private void FormAltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}

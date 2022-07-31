using Entidades;
using Excepciones;
using PersistirDatos;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmUsuarioDTV : Form
    {
        public static FrmValidarCliente? formValidarCliente;
        public FrmUsuarioDTV()
        {
            InitializeComponent();
        }
        private void FormUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cerrar?", "Desea Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnIngresarSQL_Click(object sender, EventArgs e)
        {
            if (tBxNombreUsuario.Text != string.Empty && tBxPassword.Text != string.Empty)
            {
                try
                {
                    if (UsuarioDTV.IdentificarUsuarioSQL(tBxNombreUsuario.Text, tBxPassword.Text))
                    {
                        MessageBox.Show("El usuario se ha logeado y su acceso a quedado registardo");
                        Logger.Log($"El usuario {tBxNombreUsuario.Text} se ha conectado", "UsuarioLoguadosSQL.txt");
                    }
                    formValidarCliente = new FrmValidarCliente();
                    formValidarCliente.ActualizarMensaje(tBxNombreUsuario.Text);
                    formValidarCliente.Show();
                    Hide();

                }
                catch (AccesoNoAutorizadoException ex)
                {
                    MessageBox.Show($"Usuario no se ha logeado, {ex.Message}");
                }
                catch (ArchivoException ex)
                {
                    MessageBox.Show($"Usuario no se ha logeado, {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Usuario no se ha logeado, {ex.Message} + {ex.ToString()} + {ex.Data}");
                }
                finally
                {
                }
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR AMBOS CAMPOS PARA INGRESAR");
                this.tBxNombreUsuario.Text = string.Empty;
                this.tBxPassword.Text = string.Empty;
            }
        }
        private void btnIngresarXML_Click(object sender, EventArgs e)
        {
            if (tBxNombreUsuario.Text != string.Empty && tBxPassword.Text != string.Empty)
            {
                try
                {
                    if (UsuarioDTV.IdentificarUsuarioXML(tBxNombreUsuario.Text, tBxPassword.Text))
                    {
                        MessageBox.Show("El usuario se ha logeado y su acceso a quedado registardo");
                        Logger.Log($"El usuario {tBxNombreUsuario.Text} se ha conectado", "UsuariosLoguadosXML.txt");
                    }
                    formValidarCliente = new FrmValidarCliente();
                    formValidarCliente.ActualizarMensaje(tBxNombreUsuario.Text);
                    formValidarCliente.Show();
                    Hide();

                }
                catch (AccesoNoAutorizadoException ex)
                {
                    MessageBox.Show($"Usuario no se ha logeado, {ex.Message}");
                }
                catch (ArchivoException ex)
                {
                    MessageBox.Show($"Usuario no se ha logeado, {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Usuario no se ha logeado, {ex.Message} + {ex.ToString()} + {ex.Data}");
                }
                finally
                {
                }
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR AMBOS CAMPOS PARA INGRESAR");
                this.tBxNombreUsuario.Text = string.Empty;
                this.tBxPassword.Text = string.Empty;
            }
        }
    }
}

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
using Excepciones;

namespace Formularios
{
    public partial class FormUsuario : Form
    {
        public static FormValidarCliente formValidarCliente;
        public FormUsuario()
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
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (tBxNombreUsuario.Text != string.Empty && tBxPassword.Text != string.Empty)
            {
                try
                {
                    if(UsuarioDTV.IdentificarUsuario(tBxNombreUsuario.Text, tBxPassword.Text))
                    {
                        MessageBox.Show("El usuario se ha logeado");
                    }
                    formValidarCliente = new FormValidarCliente();
                    formValidarCliente.ActualizarMensaje(tBxNombreUsuario.Text);
                    formValidarCliente.Show();
                    Hide();

                }
                catch(AccesoNoAutorizadoException ex)
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

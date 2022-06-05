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

namespace FormUsuario
{
    public partial class FormUsuario : Form
    {
        //UsuarioDTV usuarioDTV;
        //List<UsuarioDTV> ListaUsuariosDTV;
        public FormUsuario()
        {
                InitializeComponent();
                //this.tBxNombreUsuario.Text = string.Empty;
                //this.tBxPassword.Text = string.Empty;

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
            if (this.tBxNombreUsuario.Text != string.Empty && this.tBxPassword.Text != string.Empty)
            {
                try
                {
                    //List<UsuarioDTV> list = new List<UsuarioDTV>();
                    //list.Add(new UsuarioDTV("18223125", "Roberto", "Tejeda", "rtejeda", "1234"));
                    //list.Add(new UsuarioDTV("18456345", "Alberto", "Tejada", "rtejada", "5678"));
                    //list.Add(new UsuarioDTV("15678865", "Norberto", "Tejedor", "rtejeor", "9012"));

                    List<ClienteDTV> lista = new List<ClienteDTV>();
                   
                    lista.Add(new ClienteDTV("12345678","Pepe","Rodriguez",1,"Perex 234", 
                        new Servicio(Servicio.EServicios.DTVGo,Servicio.EFormaPago.TarjetaCredito,Servicio.ECantidadDecos.Dos,Servicio.ESenialesPremiun.FutbolArgentino)));
                    lista.Add(new ClienteDTV("12345678", "asddfhj", "Peruez", 2, "CXaacupoe 234"));
                    lista.Add(new ClienteDTV("12345678", "aSD", "ASDasd", 1, "Perex 234"));


                    string path= AppDomain.CurrentDomain.BaseDirectory;
                    
                    Serializar<List<UsuarioDTV>> listaSerializada = new Serializar<List<UsuarioDTV>>();
                    Serializar<List<ClienteDTV>> listaSerializadaC = new Serializar<List<ClienteDTV>>();
                    //listaSerializada.Guardar(path, "usuariosDTV.xml", list);
                    listaSerializadaC.Guardar(path, "clientesDTV.xml", lista);
                    List<UsuarioDTV> listaUsuariosDTV = listaSerializada.Leer(path, "usuariosDTV.xml");
                    List<ClienteDTV> listaClientesosDTV = listaSerializadaC.Leer(path, "clientesDTV.xml");
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Lista de Usuarios");
                    foreach (UsuarioDTV item in listaUsuariosDTV)
                    {
                        
                        sb.AppendLine(item.ToString());
                    }
                    MessageBox.Show(sb.ToString());

                    StringBuilder sb1 = new StringBuilder();
                    sb1.AppendLine("Lista de Clientes");
                    foreach (ClienteDTV item in listaClientesosDTV)
                    {

                        sb1.AppendLine(item.ToString());
                    }
                    MessageBox.Show(sb1.ToString());


                    //FrmMenu menu = new FrmMenu();
                    //menu.ActualizarMensaje(this.tbxUser.Text);
                    //MessageBox.Show("El usuario se ha logeado");
                    //menu.Show();
                    //this.Hide();

                }
                catch (UnauthorizedAccessException ex)
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

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
    public partial class FormValidarCliente : Form
    {
        ClienteDTV cliente;
        public FormValidarCliente()
        {
            InitializeComponent();
        }
        public void ActualizarMensaje(string nombre)
        {
            this.lblBienvenidaUsuario.Text = this.lblBienvenidaUsuario.Text + nombre;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormValidarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.formUsuario.Show();
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(txtDNI is not null)
            {
                if(ClienteDTV.IdentificarCliente(txtDNI.Text) is not null)
                {
                    cliente = ClienteDTV.IdentificarCliente(txtDNI.Text);
                    richTextBox1.Text = cliente.ToString();                    
                }     
            }
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FormServiciosCliente formServiciosCliente = new FormServiciosCliente();
            formServiciosCliente.TraerCliente(cliente);
            formServiciosCliente.Show();
            this.Hide();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormAltaCliente formAltaCliente = new FormAltaCliente();
            formAltaCliente.Show();
            this.Hide();
        }
    }
}

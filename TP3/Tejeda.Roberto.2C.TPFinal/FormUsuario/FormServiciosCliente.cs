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
using Excepciones;


namespace Formularios
{
    public partial class FormServiciosCliente : Form
    {
        ClienteDTV cliente;
        public FormServiciosCliente()
        {
            InitializeComponent();
            
        }
        public void TraerCliente(ClienteDTV c)
        {
            cliente = c;
        }

        private void comboBoxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(cliente.Servicio is not null)
            {
                this.tBxDireccion.Text = cliente.Direccion;
                this.comboBoxCantidadDecos.Text = cliente.Servicio.CantidadDecos.ToString();
                this.comboBoxFormaPAgo.Text = cliente.Servicio.FormaPago.ToString();
                this.comboBoxServicio.Text = cliente.Servicio.FormaPago.ToString();
                foreach (Servicio.ESenialesPremiun item in cliente.Servicio.SenialPremium)
                {
                    this.listBoxSeniales.Items.Add(item);
                }
            }
            else
            {

            }
        }

        private void btnBajaSenila_Click(object sender, EventArgs e)
        {
           listBoxSeniales.Items.Remove(listBoxSeniales.SelectedItem);
        }

        private void btnAltaSenila_Click(object sender, EventArgs e)
        {
            listBoxSeniales.Items.Add(comboBoxSenialPremium.Text);
        }

        private void btnSalirActualizar_Click(object sender, EventArgs e)
        {
            //FALTA LOGICA NO LLEGUE
            //ClienteDTV.ModificarServiviosCliente(cliente);
            Close();
        }

        private void FormServiciosCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUsuario.formValidarCliente.Show();
            this.Hide();
        }
    }
}

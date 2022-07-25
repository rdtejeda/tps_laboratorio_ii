using Entidades;
using System;
using System.Windows.Forms;
using static Entidades.Servicio;

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
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cliente.Servicio is not null)
            {
                this.tBxDireccion.Text = cliente.Direccion;
                this.comboBoxCantidadDecos.Text = cliente.Servicio.CantidadDecos.ToString();
                this.comboBoxFormaPAgo.Text = cliente.Servicio.FormaPago.ToString();
                this.comboBoxServicio.Text = cliente.Servicio.Servivio.ToString();
                foreach (Servicio.ESenialesPremiun item in cliente.Servicio.SenialPremium)
                {
                    this.listBoxSeniales.Items.Add(item);
                }
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
            ClienteDTV clienteAux = new ClienteDTV();
            if (tBxDireccion.Text != "")
            {
                clienteAux.Dni = cliente.Dni;
                clienteAux.Nombre = cliente.Nombre;
                clienteAux.Apellido = cliente.Apellido;

                clienteAux.Direccion = tBxDireccion.Text;

                if (comboBoxCantidadDecos.Text == "Cero")
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Cero;
                if (comboBoxCantidadDecos.Text == "Uno")
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Uno;
                if (comboBoxCantidadDecos.Text == "Dos")
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Dos;
                if (comboBoxCantidadDecos.Text == "Tres")
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Tres;
                if (comboBoxCantidadDecos.Text == "Cuatro")
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Cuatro;
                if (comboBoxCantidadDecos.Text == "Cinco")
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Cinco;

                if (comboBoxFormaPAgo.Text == "TarjetaCredito")
                    clienteAux.Servicio.FormaPago = EFormaPago.TarjetaCredito;
                if (comboBoxFormaPAgo.Text == "TarjetaDebito")
                    clienteAux.Servicio.FormaPago = EFormaPago.TarjetaDebito;

                if (comboBoxServicio.Text == "NoActivo")
                    clienteAux.Servicio.Servivio = EServicios.NoActivo;
                if (comboBoxServicio.Text == "Oro")
                    clienteAux.Servicio.Servivio = EServicios.Oro;
                if (comboBoxServicio.Text == "Plata")
                    clienteAux.Servicio.Servivio = EServicios.Plata;
                if (comboBoxServicio.Text == "DTVGo")
                    clienteAux.Servicio.Servivio = EServicios.DTVGo;

                if (listBoxSeniales.FindString("Paramount") >= 0)
                    clienteAux.Servicio.SenialPremium.Add(ESenialesPremiun.Paramount);
                if (listBoxSeniales.FindString("FutbolArgentino") >= 0)
                    clienteAux.Servicio.SenialPremium.Add(ESenialesPremiun.FutbolArgentino);
                if (listBoxSeniales.FindString("HBO") >= 0)
                    clienteAux.Servicio.SenialPremium.Add(ESenialesPremiun.HBO);
                if (listBoxSeniales.FindString("Star") >= 0)
                    clienteAux.Servicio.SenialPremium.Add(ESenialesPremiun.Star);
                if (listBoxSeniales.FindString("NBA") >= 0)
                    clienteAux.Servicio.SenialPremium.Add(ESenialesPremiun.NBA);

                ClienteDTV.ModificarServiviosCliente(clienteAux);
                Close();
            }
            else
            {
                MessageBox.Show("Para poder Grabar DEBE 'ACTUALIZAR SERVICIOS DEL CLIENTE'");
            }
        }
        private void FormServiciosCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUsuario.formValidarCliente.Show();
            this.Hide();
        }
        private void FormServiciosCliente_Load(object sender, EventArgs e)
        {
            this.lblNumeroCliente.Text += $"{cliente.Dni} - {cliente.Apellido} {cliente.Nombre}";
        }
    }
}

using Entidades;
using System;
using System.Windows.Forms;
using static Entidades.Servicio;

namespace Formularios
{
    public partial class FrmServiciosCliente : Form
    {
        ClienteDTV cliente;
        public FrmServiciosCliente()
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
            try
            {
                if (tBxDireccion.Text != "")
                {
                    ClienteDTV clienteAux = ActualizarServicioDelCliente();
                    ClienteDTV.ModificarServiviosCliente(clienteAux);
                    ClientesDTVDAO.Modificar(clienteAux);
                    MessageBox.Show("Se han Actualizado los datos del cliente en base SQL y BackUp XML");
                    Close();
                }
                else
                {
                    MessageBox.Show("Para poder Grabar DEBE 'ACTUALIZAR SERVICIOS DEL CLIENTE'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }       
        private void FormServiciosCliente_Load(object sender, EventArgs e)
        {
            this.lblNumeroCliente.Text += $"{cliente.Dni} - {cliente.Apellido} {cliente.Nombre}";
        }
        private ClienteDTV ActualizarServicioDelCliente()
        {
            ClienteDTV clienteAux = new ClienteDTV();

            clienteAux.Dni = cliente.Dni;
            clienteAux.Nombre = cliente.Nombre;
            clienteAux.Apellido = cliente.Apellido;
            clienteAux.Direccion = tBxDireccion.Text;

            switch (comboBoxCantidadDecos.Text)
            {
                case "Cero":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Cero;
                    break;
                case "Uno":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Uno;
                    break;
                case "Dos":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Dos;
                    break;
                case "Tres":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Tres;
                    break;
                case "Cuatro":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Cuatro;
                    break;
                case "Cinco":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Cinco;
                    break;
                default:
                    break;
            }
            switch (comboBoxFormaPAgo.Text)
            {
                case "TarjetaCredito":
                    clienteAux.Servicio.FormaPago = EFormaPago.TarjetaCredito;
                    break;
                case "TarjetaDebito":
                    clienteAux.Servicio.FormaPago = EFormaPago.TarjetaDebito;
                    break;
                default:
                    break;
            }
            switch (comboBoxServicio.Text)
            {
                case "NoActivo":
                    clienteAux.Servicio.Servivio = EServicios.NoActivo;
                    break;
                case "Oro":
                    clienteAux.Servicio.Servivio = EServicios.Oro;
                    break;
                case "Plata":
                    clienteAux.Servicio.Servivio = EServicios.Plata;
                    break;
                case "DTVGo":
                    clienteAux.Servicio.Servivio = EServicios.DTVGo;
                    break;
                default:
                    break;
            }
            switch (comboBoxCantidadDecos.Text)
            {
                case "Cero":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Cero;
                    break;
                case "Uno":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Uno;
                    break;
                case "Dos":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Dos;
                    break;
                case "Tres":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Tres;
                    break;
                case "Cuatro":
                    clienteAux.Servicio.CantidadDecos = ECantidadDecos.Cuatro;
                    break;
                default:
                    break;
            }
            if (listBoxSeniales.Items.Count > 0)
            {
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
            }
            return clienteAux;
        }
        private void FormServiciosCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmUsuarioDTV.formValidarCliente.Show();
            this.Hide();
        }
    }
}

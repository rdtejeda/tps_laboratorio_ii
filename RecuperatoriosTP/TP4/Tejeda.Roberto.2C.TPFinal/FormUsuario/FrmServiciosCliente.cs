using Entidades;
using System;
using System.Windows.Forms;
using static Entidades.Servicio;

namespace Formularios
{
    public partial class FrmServiciosCliente : Form
    {
        ClienteDTV clienteAuxiliar;
        public FrmServiciosCliente()
        {
            InitializeComponent();
        }
        private void FormServiciosCliente_Load(object sender, EventArgs e)
        {
            this.lblNumeroCliente.Text += $"{clienteAuxiliar.Dni} - {clienteAuxiliar.Apellido} {clienteAuxiliar.Nombre}";
        }
        public void TraerCliente(ClienteDTV clienteValidado)
        {
            if (clienteValidado is not null)
            {
                clienteAuxiliar = clienteValidado;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (clienteAuxiliar.Servicio is not null)
            {
                this.tBxDireccion.Text = clienteAuxiliar.Direccion;
                this.comboBoxCantidadDecos.Text = clienteAuxiliar.Servicio.CantidadDecos.ToString();
                this.comboBoxFormaPAgo.Text = clienteAuxiliar.Servicio.FormaPago.ToString();
                this.comboBoxServicio.Text = clienteAuxiliar.Servicio.Servivio.ToString();
                foreach (Servicio.ESenialesPremiun item in clienteAuxiliar.Servicio.SenialPremium)
                {
                    if (listBoxSenPremiun.FindStringExact(item.ToString()) < 0)
                    {
                        this.listBoxSenPremiun.Items.Add(item);
                    }
                }
            }
        }
        private void btnBajaSenila_Click(object sender, EventArgs e)
        {
            if (listBoxSenPremiun.SelectedItem is not null)
            {
                listBoxSenPremiun.Items.Remove(listBoxSenPremiun.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe selecionar una Señal para dar la baja");
            }
        }
        private void btnAltaSenila_Click(object sender, EventArgs e)
        {
            if (listBoxSenPremiun.FindStringExact(comboBoxSenialPremium.Text) < 0 && comboBoxSenialPremium.Text.Length > 0)
            {
                listBoxSenPremiun.Items.Add(comboBoxSenialPremium.Text);
            }
            else
            {
                MessageBox.Show("Señal ya agregada o no Selecionada");
            }
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
                    MessageBox.Show("Se han Actualizado los datos del clienteAuxiliar en base SQL y BackUp XML");
                }
                else
                {
                    MessageBox.Show("Para poder Grabar DEBE 'ACTUALIZAR SERVICIOS DEL CLIENTE'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido actualizar la base de datos");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }
        private ClienteDTV ActualizarServicioDelCliente()
        {
            ClienteDTV clienteAux = new ClienteDTV();
            clienteAux.Dni = clienteAuxiliar.Dni;
            clienteAux.Nombre = clienteAuxiliar.Nombre;
            clienteAux.Apellido = clienteAuxiliar.Apellido;
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
            if (listBoxSenPremiun.Items.Count > 0)
            {
                if (listBoxSenPremiun.FindString("Paramount") >= 0)
                    clienteAux.Servicio.SenialPremium.Add(ESenialesPremiun.Paramount);
                if (listBoxSenPremiun.FindString("FutbolArgentino") >= 0)
                    clienteAux.Servicio.SenialPremium.Add(ESenialesPremiun.FutbolArgentino);
                if (listBoxSenPremiun.FindString("HBO") >= 0)
                    clienteAux.Servicio.SenialPremium.Add(ESenialesPremiun.HBO);
                if (listBoxSenPremiun.FindString("Star") >= 0)
                    clienteAux.Servicio.SenialPremium.Add(ESenialesPremiun.Star);
                if (listBoxSenPremiun.FindString("NBA") >= 0)
                    clienteAux.Servicio.SenialPremium.Add(ESenialesPremiun.NBA);
            }
            return clienteAux;
        }
        private void FormServiciosCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}

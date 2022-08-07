using Entidades;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmReclamo : Form
    {
        string dniClienteAuxiliar;
        Reclamo nuevoReclamo;
        ClienteDTV clienteAuxiliar;
        public FrmReclamo()
        {
            InitializeComponent();
        }
        private void FrmReclamo_Load(object sender, EventArgs e)
        {
            try
            {
                nuevoReclamo = new Reclamo((ReclamosDAO.UltimoNumeroDeReclamo()) + 1, dniClienteAuxiliar);
                clienteAuxiliar = ClienteDTV.IdentificarCliente(dniClienteAuxiliar);
                this.lblDatosCliente.Text = $" Nuemero de Clinte: {clienteAuxiliar.Dni} - {clienteAuxiliar.Apellido} {clienteAuxiliar.Nombre} - Reclamo Numero: {nuevoReclamo.NumeroReclamo}";
                chekBReclamo.Checked = nuevoReclamo.EstaSolucionado;
                nuevoReclamo.OnEstadoReclamo += RespaldarDatosDeReaclamo;
                txbNumeroReclamo.Text = nuevoReclamo.NumeroReclamo.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No Se ha podido iniciar nuevo reclamo");
            }
        }
        private void RespaldarDatosDeReaclamo()
        {
            try
            {
                ReclamosDAO.Guardar(nuevoReclamo);

                MessageBox.Show("Se ha guardado el regitro de Reclamo");
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido Respaldar el Reclamo");
            }

        }
        public void TraerCliente(string dniCliente)
        {
            if (dniCliente is not null)
            {
                dniClienteAuxiliar = dniCliente;
            }
        }
        private void FrmReclamo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmUsuarioDTV.formValidarCliente.Show();
            this.Hide();
        }
        private void chekBReclamo_CheckedChanged(object sender, EventArgs e)
        {
            if (chekBReclamo.CheckState == 0)
            {
                nuevoReclamo.EstaSolucionado = false;
            }
            else
            {
                nuevoReclamo.EstaSolucionado = true;
            }
            nuevoReclamo.ActilizarEstadoDeElReclamo();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                nuevoReclamo.ActilizarEstadoDeElReclamo();
                Reclamo.AgregarReclamo(nuevoReclamo);
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido Respaldar el Reclamo");
            }
            finally
            {
                Close();
            }
        }
        private void btnServiciosCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteAuxiliar is not null)
                {
                    FrmServiciosCliente formServiciosCliente = new FrmServiciosCliente();
                    formServiciosCliente.TraerCliente(clienteAuxiliar);
                    formServiciosCliente.Show();
                }
                else
                {
                    MessageBox.Show("Debe validar El Cliente antes de seleccionarlo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSelecionServicios_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTV clienteMostrar;
                if ((clienteMostrar = ClienteDTV.IdentificarCliente(dniClienteAuxiliar)) is not null)
                {
                    richTextBox1.Text = clienteMostrar.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro el cliente");
            }
        }
        private void btnCargReclamo_Click(object sender, EventArgs e)
        {
            int aux;
            if (int.TryParse(txbNumeroReclamo.Text, out aux) && aux <= ReclamosDAO.UltimoNumeroDeReclamo())
            {
                nuevoReclamo = ReclamosDAO.BuscarReclamo(int.Parse(txbNumeroReclamo.Text));
                clienteAuxiliar = ClienteDTV.IdentificarCliente(nuevoReclamo.DniClienteReclama);
                dniClienteAuxiliar = clienteAuxiliar.Dni;
                nuevoReclamo.OnEstadoReclamo += RespaldarDatosDeReaclamo;
                btnSelecionServicios_Click(sender, e);
                chekBReclamo.Checked = nuevoReclamo.EstaSolucionado;
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR NUMERO DE RECLAMO VALIDO");
            }
        }
    }
}

using Entidades;
using Excepciones;
using PersistirDatos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmValidarCliente : Form
    {
        ClienteDTV cliente;
        Temporizador temporizador;
        Task tareReloj;
        CancellationTokenSource cancelTokenSource = new CancellationTokenSource();

        public FrmValidarCliente()
        {
            InitializeComponent();
            temporizador = new Temporizador();
        }
        private void FrmValidarCliente_Load(object sender, EventArgs e)
        {
            tareReloj = Task.Run(() => IniciarHora(cancelTokenSource));
            temporizador.OnTiempoFinalizado += BackupXML_OnTiempoFinalizado;
            Task.Run(() => HacerBackupXML(cancelTokenSource));
        }
        private void HacerBackupXML(CancellationTokenSource cts)
        {
            if (!cts.IsCancellationRequested)
            {
                temporizador.Ejecutar(10);
            }
        }
        private void BackupXML_OnTiempoFinalizado()
        {
            try
            {
                List<ClienteDTV> sqlList = ClientesDTVDAO.Leer();
                string path;
                if (((path = Environment.CurrentDirectory + @"\Archivos\") is not null))
                {
                    Serializar<List<ClienteDTV>> listaSerializadaC = new Serializar<List<ClienteDTV>>();
                    listaSerializadaC.Guardar(path, "clientesDTV.xml", sqlList);
                }
                ListaXMLActualizada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ActualizarMensaje(string nombre)
        {
            this.lblBienvenidaUsuario.Text = this.lblBienvenidaUsuario.Text + nombre;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            cancelTokenSource.Cancel();
            Close();
        }
        private void FormValidarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.formUsuario.Show();
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDNI.Text != string.Empty)
                {
                    if ((cliente = ClienteDTV.IdentificarCliente(txtDNI.Text)) is not null)
                    {
                        richTextBox1.Text = cliente.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR UN DNI");
                }
            }
            catch (ClienteSinServiciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ClienteNoDisponibleException ex)
            {
                MessageBox.Show($"Aún no es Cliente {ex.Message}");
            }
            catch (ArchivoException ex)
            {
                MessageBox.Show($"No se ha logrado cargar la base de datos, {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente is not null)
                {
                    FrmServiciosCliente formServiciosCliente = new FrmServiciosCliente();
                    formServiciosCliente.TraerCliente(cliente);
                    formServiciosCliente.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Debe validar cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAltaCliente formAltaCliente = new FrmAltaCliente();
            formAltaCliente.Show();
            this.Hide();
        }
        private void IniciarHora(CancellationTokenSource cts)
        {
            do
            {
                if (cts.IsCancellationRequested)
                    break;
                AsignarHora();
                Thread.Sleep(1000);
            } while (true);
        }
        private void AsignarHora()
        {
            if (this.InvokeRequired)
            {
                Action delegado = AsignarHora;
                this.Invoke(delegado);
            }
            else
            {
                lblFechaHora.Text = DateTime.Now.ToString("F");
            }
        }
        private void ListaXMLActualizada()
        {
            if (this.InvokeRequired)
            {
                Action delegado = ListaXMLActualizada;
                this.Invoke(delegado);
            }
            else
            {
                lblListaxmlActualizada.Text = $"Lista actaulizada a las {DateTime.Now.ToString("T")}";
            }
        }
    }
}

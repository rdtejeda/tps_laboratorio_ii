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
        Task tareaReloj;
        CancellationTokenSource cancelTokenSource;
        public FrmValidarCliente()
        {
            InitializeComponent();
            temporizador = new Temporizador();
            cancelTokenSource = new CancellationTokenSource();
            tareaReloj = new Task(() => IniciarHora(cancelTokenSource.Token));
        }
        private void FrmValidarCliente_Load(object sender, EventArgs e)
        {
            tareaReloj.Start();
            temporizador.OnTiempoFinal += BackupXML_OnTiempoFinalizado;
            Task.Run(() => HacerBackupXML(cancelTokenSource.Token));
        }
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            try
            {
                dGVClientes.DataSource = ClientesDTVDAO.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"La lista de clientes no pudo ser cargada, excepción {ex.Message}");
            }
        }
        private void HacerBackupXML(CancellationToken cts)
        {
            if (!cts.IsCancellationRequested)
            {
                temporizador.Ejecutar(10, cts);
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
                    //this.Hide();
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
        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAltaCliente formAltaCliente = new FrmAltaCliente();
            formAltaCliente.Show();
        }
        private void IniciarHora(CancellationToken cts)
        {
            do
            {
                if (!cts.IsCancellationRequested)
                {
                    AsignarHora(cts);
                    Thread.Sleep(1000);
                }
            } while (true);
        }
        private void AsignarHora(CancellationToken cts)
        {
            try
            {
                if (!cts.IsCancellationRequested)
                {
                    if (this.InvokeRequired)
                    {
                        Action<CancellationToken> delegado = new Action<CancellationToken>(AsignarHora);
                        object[] obj = new object[] { cts };
                        this.Invoke(delegado, obj);
                    }
                    else
                    {
                        lblFechaHora.Text = DateTime.Now.ToString("F");
                    }
                }
            }
            catch (TaskCanceledException ex)
            {
                Logger.Log($"Se registo la Excepcion {ex.Message}", "Excepciones.txt");
            }
            catch (OperationCanceledException ex)
            {
                Logger.Log($"Se registo la Excepcio {ex.Message}", "Excepciones.txt");
            }
            catch (Exception ex)
            {
                Logger.Log($"Se registo la Excepcio {ex.Message}", "Excepciones.txt");
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
                lblListaxmlActualizada.Text = $"BackUp XML realizado el {DateTime.Now.ToString("G")}";
            }
        }
        private void dGVClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dniAux;
            if (int.TryParse(dGVClientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out dniAux))
            {
                txtDNI.Text = dGVClientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
        private void btnReclamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente is not null)
                {
                    FrmReclamo formReclamo = new FrmReclamo();
                    formReclamo.TraerCliente(cliente.Dni);
                    formReclamo.Show();
                    this.Hide();
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormValidarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cerrar?", "Desea Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                cancelTokenSource.Cancel();
                Thread.Sleep(1000);
                e.Cancel = true;
            }
            Program.formUsuario.Show();
        }
        public void ActualizarMensaje(string nombre)
        {
            this.lblBienvenidaUsuario.Text = this.lblBienvenidaUsuario.Text + nombre;
        }
    }
}

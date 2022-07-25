﻿using Entidades;
using Excepciones;
using System;
using System.Windows.Forms;

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
            try
            {
                if (txtDNI.Text != string.Empty)
                {
                    if (ClienteDTV.IdentificarCliente(txtDNI.Text) is not null)
                    {
                        cliente = ClienteDTV.IdentificarCliente(txtDNI.Text);
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
            catch (Exception)
            {
                throw;
            }
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (cliente is not null)
            {
                FormServiciosCliente formServiciosCliente = new FormServiciosCliente();
                formServiciosCliente.TraerCliente(cliente);
                formServiciosCliente.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe validar cliente");
            }
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormAltaCliente formAltaCliente = new FormAltaCliente();
            formAltaCliente.Show();
            this.Hide();
        }
    }
}

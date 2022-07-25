namespace Formularios
{
    partial class FormServiciosCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxServicio = new System.Windows.Forms.ComboBox();
            this.comboBoxCantidadDecos = new System.Windows.Forms.ComboBox();
            this.comboBoxFormaPAgo = new System.Windows.Forms.ComboBox();
            this.comboBoxSenialPremium = new System.Windows.Forms.ComboBox();
            this.tBxDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblCantidadDecos = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblSenialPremium = new System.Windows.Forms.Label();
            this.listBoxSeniales = new System.Windows.Forms.ListBox();
            this.btnBajaSenila = new System.Windows.Forms.Button();
            this.btnAltaSenila = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalirActualizar = new System.Windows.Forms.Button();
            this.lblSenialesContradas = new System.Windows.Forms.Label();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxServicio
            // 
            this.comboBoxServicio.FormattingEnabled = true;
            this.comboBoxServicio.Items.AddRange(new object[] {
            "NoActivo",
            "DTVGo",
            "Plata",
            "Oro"});
            this.comboBoxServicio.Location = new System.Drawing.Point(40, 204);
            this.comboBoxServicio.Name = "comboBoxServicio";
            this.comboBoxServicio.Size = new System.Drawing.Size(151, 23);
            this.comboBoxServicio.TabIndex = 0;
            // 
            // comboBoxCantidadDecos
            // 
            this.comboBoxCantidadDecos.FormattingEnabled = true;
            this.comboBoxCantidadDecos.Items.AddRange(new object[] {
            "Cero",
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinco"});
            this.comboBoxCantidadDecos.Location = new System.Drawing.Point(214, 204);
            this.comboBoxCantidadDecos.Name = "comboBoxCantidadDecos";
            this.comboBoxCantidadDecos.Size = new System.Drawing.Size(151, 23);
            this.comboBoxCantidadDecos.TabIndex = 1;
            // 
            // comboBoxFormaPAgo
            // 
            this.comboBoxFormaPAgo.FormattingEnabled = true;
            this.comboBoxFormaPAgo.Items.AddRange(new object[] {
            "TarjetaCredito",
            "TarjetaDebito"});
            this.comboBoxFormaPAgo.Location = new System.Drawing.Point(214, 259);
            this.comboBoxFormaPAgo.Name = "comboBoxFormaPAgo";
            this.comboBoxFormaPAgo.Size = new System.Drawing.Size(151, 23);
            this.comboBoxFormaPAgo.TabIndex = 2;
            // 
            // comboBoxSenialPremium
            // 
            this.comboBoxSenialPremium.FormattingEnabled = true;
            this.comboBoxSenialPremium.Items.AddRange(new object[] {
            "HBO",
            "Star",
            "Paramount",
            "FutbolArgentino",
            "NBA"});
            this.comboBoxSenialPremium.Location = new System.Drawing.Point(41, 259);
            this.comboBoxSenialPremium.Name = "comboBoxSenialPremium";
            this.comboBoxSenialPremium.Size = new System.Drawing.Size(151, 23);
            this.comboBoxSenialPremium.TabIndex = 3;
            // 
            // tBxDireccion
            // 
            this.tBxDireccion.Location = new System.Drawing.Point(40, 144);
            this.tBxDireccion.Name = "tBxDireccion";
            this.tBxDireccion.Size = new System.Drawing.Size(325, 23);
            this.tBxDireccion.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(40, 126);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(40, 186);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(71, 15);
            this.lblServicio.TabIndex = 6;
            this.lblServicio.Text = "TipoServicio";
            // 
            // lblCantidadDecos
            // 
            this.lblCantidadDecos.AutoSize = true;
            this.lblCantidadDecos.Location = new System.Drawing.Point(214, 183);
            this.lblCantidadDecos.Name = "lblCantidadDecos";
            this.lblCantidadDecos.Size = new System.Drawing.Size(106, 15);
            this.lblCantidadDecos.TabIndex = 7;
            this.lblCantidadDecos.Text = "Cantidad de Decos";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(214, 241);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(87, 15);
            this.lblFormaPago.TabIndex = 8;
            this.lblFormaPago.Text = "Forma de Pago";
            // 
            // lblSenialPremium
            // 
            this.lblSenialPremium.AutoSize = true;
            this.lblSenialPremium.Location = new System.Drawing.Point(41, 241);
            this.lblSenialPremium.Name = "lblSenialPremium";
            this.lblSenialPremium.Size = new System.Drawing.Size(87, 15);
            this.lblSenialPremium.TabIndex = 9;
            this.lblSenialPremium.Text = "Señal Premium";
            // 
            // listBoxSeniales
            // 
            this.listBoxSeniales.FormattingEnabled = true;
            this.listBoxSeniales.ItemHeight = 15;
            this.listBoxSeniales.Location = new System.Drawing.Point(213, 317);
            this.listBoxSeniales.Name = "listBoxSeniales";
            this.listBoxSeniales.Size = new System.Drawing.Size(150, 94);
            this.listBoxSeniales.TabIndex = 10;
            // 
            // btnBajaSenila
            // 
            this.btnBajaSenila.Location = new System.Drawing.Point(39, 375);
            this.btnBajaSenila.Name = "btnBajaSenila";
            this.btnBajaSenila.Size = new System.Drawing.Size(152, 36);
            this.btnBajaSenila.TabIndex = 11;
            this.btnBajaSenila.Text = "Baja Señal";
            this.btnBajaSenila.UseVisualStyleBackColor = true;
            this.btnBajaSenila.Click += new System.EventHandler(this.btnBajaSenila_Click);
            // 
            // btnAltaSenila
            // 
            this.btnAltaSenila.Location = new System.Drawing.Point(41, 317);
            this.btnAltaSenila.Name = "btnAltaSenila";
            this.btnAltaSenila.Size = new System.Drawing.Size(152, 34);
            this.btnAltaSenila.TabIndex = 12;
            this.btnAltaSenila.Text = "Alta Señal";
            this.btnAltaSenila.UseVisualStyleBackColor = true;
            this.btnAltaSenila.Click += new System.EventHandler(this.btnAltaSenila_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(40, 64);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(324, 41);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar Servicios del Cliente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalirActualizar
            // 
            this.btnSalirActualizar.Location = new System.Drawing.Point(40, 434);
            this.btnSalirActualizar.Name = "btnSalirActualizar";
            this.btnSalirActualizar.Size = new System.Drawing.Size(323, 61);
            this.btnSalirActualizar.TabIndex = 14;
            this.btnSalirActualizar.Text = "Grabar y Salir";
            this.btnSalirActualizar.UseVisualStyleBackColor = true;
            this.btnSalirActualizar.Click += new System.EventHandler(this.btnSalirActualizar_Click);
            // 
            // lblSenialesContradas
            // 
            this.lblSenialesContradas.AutoSize = true;
            this.lblSenialesContradas.Location = new System.Drawing.Point(214, 299);
            this.lblSenialesContradas.Name = "lblSenialesContradas";
            this.lblSenialesContradas.Size = new System.Drawing.Size(113, 15);
            this.lblSenialesContradas.TabIndex = 15;
            this.lblSenialesContradas.Text = "Señales Contratadas";
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Location = new System.Drawing.Point(41, 24);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(68, 15);
            this.lblNumeroCliente.TabIndex = 16;
            this.lblNumeroCliente.Text = "CLIENTE N°";
            // 
            // FormServiciosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 506);
            this.Controls.Add(this.lblNumeroCliente);
            this.Controls.Add(this.lblSenialesContradas);
            this.Controls.Add(this.btnSalirActualizar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAltaSenila);
            this.Controls.Add(this.btnBajaSenila);
            this.Controls.Add(this.listBoxSeniales);
            this.Controls.Add(this.lblSenialPremium);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.lblCantidadDecos);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.tBxDireccion);
            this.Controls.Add(this.comboBoxSenialPremium);
            this.Controls.Add(this.comboBoxFormaPAgo);
            this.Controls.Add(this.comboBoxCantidadDecos);
            this.Controls.Add(this.comboBoxServicio);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormServiciosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERVICIOS DEL CLIENTE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServiciosCliente_FormClosing);
            this.Load += new System.EventHandler(this.FormServiciosCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxServicio;
        private System.Windows.Forms.ComboBox comboBoxCantidadDecos;
        private System.Windows.Forms.ComboBox comboBoxFormaPAgo;
        private System.Windows.Forms.ComboBox comboBoxSenialPremium;
        private System.Windows.Forms.TextBox tBxDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblCantidadDecos;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblSenialPremium;
        private System.Windows.Forms.ListBox listBoxSeniales;
        private System.Windows.Forms.Button btnBajaSenila;
        private System.Windows.Forms.Button btnAltaSenila;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalirActualizar;
        private System.Windows.Forms.Label lblSenialesContradas;
        private System.Windows.Forms.Label lblNumeroCliente;
    }
}
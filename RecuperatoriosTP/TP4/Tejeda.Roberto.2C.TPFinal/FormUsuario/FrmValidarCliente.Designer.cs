namespace Formularios
{
    partial class FrmValidarCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBienvenidaUsuario = new System.Windows.Forms.Label();
            this.lldDni = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblListaxmlActualizada = new System.Windows.Forms.Label();
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.dGVClientes = new System.Windows.Forms.DataGridView();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDTVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteDTVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnReclamo = new System.Windows.Forms.Button();
            this.lblDataGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDTVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDTVBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenidaUsuario
            // 
            this.lblBienvenidaUsuario.AutoSize = true;
            this.lblBienvenidaUsuario.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenidaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBienvenidaUsuario.Location = new System.Drawing.Point(12, 14);
            this.lblBienvenidaUsuario.Name = "lblBienvenidaUsuario";
            this.lblBienvenidaUsuario.Size = new System.Drawing.Size(89, 19);
            this.lblBienvenidaUsuario.TabIndex = 0;
            this.lblBienvenidaUsuario.Text = "Bienvenide ";
            // 
            // lldDni
            // 
            this.lldDni.AutoSize = true;
            this.lldDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lldDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lldDni.Location = new System.Drawing.Point(579, 14);
            this.lldDni.Name = "lldDni";
            this.lldDni.Size = new System.Drawing.Size(72, 13);
            this.lldDni.TabIndex = 3;
            this.lldDni.Text = "DNI Cliente";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDNI.Location = new System.Drawing.Point(579, 30);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(153, 20);
            this.txtDNI.TabIndex = 4;
            this.txtDNI.Text = "Cargar DNI o buscar en la lista";
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValidar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnValidar.Location = new System.Drawing.Point(579, 62);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(153, 46);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "Validar Cliente";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlta.Location = new System.Drawing.Point(738, 289);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(281, 40);
            this.btnAlta.TabIndex = 6;
            this.btnAlta.Text = "Alta de Nuevo Cliente";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeleccionar.Location = new System.Drawing.Point(738, 234);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(281, 39);
            this.btnSeleccionar.TabIndex = 7;
            this.btnSeleccionar.Text = "Seleccionar Servicios del Cliente";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(740, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(281, 50);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(738, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 218);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaHora.Location = new System.Drawing.Point(189, 14);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(96, 19);
            this.lblFechaHora.TabIndex = 11;
            this.lblFechaHora.Text = "Fecha y Hora";
            // 
            // lblListaxmlActualizada
            // 
            this.lblListaxmlActualizada.AutoSize = true;
            this.lblListaxmlActualizada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaxmlActualizada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblListaxmlActualizada.Location = new System.Drawing.Point(189, 78);
            this.lblListaxmlActualizada.Name = "lblListaxmlActualizada";
            this.lblListaxmlActualizada.Size = new System.Drawing.Size(98, 16);
            this.lblListaxmlActualizada.TabIndex = 13;
            this.lblListaxmlActualizada.Text = "BackUp en XML";
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListaClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListaClientes.Location = new System.Drawing.Point(12, 56);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(171, 37);
            this.btnListaClientes.TabIndex = 14;
            this.btnListaClientes.Text = "Cargar la Lista de Clientes";
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // dGVClientes
            // 
            this.dGVClientes.AllowUserToAddRows = false;
            this.dGVClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dGVClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVClientes.AutoGenerateColumns = false;
            this.dGVClientes.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dGVClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dGVClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dGVClientes.DataSource = this.clienteDTVBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVClientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVClientes.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dGVClientes.Location = new System.Drawing.Point(12, 117);
            this.dGVClientes.Name = "dGVClientes";
            this.dGVClientes.ReadOnly = true;
            this.dGVClientes.RowTemplate.Height = 25;
            this.dGVClientes.Size = new System.Drawing.Size(720, 332);
            this.dGVClientes.TabIndex = 15;
            this.dGVClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClientes_CellDoubleClick);
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dniDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 200;
            // 
            // clienteDTVBindingSource
            // 
            this.clienteDTVBindingSource.DataSource = typeof(Entidades.ClienteDTV);
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataSource = typeof(Entidades.Servicio);
            // 
            // clienteDTVBindingSource1
            // 
            this.clienteDTVBindingSource1.DataSource = typeof(Entidades.ClienteDTV);
            // 
            // btnReclamo
            // 
            this.btnReclamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReclamo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReclamo.Location = new System.Drawing.Point(740, 345);
            this.btnReclamo.Name = "btnReclamo";
            this.btnReclamo.Size = new System.Drawing.Size(279, 39);
            this.btnReclamo.TabIndex = 16;
            this.btnReclamo.Text = "Reclamos Cliente";
            this.btnReclamo.UseVisualStyleBackColor = true;
            this.btnReclamo.Click += new System.EventHandler(this.btnReclamo_Click);
            // 
            // lblDataGrid
            // 
            this.lblDataGrid.AutoSize = true;
            this.lblDataGrid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblDataGrid.Location = new System.Drawing.Point(14, 97);
            this.lblDataGrid.Name = "lblDataGrid";
            this.lblDataGrid.Size = new System.Drawing.Size(208, 17);
            this.lblDataGrid.TabIndex = 17;
            this.lblDataGrid.Text = "Lista de clintes en base de datos";
            // 
            // FrmValidarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 459);
            this.Controls.Add(this.lblDataGrid);
            this.Controls.Add(this.btnReclamo);
            this.Controls.Add(this.dGVClientes);
            this.Controls.Add(this.btnListaClientes);
            this.Controls.Add(this.lblListaxmlActualizada);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lldDni);
            this.Controls.Add(this.lblBienvenidaUsuario);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmValidarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validación de Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormValidarCliente_FormClosing);
            this.Load += new System.EventHandler(this.FrmValidarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDTVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDTVBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidaUsuario;
        private System.Windows.Forms.Label lldDni;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblListaxmlActualizada;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.DataGridView dGVClientes;
        private System.Windows.Forms.BindingSource clienteDTVBindingSource;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private System.Windows.Forms.BindingSource clienteDTVBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReclamo;
        private System.Windows.Forms.Label lblDataGrid;
    }
}
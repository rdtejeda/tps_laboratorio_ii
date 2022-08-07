namespace Formularios
{
    partial class FrmReclamo
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
            this.lblClienteReclam = new System.Windows.Forms.Label();
            this.chekBReclamo = new System.Windows.Forms.CheckBox();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnServiciosCliente = new System.Windows.Forms.Button();
            this.btnSelecionServicios = new System.Windows.Forms.Button();
            this.btnCargReclamo = new System.Windows.Forms.Button();
            this.txbNumeroReclamo = new System.Windows.Forms.TextBox();
            this.lblnumeroReclamo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClienteReclam
            // 
            this.lblClienteReclam.AutoSize = true;
            this.lblClienteReclam.Location = new System.Drawing.Point(12, 9);
            this.lblClienteReclam.Name = "lblClienteReclam";
            this.lblClienteReclam.Size = new System.Drawing.Size(286, 16);
            this.lblClienteReclam.TabIndex = 0;
            this.lblClienteReclam.Text = "Datos de el Cliente que reclama";
            // 
            // chekBReclamo
            // 
            this.chekBReclamo.AutoSize = true;
            this.chekBReclamo.Location = new System.Drawing.Point(428, 255);
            this.chekBReclamo.Name = "chekBReclamo";
            this.chekBReclamo.Size = new System.Drawing.Size(197, 20);
            this.chekBReclamo.TabIndex = 1;
            this.chekBReclamo.Text = "Reclamo Solucionado";
            this.chekBReclamo.UseVisualStyleBackColor = true;
            this.chekBReclamo.CheckedChanged += new System.EventHandler(this.chekBReclamo_CheckedChanged);
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("SimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDatosCliente.Location = new System.Drawing.Point(12, 42);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(124, 16);
            this.lblDatosCliente.TabIndex = 2;
            this.lblDatosCliente.Text = "Datos Cliente";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(382, 231);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(428, 316);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir y Guardar Reclamo";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnServiciosCliente
            // 
            this.btnServiciosCliente.Location = new System.Drawing.Point(428, 209);
            this.btnServiciosCliente.Name = "btnServiciosCliente";
            this.btnServiciosCliente.Size = new System.Drawing.Size(250, 40);
            this.btnServiciosCliente.TabIndex = 5;
            this.btnServiciosCliente.Text = "Modificar los Servicios del Cliente que Reclama";
            this.btnServiciosCliente.UseVisualStyleBackColor = true;
            this.btnServiciosCliente.Click += new System.EventHandler(this.btnServiciosCliente_Click);
            // 
            // btnSelecionServicios
            // 
            this.btnSelecionServicios.Location = new System.Drawing.Point(12, 72);
            this.btnSelecionServicios.Name = "btnSelecionServicios";
            this.btnSelecionServicios.Size = new System.Drawing.Size(313, 40);
            this.btnSelecionServicios.TabIndex = 6;
            this.btnSelecionServicios.Text = "Ver Los Servicios de el Cliente Nuevo Reclamo";
            this.btnSelecionServicios.UseVisualStyleBackColor = true;
            this.btnSelecionServicios.Click += new System.EventHandler(this.btnSelecionServicios_Click);
            // 
            // btnCargReclamo
            // 
            this.btnCargReclamo.Location = new System.Drawing.Point(375, 72);
            this.btnCargReclamo.Name = "btnCargReclamo";
            this.btnCargReclamo.Size = new System.Drawing.Size(303, 40);
            this.btnCargReclamo.TabIndex = 7;
            this.btnCargReclamo.Text = "Recuperar Reclamo Anterio Servicios del Cliente";
            this.btnCargReclamo.UseVisualStyleBackColor = true;
            this.btnCargReclamo.Click += new System.EventHandler(this.btnCargReclamo_Click);
            // 
            // txbNumeroReclamo
            // 
            this.txbNumeroReclamo.Location = new System.Drawing.Point(428, 134);
            this.txbNumeroReclamo.Name = "txbNumeroReclamo";
            this.txbNumeroReclamo.Size = new System.Drawing.Size(244, 26);
            this.txbNumeroReclamo.TabIndex = 8;
            // 
            // lblnumeroReclamo
            // 
            this.lblnumeroReclamo.AutoSize = true;
            this.lblnumeroReclamo.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnumeroReclamo.Location = new System.Drawing.Point(428, 115);
            this.lblnumeroReclamo.Name = "lblnumeroReclamo";
            this.lblnumeroReclamo.Size = new System.Drawing.Size(239, 13);
            this.lblnumeroReclamo.TabIndex = 9;
            this.lblnumeroReclamo.Text = "Numero de Reclamo a Recuperar";
            // 
            // FrmReclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 398);
            this.Controls.Add(this.lblnumeroReclamo);
            this.Controls.Add(this.txbNumeroReclamo);
            this.Controls.Add(this.btnCargReclamo);
            this.Controls.Add(this.btnSelecionServicios);
            this.Controls.Add(this.btnServiciosCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.chekBReclamo);
            this.Controls.Add(this.lblClienteReclam);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReclamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reclamos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReclamo_FormClosing);
            this.Load += new System.EventHandler(this.FrmReclamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClienteReclam;
        private System.Windows.Forms.CheckBox chekBReclamo;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnServiciosCliente;
        private System.Windows.Forms.Button btnSelecionServicios;
        private System.Windows.Forms.Button btnCargReclamo;
        private System.Windows.Forms.TextBox txbNumeroReclamo;
        private System.Windows.Forms.Label lblnumeroReclamo;
    }
}
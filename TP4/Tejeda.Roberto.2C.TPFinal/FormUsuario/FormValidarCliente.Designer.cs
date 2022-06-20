namespace Formularios
{
    partial class FormValidarCliente
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
            this.lblBienvenidaUsuario = new System.Windows.Forms.Label();
            this.lldDni = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblBienvenidaUsuario
            // 
            this.lblBienvenidaUsuario.AutoSize = true;
            this.lblBienvenidaUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenidaUsuario.Location = new System.Drawing.Point(4, 2);
            this.lblBienvenidaUsuario.Name = "lblBienvenidaUsuario";
            this.lblBienvenidaUsuario.Size = new System.Drawing.Size(110, 25);
            this.lblBienvenidaUsuario.TabIndex = 0;
            this.lblBienvenidaUsuario.Text = "Bienvenide ";
            // 
            // lldDni
            // 
            this.lldDni.AutoSize = true;
            this.lldDni.Location = new System.Drawing.Point(9, 39);
            this.lldDni.Name = "lldDni";
            this.lldDni.Size = new System.Drawing.Size(67, 15);
            this.lldDni.TabIndex = 3;
            this.lldDni.Text = "DNI Cliente";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(9, 68);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(153, 23);
            this.txtDNI.TabIndex = 4;
            this.txtDNI.Text = "18223125";
            // 
            // btnValidar
            // 
            this.btnValidar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValidar.Location = new System.Drawing.Point(9, 112);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(153, 46);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "Validar Cliente";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlta.Location = new System.Drawing.Point(9, 267);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(183, 74);
            this.btnAlta.TabIndex = 6;
            this.btnAlta.Text = "Alta Nuevo Cliente";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeleccionar.Location = new System.Drawing.Point(9, 177);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(153, 49);
            this.btnSeleccionar.TabIndex = 7;
            this.btnSeleccionar.Text = "Seleccionar Cliente";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(226, 267);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(192, 74);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(191, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 241);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // FormValidarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(440, 353);
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
            this.Name = "FormValidarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormValidarCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormValidarCliente_FormClosing);
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
    }
}
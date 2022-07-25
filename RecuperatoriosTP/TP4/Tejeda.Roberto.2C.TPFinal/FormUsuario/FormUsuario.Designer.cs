namespace Formularios
{
    partial class FormUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lplPassword = new System.Windows.Forms.Label();
            this.tBxNombreUsuario = new System.Windows.Forms.TextBox();
            this.tBxPassword = new System.Windows.Forms.TextBox();
            this.btnIngresarSQL = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnIngresarXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(27, 45);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(168, 25);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lplPassword
            // 
            this.lplPassword.AutoSize = true;
            this.lplPassword.Location = new System.Drawing.Point(27, 142);
            this.lplPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lplPassword.Name = "lplPassword";
            this.lplPassword.Size = new System.Drawing.Size(87, 25);
            this.lplPassword.TabIndex = 1;
            this.lplPassword.Text = "Password";
            // 
            // tBxNombreUsuario
            // 
            this.tBxNombreUsuario.Location = new System.Drawing.Point(27, 75);
            this.tBxNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBxNombreUsuario.Name = "tBxNombreUsuario";
            this.tBxNombreUsuario.Size = new System.Drawing.Size(244, 31);
            this.tBxNombreUsuario.TabIndex = 2;
            this.tBxNombreUsuario.Text = "rtejeda";
            // 
            // tBxPassword
            // 
            this.tBxPassword.Location = new System.Drawing.Point(27, 172);
            this.tBxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBxPassword.Name = "tBxPassword";
            this.tBxPassword.Size = new System.Drawing.Size(244, 31);
            this.tBxPassword.TabIndex = 3;
            this.tBxPassword.Text = "1234";
            // 
            // btnIngresarSQL
            // 
            this.btnIngresarSQL.Location = new System.Drawing.Point(27, 263);
            this.btnIngresarSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresarSQL.Name = "btnIngresarSQL";
            this.btnIngresarSQL.Size = new System.Drawing.Size(110, 77);
            this.btnIngresarSQL.TabIndex = 4;
            this.btnIngresarSQL.Text = "INGRESAR SQL";
            this.btnIngresarSQL.UseVisualStyleBackColor = true;
            this.btnIngresarSQL.Click += new System.EventHandler(this.btnIngresarSQL_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(27, 385);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(246, 77);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIngresarXML
            // 
            this.btnIngresarXML.Location = new System.Drawing.Point(166, 263);
            this.btnIngresarXML.Name = "btnIngresarXML";
            this.btnIngresarXML.Size = new System.Drawing.Size(105, 77);
            this.btnIngresarXML.TabIndex = 6;
            this.btnIngresarXML.Text = "INGRESAR XML";
            this.btnIngresarXML.UseVisualStyleBackColor = true;
            this.btnIngresarXML.Click += new System.EventHandler(this.btnIngresarXML_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 520);
            this.Controls.Add(this.btnIngresarXML);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIngresarSQL);
            this.Controls.Add(this.tBxPassword);
            this.Controls.Add(this.tBxNombreUsuario);
            this.Controls.Add(this.lplPassword);
            this.Controls.Add(this.lblNombreUsuario);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario Aplicación DTV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsuario_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lplPassword;
        private System.Windows.Forms.TextBox tBxNombreUsuario;
        private System.Windows.Forms.TextBox tBxPassword;
        private System.Windows.Forms.Button btnIngresarSQL;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnIngresarXML;
    }
}

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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(19, 27);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(110, 15);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lplPassword
            // 
            this.lplPassword.AutoSize = true;
            this.lplPassword.Location = new System.Drawing.Point(19, 85);
            this.lplPassword.Name = "lplPassword";
            this.lplPassword.Size = new System.Drawing.Size(57, 15);
            this.lplPassword.TabIndex = 1;
            this.lplPassword.Text = "Password";
            // 
            // tBxNombreUsuario
            // 
            this.tBxNombreUsuario.Location = new System.Drawing.Point(19, 45);
            this.tBxNombreUsuario.Name = "tBxNombreUsuario";
            this.tBxNombreUsuario.Size = new System.Drawing.Size(172, 23);
            this.tBxNombreUsuario.TabIndex = 2;
            this.tBxNombreUsuario.Text = "rtejeda";
            // 
            // tBxPassword
            // 
            this.tBxPassword.Location = new System.Drawing.Point(19, 103);
            this.tBxPassword.Name = "tBxPassword";
            this.tBxPassword.Size = new System.Drawing.Size(172, 23);
            this.tBxPassword.TabIndex = 3;
            this.tBxPassword.Text = "1234";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(19, 158);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(172, 46);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(19, 231);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(172, 46);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Formularios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(211, 312);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.tBxPassword);
            this.Controls.Add(this.tBxNombreUsuario);
            this.Controls.Add(this.lplPassword);
            this.Controls.Add(this.lblNombreUsuario);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formularios";
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
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

namespace ProyectoAnalisisHuberth
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnPlatos = new System.Windows.Forms.Button();
            this.ContentPane = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(114, 12);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(127, 23);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Iniciar sesion";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Location = new System.Drawing.Point(378, 12);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(75, 23);
            this.BtnUsuarios.TabIndex = 1;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnPlatos
            // 
            this.BtnPlatos.Location = new System.Drawing.Point(624, 12);
            this.BtnPlatos.Name = "BtnPlatos";
            this.BtnPlatos.Size = new System.Drawing.Size(75, 23);
            this.BtnPlatos.TabIndex = 2;
            this.BtnPlatos.Text = "Platos";
            this.BtnPlatos.UseVisualStyleBackColor = true;
            this.BtnPlatos.Click += new System.EventHandler(this.BtnPlatos_Click);
            // 
            // ContentPane
            // 
            this.ContentPane.BackColor = System.Drawing.Color.White;
            this.ContentPane.Location = new System.Drawing.Point(56, 55);
            this.ContentPane.Name = "ContentPane";
            this.ContentPane.Size = new System.Drawing.Size(680, 420);
            this.ContentPane.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.ContentPane);
            this.Controls.Add(this.BtnPlatos);
            this.Controls.Add(this.BtnUsuarios);
            this.Controls.Add(this.BtnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnPlatos;
        private System.Windows.Forms.Panel ContentPane;
    }
}


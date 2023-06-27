namespace ProyectoAnalisisHuberth.Presentacion
{
    partial class Login
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
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtNUser = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.DarkRed;
            this.LblUserName.Location = new System.Drawing.Point(38, 188);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(113, 13);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "Nombre de usuario";
            // 
            // TxtNUser
            // 
            this.TxtNUser.ForeColor = System.Drawing.Color.Black;
            this.TxtNUser.Location = new System.Drawing.Point(39, 207);
            this.TxtNUser.Name = "TxtNUser";
            this.TxtNUser.Size = new System.Drawing.Size(194, 20);
            this.TxtNUser.TabIndex = 2;
            this.TxtNUser.Tag = "";
            // 
            // TxtPass
            // 
            this.TxtPass.ForeColor = System.Drawing.Color.Black;
            this.TxtPass.Location = new System.Drawing.Point(39, 256);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(194, 20);
            this.TxtPass.TabIndex = 4;
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.Color.DarkRed;
            this.LblPass.Location = new System.Drawing.Point(38, 237);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(71, 13);
            this.LblPass.TabIndex = 3;
            this.LblPass.Text = "Contraseña";
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnLogin.Location = new System.Drawing.Point(141, 332);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(92, 36);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Iniciar sesion";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.Location = new System.Drawing.Point(39, 332);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(84, 36);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(77, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 123);
            this.panel1.TabIndex = 0;
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(283, 439);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.TxtNUser);
            this.Controls.Add(this.LblUserName);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtNUser;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ErrorProvider errorValidacion;
    }
}
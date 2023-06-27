namespace ProyectoAnalisisHuberth.Presentacion
{
    partial class FormUsuarios
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
            this.ErrorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GbInfoUsers = new System.Windows.Forms.GroupBox();
            this.TxtPrivilegios = new System.Windows.Forms.TextBox();
            this.LblPrivilegios = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.TxtUsrName = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidacion)).BeginInit();
            this.GbInfoUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorValidacion
            // 
            this.ErrorValidacion.ContainerControl = this;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Red;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(511, 270);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(116, 34);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.AutoSize = true;
            this.BtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.ForeColor = System.Drawing.Color.Red;
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(511, 228);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(116, 34);
            this.BtnListar.TabIndex = 24;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Red;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(511, 188);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(116, 34);
            this.BtnBuscar.TabIndex = 23;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSize = true;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Red;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(511, 148);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 34);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(250, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "GESTION DE USUARIOS";
            // 
            // GbInfoUsers
            // 
            this.GbInfoUsers.Controls.Add(this.TxtPrivilegios);
            this.GbInfoUsers.Controls.Add(this.LblPrivilegios);
            this.GbInfoUsers.Controls.Add(this.TxtPass);
            this.GbInfoUsers.Controls.Add(this.LblPass);
            this.GbInfoUsers.Controls.Add(this.TxtUsrName);
            this.GbInfoUsers.Controls.Add(this.LblNombre);
            this.GbInfoUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbInfoUsers.ForeColor = System.Drawing.Color.Red;
            this.GbInfoUsers.Location = new System.Drawing.Point(85, 117);
            this.GbInfoUsers.Name = "GbInfoUsers";
            this.GbInfoUsers.Size = new System.Drawing.Size(406, 212);
            this.GbInfoUsers.TabIndex = 26;
            this.GbInfoUsers.TabStop = false;
            this.GbInfoUsers.Text = "Informacion del Usuario";
            // 
            // TxtPrivilegios
            // 
            this.TxtPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrivilegios.Location = new System.Drawing.Point(162, 137);
            this.TxtPrivilegios.Name = "TxtPrivilegios";
            this.TxtPrivilegios.Size = new System.Drawing.Size(213, 22);
            this.TxtPrivilegios.TabIndex = 36;
            // 
            // LblPrivilegios
            // 
            this.LblPrivilegios.AutoSize = true;
            this.LblPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrivilegios.ForeColor = System.Drawing.Color.Black;
            this.LblPrivilegios.Location = new System.Drawing.Point(30, 140);
            this.LblPrivilegios.Name = "LblPrivilegios";
            this.LblPrivilegios.Size = new System.Drawing.Size(70, 16);
            this.LblPrivilegios.TabIndex = 35;
            this.LblPrivilegios.Text = "Privilegios";
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(163, 88);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(213, 22);
            this.TxtPass.TabIndex = 34;
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.Color.Black;
            this.LblPass.Location = new System.Drawing.Point(30, 91);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(76, 16);
            this.LblPass.TabIndex = 29;
            this.LblPass.Text = "Contraseña";
            // 
            // TxtUsrName
            // 
            this.TxtUsrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsrName.Location = new System.Drawing.Point(162, 46);
            this.TxtUsrName.Name = "TxtUsrName";
            this.TxtUsrName.Size = new System.Drawing.Size(214, 22);
            this.TxtUsrName.TabIndex = 28;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Black;
            this.LblNombre.Location = new System.Drawing.Point(29, 49);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(122, 16);
            this.LblNombre.TabIndex = 27;
            this.LblNombre.Text = "Nombre de usuario";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.GbInfoUsers);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidacion)).EndInit();
            this.GbInfoUsers.ResumeLayout(false);
            this.GbInfoUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorValidacion;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbInfoUsers;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.TextBox TxtUsrName;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtPrivilegios;
        private System.Windows.Forms.Label LblPrivilegios;
    }
}
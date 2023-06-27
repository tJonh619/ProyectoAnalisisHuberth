namespace ProyectoAnalisisHuberth.Presentacion
{
    partial class FormPlatos
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
            this.Content = new System.Windows.Forms.Panel();
            this.GbInfoPlato = new System.Windows.Forms.GroupBox();
            this.LblGrasa = new System.Windows.Forms.Label();
            this.TxtGrasa = new System.Windows.Forms.TextBox();
            this.LblKiloCal = new System.Windows.Forms.Label();
            this.TxtKiloCal = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.MskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.ErrorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.Content.SuspendLayout();
            this.GbInfoPlato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.White;
            this.Content.Controls.Add(this.GbInfoPlato);
            this.Content.Controls.Add(this.BtnEliminar);
            this.Content.Controls.Add(this.BtnListar);
            this.Content.Controls.Add(this.BtnBuscar);
            this.Content.Controls.Add(this.BtnGuardar);
            this.Content.Controls.Add(this.LblTitulo);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(680, 420);
            this.Content.TabIndex = 0;
            // 
            // GbInfoPlato
            // 
            this.GbInfoPlato.Controls.Add(this.LblGrasa);
            this.GbInfoPlato.Controls.Add(this.TxtGrasa);
            this.GbInfoPlato.Controls.Add(this.LblKiloCal);
            this.GbInfoPlato.Controls.Add(this.TxtKiloCal);
            this.GbInfoPlato.Controls.Add(this.LblNombre);
            this.GbInfoPlato.Controls.Add(this.TxtNombre);
            this.GbInfoPlato.Controls.Add(this.LblDescripcion);
            this.GbInfoPlato.Controls.Add(this.MskCodigo);
            this.GbInfoPlato.Controls.Add(this.LblCodigo);
            this.GbInfoPlato.Controls.Add(this.TxtDescripcion);
            this.GbInfoPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbInfoPlato.ForeColor = System.Drawing.Color.Red;
            this.GbInfoPlato.Location = new System.Drawing.Point(94, 83);
            this.GbInfoPlato.Name = "GbInfoPlato";
            this.GbInfoPlato.Size = new System.Drawing.Size(382, 298);
            this.GbInfoPlato.TabIndex = 19;
            this.GbInfoPlato.TabStop = false;
            this.GbInfoPlato.Text = "Informacion del Plato";
            // 
            // LblGrasa
            // 
            this.LblGrasa.AutoSize = true;
            this.LblGrasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrasa.ForeColor = System.Drawing.Color.Black;
            this.LblGrasa.Location = new System.Drawing.Point(17, 259);
            this.LblGrasa.Name = "LblGrasa";
            this.LblGrasa.Size = new System.Drawing.Size(131, 16);
            this.LblGrasa.TabIndex = 24;
            this.LblGrasa.Text = "Porcentaje de Grasa";
            // 
            // TxtGrasa
            // 
            this.TxtGrasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGrasa.Location = new System.Drawing.Point(168, 256);
            this.TxtGrasa.Name = "TxtGrasa";
            this.TxtGrasa.Size = new System.Drawing.Size(77, 22);
            this.TxtGrasa.TabIndex = 25;
            this.TxtGrasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGrasa_KeyPress);
            // 
            // LblKiloCal
            // 
            this.LblKiloCal.AutoSize = true;
            this.LblKiloCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKiloCal.ForeColor = System.Drawing.Color.Black;
            this.LblKiloCal.Location = new System.Drawing.Point(17, 220);
            this.LblKiloCal.Name = "LblKiloCal";
            this.LblKiloCal.Size = new System.Drawing.Size(79, 16);
            this.LblKiloCal.TabIndex = 22;
            this.LblKiloCal.Text = "KiloCalorias";
            // 
            // TxtKiloCal
            // 
            this.TxtKiloCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKiloCal.Location = new System.Drawing.Point(168, 217);
            this.TxtKiloCal.Name = "TxtKiloCal";
            this.TxtKiloCal.Size = new System.Drawing.Size(77, 22);
            this.TxtKiloCal.TabIndex = 23;
            this.TxtKiloCal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKiloCal_KeyPress);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Black;
            this.LblNombre.Location = new System.Drawing.Point(17, 71);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(112, 16);
            this.LblNombre.TabIndex = 12;
            this.LblNombre.Text = "Nombre del Plato";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(168, 68);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(188, 22);
            this.TxtNombre.TabIndex = 13;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.LblDescripcion.Location = new System.Drawing.Point(17, 147);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.LblDescripcion.TabIndex = 14;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // MskCodigo
            // 
            this.MskCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCodigo.Location = new System.Drawing.Point(168, 33);
            this.MskCodigo.Mask = "AAA";
            this.MskCodigo.Name = "MskCodigo";
            this.MskCodigo.Size = new System.Drawing.Size(188, 22);
            this.MskCodigo.TabIndex = 21;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Black;
            this.LblCodigo.Location = new System.Drawing.Point(22, 36);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(51, 16);
            this.LblCodigo.TabIndex = 20;
            this.LblCodigo.Text = "Codigo";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(168, 105);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(188, 98);
            this.TxtDescripcion.TabIndex = 17;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Red;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(500, 274);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(116, 34);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.ForeColor = System.Drawing.Color.Red;
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(500, 232);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(116, 34);
            this.BtnListar.TabIndex = 17;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Red;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(500, 192);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(116, 34);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Red;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(500, 152);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 34);
            this.BtnGuardar.TabIndex = 13;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Red;
            this.LblTitulo.Location = new System.Drawing.Point(227, 38);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(216, 25);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "GESTION DE PLATOS";
            // 
            // ErrorValidacion
            // 
            this.ErrorValidacion.ContainerControl = this;
            // 
            // FormPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.Content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlatos";
            this.Text = "Clientes";
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.GbInfoPlato.ResumeLayout(false);
            this.GbInfoPlato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ErrorProvider ErrorValidacion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.MaskedTextBox MskCodigo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.GroupBox GbInfoPlato;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblKiloCal;
        private System.Windows.Forms.TextBox TxtKiloCal;
        private System.Windows.Forms.Label LblGrasa;
        private System.Windows.Forms.TextBox TxtGrasa;
    }
}
using ProyectoAnalisisHuberth.Negocio;
using ProyectoAnalisisHuberth.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnalisisHuberth.Presentacion
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        public void VaciarCampos()
        {
            TxtUsrName.Text = "";
            TxtPass.Text = "";
            TxtPrivilegios.Text = "";
        }


        public bool FormValidation()
        {
            bool Valido = true;//booleano que indica el estado de los campos

            //Validad campos de texto

            
            if (String.IsNullOrWhiteSpace(TxtUsrName.Text))
            {
                Valido = false; //No se ingreso el nombre
                ErrorValidacion.SetIconPadding(TxtUsrName, 6);
                ErrorValidacion.SetError(TxtUsrName, " debe ingresar el nombre de usuario");
            }
            if (String.IsNullOrWhiteSpace(TxtPass.Text))
            {
                Valido = false; //No se ingreso contraseña
                ErrorValidacion.SetIconPadding(TxtPass, 6);
                ErrorValidacion.SetError(TxtPass, " debe ingresar una contraseña");
            }
            if (String.IsNullOrWhiteSpace(TxtPrivilegios.Text))
            {
                Valido = false; //No se ingreso el nombre
                ErrorValidacion.SetIconPadding(TxtPrivilegios, 6);
                ErrorValidacion.SetError(TxtPrivilegios, " ingrese este dato");
            }

            return Valido;

        }
        public void DeleteInfoMessage()
        {
            ErrorValidacion.SetError(TxtUsrName, "");
            ErrorValidacion.SetError(TxtPass, "");
            ErrorValidacion.SetError(TxtPrivilegios, "");
        }
        

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Usuarios usr = new Usuarios();

            DeleteInfoMessage(); //Borra los errores en caso de que los haya
            FormValidation(); //Valida si todos los campos estan llenados de forma adecuada

            if (FormValidation())
            {
                usr.NombreUsr1 = TxtUsrName.Text;
                usr.Contraseña1 = TxtPass.Text;
                usr.Privilegios1 = TxtPrivilegios.Text;

                if (usr.GrabarUsuario())
                {
                    MessageBox.Show("Registro guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                VaciarCampos();
            }
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Usuarios usr = new Usuarios();

            if (string.IsNullOrEmpty(TxtUsrName.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Usuario user = usr.Buscar(TxtUsrName.Text, true);

                if(user != null) 
                {
                    TxtUsrName.Text = user.Usuario1;
                    TxtPass.Text = user.Clave;
                    TxtPrivilegios.Text = user.Privilegios;
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Usuarios usr = new Usuarios();

            if (string.IsNullOrEmpty(TxtUsrName.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de Usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar este usuario? ", "Advertencia", MessageBoxButtons.OKCancel);

                
                if(dialogResult==DialogResult.OK)
                {
                    usr.BorrarUsuario(TxtUsrName.Text);
                    MessageBox.Show("Se elimino este usuario", "Eliminado", MessageBoxButtons.OK);
                    VaciarCampos();
                }
            }
            
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            FormListUsuarios listUsrs = new FormListUsuarios
            {
                MdiParent = this.MdiParent
            };
            AddOwnedForm(listUsrs);
            listUsrs.Show();
            listUsrs.BringToFront();
        }
    }
}
                                                        
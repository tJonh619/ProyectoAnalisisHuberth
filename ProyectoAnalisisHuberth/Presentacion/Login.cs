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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool Validacion()
        {
            bool valido = true;

            if (String.IsNullOrEmpty(TxtNUser.Text))
            {
                valido = false;
                errorValidacion.SetIconPadding(TxtNUser, 6);
                errorValidacion.SetError(TxtNUser, "ingrese el nombre de usuario");
            }
            if (String.IsNullOrEmpty(TxtPass.Text))
            {
                valido = false;
                errorValidacion.SetIconPadding(TxtPass, 6);
                errorValidacion.SetError(TxtPass, "ingrese la contraseña");
            }

            return valido;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Validacion();
            if(Validacion())
            {
                Usuarios usrs = new Usuarios();
                Usuario user = usrs.Buscar(TxtNUser.Text, false);
                if (user != null)
                {
                    if (user.Clave == TxtPass.Text)
                    {
                        Form1 db = Owner as Form1;
                        db.ValLogin(true);
                        db.Enabled = true;
                        db.PanelLogin(true);
                        MessageBox.Show("Inicio de sesion correcto\nBienvenido "+ user.Usuario1, "Verificado", MessageBoxButtons.OK);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Se ingreso una contraseña incorrecta", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("No existe este usuario", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}

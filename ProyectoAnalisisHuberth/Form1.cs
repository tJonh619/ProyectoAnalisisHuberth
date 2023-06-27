using ProyectoAnalisisHuberth.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnalisisHuberth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void PanelCentral(Form formSeleccionada)
        {
            if (ContentPane.Controls.Count > 0)
            {
                ContentPane.Controls.RemoveAt(0);
            }

            Form fc = formSeleccionada;

            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            ContentPane.Controls.Add(fc);
            ContentPane.Tag = fc;
            fc.Show();
        }
        public void PanelLogin(bool band)
        {
            if (band == true)
            {
                BtnLogin.Text = "Cerrar Sesion";
            }
            else
            {
                BtnLogin.Text = "Iniciar sesion";
            }
        }
        public void ValLogin(bool band)
        {
            BtnPlatos.Enabled = band;
            BtnUsuarios.Enabled = band;
            ContentPane.Enabled = band;
        }
        private void AbrirLogin()
        {
            ValLogin(false);
            Enabled = false;
            Login lg = new Login
            {
                MdiParent = this.MdiParent
            };
            AddOwnedForm(lg);
            lg.Show();
            lg.BringToFront();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Iniciar sesion")
            {
                AbrirLogin();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de cerrar sesion? ", "Advertencia", MessageBoxButtons.OKCancel);


                if (dialogResult == DialogResult.OK)
                {
                    PanelLogin(false);
                    MessageBox.Show("Se cerro sesion. vuelva a ingresar sus credenciales", "Sesion Cerrada", MessageBoxButtons.OK);
                    AbrirLogin();
                }
            }
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            PanelCentral(new FormUsuarios());
        }
        private void BtnPlatos_Click(object sender, EventArgs e)
        {
            PanelCentral(new FormPlatos());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ValLogin(false);
        }
    }
}

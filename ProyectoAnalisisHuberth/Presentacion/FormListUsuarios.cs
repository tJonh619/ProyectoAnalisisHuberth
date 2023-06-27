using ProyectoAnalisisHuberth.Negocio;
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
    public partial class FormListUsuarios : Form
    {
        public FormListUsuarios()
        {
            InitializeComponent();
        }

        private void FormListUsuarios_Load(object sender, EventArgs e)
        {
            Usuarios usr = new Usuarios();
            DataTable dt = usr.ListarUsuarios();
            DgvListClientes.DataSource = dt;
        }
    }
}

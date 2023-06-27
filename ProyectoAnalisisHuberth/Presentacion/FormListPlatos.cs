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
    public partial class FormListPlatos : Form
    {
        public FormListPlatos()
        {
            InitializeComponent();
        }

        private void FormListPlatos_Load(object sender, EventArgs e)
        {
            Platos plto = new Platos();
            DataTable dt = plto.ListarPlatos();
            DgvListPlatos.DataSource = dt;
            
        }
    }
}

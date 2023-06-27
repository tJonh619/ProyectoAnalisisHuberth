using ProyectoAnalisisHuberth.Datos;
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
    public partial class FormPlatos : Form
    {
        public FormPlatos()
        {
            InitializeComponent();
        }

        
        public bool FormValidation()
        {
            bool Valido = true;//booleano que indica el estado de los campos

            //Validad campos de texto

            if (!MskCodigo.MaskFull)
            {
                Valido = false; //No se ingreso el nombre
                ErrorValidacion.SetIconPadding(MskCodigo, 6);
                ErrorValidacion.SetError(MskCodigo, " debe ingresar el Codigo del plato");
            }
            if (String.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                Valido = false; //No se ingreso el nombre
                ErrorValidacion.SetIconPadding(TxtNombre, 6);
                ErrorValidacion.SetError(TxtNombre, " debe ingresar el nombre");
            }
            if (String.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                Valido = false; //No se ingreso el primer apellido
                ErrorValidacion.SetIconPadding(TxtDescripcion, 6);
                ErrorValidacion.SetError(TxtDescripcion, "debe ingresar la descripcion");
            }
            if (String.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                Valido = false; //No se ingreso calorias
                ErrorValidacion.SetIconPadding(TxtKiloCal, 6);
                ErrorValidacion.SetError(TxtKiloCal, "debe ingresar la cantidad de kilocalorias");
            }
            if (String.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                Valido = false; //No se ingreso el primer apellido
                ErrorValidacion.SetIconPadding(TxtGrasa, 6);
                ErrorValidacion.SetError(TxtGrasa, "debe ingresar el porcentaje de grasa");
            }

            return Valido;

        }
        public void DeleteInfoMessage()
        {
            ErrorValidacion.SetError(MskCodigo, "");
            ErrorValidacion.SetError(TxtNombre, "");
            ErrorValidacion.SetError(TxtDescripcion, "");
            ErrorValidacion.SetError(TxtKiloCal, "");
            ErrorValidacion.SetError(TxtGrasa, "");
        }
        public void VaciarCampos()
        {
            MskCodigo.Text ="";
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            TxtKiloCal.Text = "";
            TxtGrasa.Text = "";
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Platos plato = new Platos();

            DeleteInfoMessage(); //Borra los errores en caso de que los haya
            FormValidation(); //Valida si todos los campos estan llenados de forma adecuada

            if (FormValidation())
            {
                plato.Codigo1 = (MskCodigo.Text);
                plato.Nombre1 = TxtNombre.Text;
                plato.Descripcion1 = TxtDescripcion.Text;
                plato.KiloCal1 = int.Parse(TxtKiloCal.Text);
                plato.GrasaPorcent1 = int.Parse(TxtGrasa.Text);

                if (plato.GrabarPlato())
                {
                    MessageBox.Show("Registro guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                VaciarCampos();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Platos plto = new Platos();

            if(string.IsNullOrEmpty(MskCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un codigo de plato para poder buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Plato plato = plto.Buscar(MskCodigo.Text, true);

                if(plato != null) 
                {
                    MskCodigo.Text = plato.Codigo;
                    TxtNombre.Text = plato.Nombre;
                    TxtDescripcion.Text = plato.Descripcion;
                    TxtKiloCal.Text = plato.KiloCalorias.ToString();
                    TxtGrasa.Text = plato.PorcentajeDeGrasa.ToString();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
            Platos plto = new Platos();

            if (string.IsNullOrEmpty(MskCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un codigo de plato para poder eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar este Plato? ", "Advertencia", MessageBoxButtons.OKCancel);

                
                if(dialogResult==DialogResult.OK)
                {
                    plto.BorrarPlato(MskCodigo.Text);
                    MessageBox.Show("Se elimino este plato", "Eliminado", MessageBoxButtons.OK);
                    VaciarCampos();
                }
            }
            
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            FormListPlatos listPl = new FormListPlatos
            {
                MdiParent = this.MdiParent
            };
            AddOwnedForm(listPl);
            listPl.Show();
            listPl.BringToFront();
        }

        private void TxtKiloCal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }


        private void TxtGrasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
                                                        
using ProyectoAnalisisHuberth.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnalisisHuberth.Negocio
{
    public class Platos
    {
        int Id;
        string Codigo;
        string Nombre;
        string Descripcion;
        int KiloCal;
        int GrasaPorcent;
        bool Estado;

        public Platos()
        {
            Estado = true;
        }
        public Platos(int id, string codigo, string nombre, string descripcion, int kiloCal, int grasaPorcent, bool estado)
        {
            Id1 = id;
            Codigo1 = codigo;
            Nombre1 = nombre;
            Descripcion1 = descripcion;
            KiloCal1 = kiloCal;
            GrasaPorcent1 = grasaPorcent;
            Estado1 = estado;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int KiloCal1 { get => KiloCal; set => KiloCal = value; }
        public int GrasaPorcent1 { get => GrasaPorcent; set => GrasaPorcent = value; }
        public bool Estado1 { get => Estado; set => Estado = value; }


        public bool GrabarPlato()
        {
            using (DBRestaurante db = new DBRestaurante())
            {
                Plato plato = new Plato();

                var newPt = db.Platos.FirstOrDefault(p => p.Codigo == this.Codigo);

                if (newPt != null)
                {
                    var update = (from pt in db.Platos
                                  where pt.Codigo.Equals(this.Codigo)
                                  select pt).FirstOrDefault();
                    update.Codigo = this.Codigo;
                    update.Nombre = this.Nombre;
                    update.Descripcion = this.Descripcion;
                    update.KiloCalorias = this.KiloCal;
                    update.PorcentajeDeGrasa = GrasaPorcent;

                }
                else
                {

                    plato.Codigo = this.Codigo;
                    plato.Nombre = this.Nombre;
                    plato.Descripcion = this.Descripcion;
                    plato.KiloCalorias = this.KiloCal;
                    plato.PorcentajeDeGrasa = GrasaPorcent;
                    plato.Estado = this.Estado;
                    db.Platos.Add(plato);

                }

                try
                {
                    return (db.SaveChanges() > 0);
                }
                catch
                {
                    throw new System.ArgumentNullException();
                    throw new System.InvalidOperationException();
                    throw new System.Data.Entity.Infrastructure.DbUpdateConcurrencyException();
                }
            }
        }

        public Plato Buscar(string codigo, bool mensaje)
        {
            //Crear un nuevo contexto hacia el modelo
            using (DBRestaurante db = new DBRestaurante())
            {
                Plato plato;
                try
                {
                    plato = db.Platos.First(p => p.Codigo == codigo);
                }
                catch
                {
                    if (mensaje == true)
                    {
                        MessageBox.Show("No hay ningun registro con este codigo", "Error", MessageBoxButtons.OK);
                    }
                    plato = null;
                }
                return plato;
            }
        }
        public Plato BuscarID(int iD)
        {
            //Crear un nuevo contexto hacia el modelo
            using (DBRestaurante db = new DBRestaurante())
            {
                Plato plato;
                try
                {
                    plato = db.Platos.First(c => c.Id == iD);
                }
                catch
                {
                    MessageBox.Show("No hay ningun registro con este codigo", "Error", MessageBoxButtons.OK);
                    plato = null;
                }

                return plato;
            }
        }

        public DataTable ListarPlatos()
        {
            using (DBRestaurante dbORM = new DBRestaurante())
            {
                DataTable dtPlatos = new DataTable();
                dtPlatos.Columns.Add("Id", typeof(int));
                dtPlatos.Columns.Add("Codigo", typeof(string));
                dtPlatos.Columns.Add("Nombre", typeof(string));
                dtPlatos.Columns.Add("Descripcion", typeof(string));
                dtPlatos.Columns.Add("KiloCalorias", typeof(int));
                dtPlatos.Columns.Add("Porcentaje de grasa", typeof(int));
                dtPlatos.Columns.Add("Estado", typeof(string));

                var dgv = (from pt in dbORM.Platos
                           select new
                           {
                               Id = pt.Id,
                               Codigo = pt.Codigo,
                               Nombre = pt.Nombre,
                               Descripcion = pt.Descripcion,
                               KiloCalorias = pt.KiloCalorias,
                               PorcentajeGrasa = pt.PorcentajeDeGrasa,
                               Estado = pt.Estado
                           }).ToList();
                foreach (var o in dgv)
                {
                    string est;
                    if (o.Estado == true)
                    {
                        est = "Activo";
                    }
                    else
                    {
                        est = "Inactivo";
                    }
                    dtPlatos.Rows.Add(new object[] { o.Id, o.Codigo, o.Nombre, o.Descripcion, o.KiloCalorias, o.PorcentajeGrasa, est });
                }
                return dtPlatos;
            }
        }
        public bool BorrarPlato(string codigo)
        {
            //Borra el registro del cliente especificado
            using (DBRestaurante db = new DBRestaurante())
            {
                Plato plato = new Plato();

                var newClte = db.Platos.FirstOrDefault(c => c.Codigo == codigo);
                if (newClte != null)
                {
                    var update = (from pt in db.Platos
                                  where pt.Codigo.Equals(codigo)
                                  select pt).FirstOrDefault();
                    update.Estado = false;
                }
                return (db.SaveChanges() > 0);
            }
        }
    }
}

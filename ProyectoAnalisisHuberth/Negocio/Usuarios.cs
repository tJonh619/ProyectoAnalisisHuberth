using ProyectoAnalisisHuberth.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnalisisHuberth.Negocio
{
    public class Usuarios
    {
        int Id;
        string NombreUsr;
        string Contraseña;
        string Privilegios;
        bool Estado;

        public Usuarios()
        {
            Estado = true;
        }

        public Usuarios(int id, string nombreUsr, string contraseña, string privilegios, bool estado)
        {
            Id1 = id;
            NombreUsr1 = nombreUsr;
            Contraseña1 = contraseña;
            Privilegios1 = privilegios;
            Estado1 = estado;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string NombreUsr1 { get => NombreUsr; set => NombreUsr = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public string Privilegios1 { get => Privilegios; set => Privilegios = value; }
        public bool Estado1 { get => Estado; set => Estado = value; }


        public bool GrabarUsuario()
        {
            using (DBRestaurante db = new DBRestaurante())
            {
                Usuario usr = new Usuario();

                var newUsr = db.Usuarios.FirstOrDefault(u => u.Usuario1 == this.NombreUsr);

                if (newUsr != null)
                {
                    var update = (from us in db.Usuarios
                                  where us.Usuario1.Equals(this.NombreUsr)
                                  select us).FirstOrDefault();
                    update.Usuario1 = this.NombreUsr;
                    update.Clave = this.Contraseña;
                    update.Privilegios = this.Privilegios;

                }
                else
                {
                    usr.Usuario1 = this.NombreUsr;
                    usr.Clave = this.Contraseña;
                    usr.Privilegios = this.Privilegios;
                    usr.Estado = this.Estado;
                    db.Usuarios.Add(usr);

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

        public Usuario Buscar(string username, bool mensaje)
        {
            using (DBRestaurante db = new DBRestaurante())
            {
                Usuario usr;
                try
                {
                    usr = db.Usuarios.First(us => us.Usuario1 == username);
                }
                catch
                {
                    if (mensaje == true)
                    {
                        MessageBox.Show("No existe este usuario", "Error", MessageBoxButtons.OK);
                    }
                    usr = null;
                }
                return usr;
            }

        }

        public DataTable ListarUsuarios()
        {
            using (DBRestaurante db = new DBRestaurante())
            {
                DataTable dtUsuarios = new DataTable();
                dtUsuarios.Columns.Add("Id", typeof(int));
                dtUsuarios.Columns.Add("Nombre Usuario", typeof(string));
                dtUsuarios.Columns.Add("Contraseña", typeof(string));
                dtUsuarios.Columns.Add("Estado", typeof(string));
                var dgv = (from usr in db.Usuarios
                           select new
                           {
                               Id = usr.Id,
                               NombreUsuario = usr.Usuario1,
                               Clave = usr.Clave,
                               Estado= usr.Estado
                           }).ToList();
                foreach (var o in dgv)
                {
                    string est;
                    if(o.Estado == true)
                    {
                        est = "Activo";
                    }
                    else
                    {
                        est = "Inactivo";
                    }
                    string clave="";
                    for(int i=0; i < o.Clave.Length; i++)
                    {
                        clave+= "*";
                    }
                    dtUsuarios.Rows.Add(new object[] { o.Id, o.NombreUsuario, clave, est });
                }
                return dtUsuarios;
            }
        }

        public bool BorrarUsuario(string username)
        {
            //desactiva el registro del Usuario especificado
            using(DBRestaurante db = new DBRestaurante())
            {
                Usuario usr = new Usuario();
                var newUsr = db.Usuarios.FirstOrDefault(u => u.Usuario1 == username);
                if (newUsr != null)
                {
                    var update = (from us in db.Usuarios
                                  where us.Usuario1.Equals(username)
                                  select us).FirstOrDefault();
                    update.Estado = false;
                }
                return (db.SaveChanges() > 0);
            }
        }
    }
}

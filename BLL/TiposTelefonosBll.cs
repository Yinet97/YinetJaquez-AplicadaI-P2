using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class TiposTelefonosBll
    {
        public static bool Guardar(TiposTelefonos t)
        {
            bool retorno = false;
            try
            {
                Parcial2Db db = new Parcial2Db();
                db.TipoTelefono.Add(t);
                foreach (var c in t.Clientes)
                {
                    db.Entry(c).State = System.Data.Entity.EntityState.Unchanged;
                }

                db.SaveChanges();
                retorno = true;

            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public static TiposTelefonos Buscar(int id)
        {
            TiposTelefonos t;
            using (var db = new Parcial2Db())
            {
                t = db.TipoTelefono.Find(id);
                t.Clientes.Count();
            }
            return t;
        }

        public static List<TiposTelefonos> GetLista()
        {
            var lista = new List<TiposTelefonos>();
            var db = new Parcial2Db();

            lista = db.TipoTelefono.ToList();

            return lista;
        }
    }
}

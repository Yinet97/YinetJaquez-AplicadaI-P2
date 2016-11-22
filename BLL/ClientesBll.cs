using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class ClientesBll
    {
            public static bool Guardar(Clientes c)
            {
                bool retorno = false;
                try
                {
                    Parcial2Db db = new Parcial2Db();
                    db.Cliente.Add(c);
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }

            public static List<Clientes> GetLista()
            {
                var lista = new List<Clientes>();
                var db = new Parcial2Db();

                lista = db.Cliente.ToList();

                return lista;
            }

            public static Clientes Buscar(int id)
            {
                Clientes c = new Clientes();
                using (var db = new Parcial2Db())
                {
                    c = db.Cliente.Find(id);
                }
                return c;
            }

        public static bool Eliminar(int id)
        {
            bool retorno = false;

            try
            {
                using (Parcial2Db db = new Parcial2Db())
                {
                    Clientes user = (from c in db.Cliente where c.ClienteId == id select c).FirstOrDefault();
                    db.Cliente.Remove(user);
                    db.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public static List<Clientes> GetLista(int id)
        {
            List<Clientes> lista = new List<Clientes>();
            Parcial2Db db = new Parcial2Db();

            lista = db.Cliente.Where(u => u.ClienteId == id).ToList();
            return lista;
        }
    }
}

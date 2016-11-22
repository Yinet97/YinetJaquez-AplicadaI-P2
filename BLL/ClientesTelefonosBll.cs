using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class ClientesTelefonosBll
    {
        public static bool Guardar(ClientesTelefonos ct)
        {
            bool retorno = false;
            try
            {
                using (var db = new Parcial2Db())
                {
                    db.ClienteTelefono.Add(ct);
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

        public static List<ClientesTelefonos> GetLista()
        {
            var lista = new List<ClientesTelefonos>();
            var db = new Parcial2Db();

            lista = db.ClienteTelefono.ToList();
            return lista;
        }
    }
}

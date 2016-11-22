using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposTelefonos
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public List<Clientes> Clientes { get; set; }

        public TiposTelefonos()
        {
            this.Clientes = new List<Clientes>();
        }

        public TiposTelefonos(int TipoId, string Descripcion)
        {
            this.TipoId = TipoId;
            this.Descripcion = Descripcion;
            this.Clientes = new List<Clientes>();
        }

    }
}

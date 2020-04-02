using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Mercancia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }

        public string Cantidad { get; set; }

        public string Proveedor { get; set; }

        public DateTime Fecha { get; set; }
    }
}
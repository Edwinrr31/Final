using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Carritoitem
    {
        public class CarritoItem
        {
            private Facturacion _facturacion;

            public Facturacion Producto
            {
                get { return _facturacion; }
                set { _facturacion = value; }
            }
            private int _cantidad;

            public int Cantidad
            {
                get { return _cantidad; }
                set { _cantidad = value; }
            }

            public CarritoItem()
            {

            }

            public CarritoItem(Facturacion Facturacion, int cantidad)
            {
                this._facturacion = Facturacion;
                this._cantidad = cantidad;
            }
        }
    }
}
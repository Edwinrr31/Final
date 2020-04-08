using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;
using Rotativa;
namespace Final.Controllers
{
    public class ConsultaController : Controller
    {
         FinalEntities4 db = new FinalEntities4();


        // GET: Consulta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Imprimir()
        {
            var print = new ActionAsPdf("Index");
            return print;
        }

        public ActionResult ImprimirProveedores()
        {
            var print = new ActionAsPdf("Proveedores");
            return print;
        }

        public ActionResult ImprimirProducto()
        {
            var print = new ActionAsPdf("Producto");
            return print;
        }

        public ActionResult ImprimirFacturaciones()
        {
            var print = new ActionAsPdf("Facturaciones");
            return print;
        }

        public ActionResult ImprimirEntrada()
        {
            var print = new ActionAsPdf("Entrada");
            return print;
        }

        public ActionResult ImprimirCliente()
        {
            var print = new ActionAsPdf("Cliente");
            return print;
        }
        public ActionResult Filtro()
        {
            return View();
        }

        public ActionResult Producto(String searching)
        {
            var Final = from s in db.Stock
                        select s;

            if (!String.IsNullOrEmpty(searching))
            {
                Final = Final.Where(s => s.Nombre.Contains(searching));
            }
            return View(Final.ToList());
        }

        public ActionResult Cliente(String searching)
        {
            var Final = from s in db.Clientes
                        select s;

            if (!String.IsNullOrEmpty(searching))
            {
                Final = Final.Where(s => s.Nombre.Contains(searching));
                Final = Final.Where(s => s.Categoria.Contains(searching));
            }

            return View(Final.ToList());
        }

        public ActionResult Proveedores(String searching)
        {
            var Final = from s in db.Facturacion
                        select s;

            if (!String.IsNullOrEmpty(searching))
            {
                Final = Final.Where(s => s.Nombre.Contains(searching));
                Final = Final.Where(s => s.Email.Contains(searching));
            }
            return View(Final.ToList());
        }

        public ActionResult Entrada(String searching)
        {
            var Final = from s in db.Stock
                        select s;

            if (!String.IsNullOrEmpty(searching))
            {
                Final = Final.Where(s => s.Nombre.Contains(searching));
                
                Final = Final.Where(s => s.Proveedor.Contains(searching));

                Final = Final.Where(x => !Final.Select(h => h.Fecha).Contains(x.Fecha));
            }
            return View(Final.ToList());
        }

        public ActionResult Facturaciones(String searching)
        {
            var Final = from s in db.Stock
                        select s;

            if (!String.IsNullOrEmpty(searching))
            {
                Final = Final.Where(s => s.Nombre.Contains(searching));
                Final = Final.Where(x => !Final.Select(h => h.Fecha).Contains(x.Fecha));

            }

            return View(Final.ToList());
        }
        public ActionResult Consulta(String searching)
        {
            var Final = from s in db.Producto
                        select s;

            if (!String.IsNullOrEmpty(searching))
            {
                Final = Final.Where(s => s.Nombre.Contains(searching));
            }
            return View(Final.ToList());
        }
    }
}
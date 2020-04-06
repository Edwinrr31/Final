using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class ConsultaController : Controller
    {
         FinalEntities3 db = new FinalEntities3();


        // GET: Consulta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Filtro()
        {
            return View();
        }

        public ActionResult Producto(String Product)
        {
            var Final = from s in db.Stock
                        select s;

            if (!String.IsNullOrEmpty(Product))
            {
                Final = Final.Where(s => s.Nombre.Contains(Product));
            }
            return View(Final.ToList());
        }

        public ActionResult Cliente(String Client)
        {
            var Final = from s in db.Clientes
                        select s;

            if (!String.IsNullOrEmpty(Client))
            {
                Final = Final.Where(s => s.Nombre.Contains(Client));
                Final = Final.Where(s => s.Categoria.Contains(Client));
            }
            return View(Final.ToList());
        }

        public ActionResult Proveedores(String Proveedor)
        {
            var Final = from s in db.Facturacion
                        select s;

            if (!String.IsNullOrEmpty(Proveedor))
            {
                Final = Final.Where(s => s.Nombre.Contains(Proveedor));
                Final = Final.Where(s => s.Email.Contains(Proveedor));
            }
            return View(Final.ToList());
        }

        public ActionResult Entrada(String Entradas)
        {
            var Final = from s in db.Stock
                        select s;

            if (!String.IsNullOrEmpty(Entradas))
            {
                Final = Final.Where(s => s.Nombre.Contains(Entradas));
                
                Final = Final.Where(s => s.Proveedor.Contains(Entradas));
            }
            return View(Final.ToList());
        }

        public ActionResult Facturaciones(String Billing)
        {
            var Final = from s in db.Stock
                        select s;

            if (!String.IsNullOrEmpty(Billing))
            {
                Final = Final.Where(s => s.Nombre.Contains(Billing));
                
            }
            return View(Final.ToList());
        }
        public ActionResult Consulta(String searching)
        {
            var Final = from s in db.Stock
                        select s;

            if (!String.IsNullOrEmpty(searching))
            {
                Final = Final.Where(s => s.Nombre.Contains(searching));
            }
            return View(Final.ToList());
        }
    }
}
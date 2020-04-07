using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class ProductoController : Controller
    {
      
        //
        // GET: /Producto/

        private FinalEntities3 ce = new FinalEntities3();

        public ActionResult Index()
        {

            return View(ce.Facturacion.ToList().OrderBy(x => x.Nombre));
        }

        }
    }


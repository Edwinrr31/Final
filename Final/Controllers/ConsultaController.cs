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
        private FinalEntities3 db = new FinalEntities3();
        // GET: Consulta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Filtro()
        {
            return View();
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
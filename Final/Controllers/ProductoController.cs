﻿using System;
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

        private FinalEntities4 ce = new FinalEntities4();

        public ActionResult Index()
        {

            return View((ce.Producto.ToList().OrderBy(s => s.Nombre)));
        }

        }
    }


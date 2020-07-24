﻿using POOII_CL3.Entidades;
using POOII_CL3.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOII_CL3_Rodríguez_León_Mitchell.Controllers
{
    public class VehiculoController : Controller
    {
        ManagerVehiculo mgrVehiculo = new ManagerVehiculo();
        ManagerMarca mgrMarca = new ManagerMarca();

        // GET: Vehiculo
        public ActionResult Index()
        {
            return View(mgrVehiculo.Listar());
        }

        public ActionResult RegistrarVehiculo()
        {
            ViewBag.marcas = mgrMarca.Listar();
            return View(new Vehiculo());
        }

        [HttpPost]
        public ActionResult RegistrarVehiculo(Vehiculo objeto)
        {
            if(!ModelState.IsValid)
            {
                return View(objeto);
            }else
            {
                mgrVehiculo.Insertar(objeto);
                return RedirectToAction("Index");
            }
        }
    }
}
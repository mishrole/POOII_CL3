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

        // GET: Vehiculo
        public ActionResult Index()
        {
            return View(mgrVehiculo.Listar());
        }
    }
}
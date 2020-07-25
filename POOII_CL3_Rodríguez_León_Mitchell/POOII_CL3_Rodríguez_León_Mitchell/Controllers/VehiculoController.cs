using POOII_CL3.Entidades;
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

        public ActionResult ActualizarVehiculo(int id)
        {
            Vehiculo objeto = mgrVehiculo.Obtener(id);
            ViewBag.marcas = mgrMarca.Listar();
            return View(objeto);
        }

        [HttpPost]
        public ActionResult ActualizarVehiculo(Vehiculo objeto)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.marcas = mgrMarca.Listar();
                return View(objeto);
            }else
            {
                mgrVehiculo.Actualizar(objeto);
                return RedirectToAction("Index");
            }
        }

        public ActionResult VerVehiculo(int id)
        {
            return View(mgrVehiculo.Obtener(id));
        }

        public ActionResult EliminarVehiculo(int id)
        {
            Vehiculo objeto = mgrVehiculo.Obtener(id);
            return View(objeto);
        }

        [HttpPost]
        public ActionResult EliminarVehiculo(Vehiculo objeto)
        {
            mgrVehiculo.Eliminar(objeto.IdVehiculo);
            return RedirectToAction("Index");
        }

        public ActionResult ListarVehiculoXMarca(int id = 0)
        {
            ViewBag.marca = mgrMarca.Listar();
            List<Vehiculo> lista = new List<Vehiculo>();
            lista = mgrVehiculo.ListarVehiculoXMarca(id);

            return View(lista);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using POOII_CL3_Rodríguez_León_Mitchell.DataSets;
using POOII_CL3_Rodríguez_León_Mitchell.Models;

namespace POOII_CL3_Rodríguez_León_Mitchell.Controllers
{
    public class ReportesController : Controller
    {
        // GET: Reportes
        public ActionResult ReporteVehiculos()
        {
            ReportViewer rv = new ReportViewer();
            rv.ProcessingMode = ProcessingMode.Local;
            rv.SizeToReportContent = true;

            rv.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\RptVehiculos.rdlc";
            BD_CL3Entities bd = new BD_CL3Entities();

            rv.LocalReport.DataSources.Add(new ReportDataSource("DataSetVehiculos", bd.Vehiculo));

            rv.LocalReport.EnableHyperlinks = true;

            ViewBag.visor = rv;

            return View();
        }
    }
}
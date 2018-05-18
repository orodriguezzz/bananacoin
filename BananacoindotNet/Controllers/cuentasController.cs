using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BananacoindotNet.Controllers
{
    public class cuentasController : Controller
    {
        // GET: cuentas
        public ActionResult Index(string direccion)
        {
            var model = BananacoindotNet.BL.data.data.getCreateCuenta(direccion);
            model.transacciones = BananacoindotNet.BL.data.data.getTransacciones(direccion);

            return View(model);
        }
    }
}
using BananacoindotNet.BL.model;
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
            //if (BananacoindotNet.BL.business.business.validaSHA256(direccion))
            //{
                //1: busco y/o creo cuenta
                var model = BananacoindotNet.BL.data.data.getCreateCuenta(direccion);
                //2: busco transacciones
                model.transacciones = BananacoindotNet.BL.data.data.getTransacciones(direccion);
                //3: obtengo tipo transacciones
                model.tipoTransacciones = BananacoindotNet.BL.data.data.getTipoTransaccion();
            //}

            return View(new BC_CuentaSaldoViewModel());
        }
    }
}
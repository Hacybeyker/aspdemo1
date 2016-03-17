using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CargoController : Controller
    {
        // GET: Cargo
        bd_escuelaEntities entidad = new bd_escuelaEntities();
        public ActionResult Index()
        {
            var listacargos = entidad.cargo;
            return View(listacargos.ToList());
        }

        public ActionResult ListaMuestraCargo()
        {
            var listacargos = entidad.cargo;
            return View(listacargos.ToList());
        }

        public ActionResult UsuarioPorCargo(string cargo)
        {
            var modelo = from p in entidad.usuario where p.cargo.descripcioncargo == cargo select p;
            return View(modelo.ToList());
        }

        public ActionResult ListadoUsuarioDescirpcionCargo()
        {
            var modelo = from p in entidad.usuario join c in entidad.cargo on p.codigocargo equals c.codigocargo
                         select new ElUsuario
                         {
                             codigo = p.codigocargo,
                             nombre = p.nombreusuario,
                             cargo = c.descripcioncargo
                         };
            return View(modelo.ToList());
        }
    }
}
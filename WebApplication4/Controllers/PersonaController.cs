using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> personas = new List<Persona>();
            Persona persona1 = new Persona();
            persona1.codigo = 1;
            persona1.nombre = "Carlos";
            persona1.apellidopaterno = "Osorio";
            persona1.apellidomaterno = "Pérez";
            personas.Add(persona1);
            return View(personas);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IState;

// HomeController.cs


using System.Web.Mvc;

namespace IState.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Crear un nuevo contexto con el estado A
            var context = new Context(new ConcreteStateA());

            // Configurar el valor del Label en la vista
            ViewBag.EstadoActual = context.CurrentState.GetType().Name;

            // Realizar una serie de solicitudes para cambiar entre los estados A y B
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            return View("Index");
        }
    }
}



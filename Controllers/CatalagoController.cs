using Microsoft.AspNetCore.Mvc;

namespace netTest.Controllers
{
    public class CatalagoController : Controller 
    {
        public CatalagoController() //Controlador
        {

        }

        public IActionResult Index()//muestra el retorno en la interface de usuario
        {
            return View();
        }
    }
}
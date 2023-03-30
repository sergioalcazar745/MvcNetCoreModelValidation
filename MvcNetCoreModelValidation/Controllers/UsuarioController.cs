using Microsoft.AspNetCore.Mvc;
using MvcNetCoreModelValidation.Models;

namespace MvcNetCoreModelValidation.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Error"] = "Datos incorrectos";
                return View();
            }

            return View();
        }
    }
}

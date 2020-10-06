using Microsoft.AspNetCore.Mvc;
using RoleTop_Mvc.ViewModel;

namespace RoleTop_Mvc.Controllers
{
    public class EventosController:AbstractController
    {
        [HttpGet]
        public IActionResult Eventos()
        {
            return View(new BaseViewModel(){
                NomeView = "Eventos",
                UsuarioEmail = ObterUsuarioSession()
            });
        }
    }
}
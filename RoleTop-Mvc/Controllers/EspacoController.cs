using Microsoft.AspNetCore.Mvc;
using RoleTop_Mvc.ViewModel;
namespace RoleTop_Mvc.Controllers
{
    public class EspacoController:AbstractController
    {
        [HttpGet]
        public IActionResult Espaco()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Espaco",
                UsuarioEmail = ObterUsuarioSession()
                
            });
        }
        
    }
}
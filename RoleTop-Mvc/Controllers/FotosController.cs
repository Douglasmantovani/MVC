using System.Net;
using Microsoft.AspNetCore.Mvc;
using RoleTop_Mvc.ViewModel;

namespace RoleTop_Mvc.Controllers
{
    public class FotosController:AbstractController
    {
        [HttpGet]
        public IActionResult Fotos()
        {
            return View(new BaseViewModel()
            {
                NomeView="Fotos",
                UsuarioEmail = ObterUsuarioSession()
            });
        }
    }
}
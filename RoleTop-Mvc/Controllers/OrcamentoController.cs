using Microsoft.AspNetCore.Mvc;
using RoleTop_Mvc.ViewModel;

namespace RoleTop_Mvc.Controllers
{
    public class OrcamentoController:AbstractController
    {
        public IActionResult Orcamento(){
            return View(new BaseViewModel(){
                
                NomeView = "Orcamento",
                UsuarioEmail = ObterUsuarioSession()
            });
            
        }
    }
}
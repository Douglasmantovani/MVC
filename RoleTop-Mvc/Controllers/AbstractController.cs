using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTop_Mvc.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "cliente_email";
        protected const string SESSION_CLIENTE_TIPO = "cliente_tipo";
        

        protected string ObterUsuarioSession()
        {
            var email = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if (!string.IsNullOrEmpty(email))
            {
                return email;
            } 
            else
            {
                return "";
            }
        }
        protected string ObterUsuarioTipoSession()
        {
            var tipoUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_TIPO);
            if (!string.IsNullOrEmpty(tipoUsuario))
            {
                return tipoUsuario;
            } 
            else
            {
                return "";
            }
        }

        protected string ObterUsuarioStatusSession()
        {
            var StatusUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_TIPO);
            if (!string.IsNullOrEmpty(StatusUsuario))
            {
                return StatusUsuario;
            } 
            else
            {
                return "";
            }
        }
        
    }
}
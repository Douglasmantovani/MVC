using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_Mvc.Enum;
using RoleTop_Mvc.Models;
using RoleTop_Mvc.Repositories;
using RoleTop_Mvc.ViewModel;

namespace RoleTop_Mvc.Controllers
{
    
    public class ClienteController:AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        AdminRepository adminRepository = new AdminRepository();
        Cliente cliente = new Cliente();
        [HttpGet]
        public IActionResult Login()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession()
            });
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            try
            {
                var usuario = form["email"];
                var senha = form["senha"];
                var cliente = clienteRepository.ObterPor(usuario);
                if(cliente == null)
                {
                    var Administrador = adminRepository.ObterPor(usuario);
                     cliente=Administrador;
                }
                
                if(cliente != null)
                {
                    if(cliente.statusUsuario==1)
                            {
                                return View("Erro", new RespostaViewModel("Usuario Banido"));

                            }
                    if(cliente.Senha.Equals(senha)){
                    switch(cliente.TipoUsuario){
                            case (uint) TipoUser.CLIENTE:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                                
                                return RedirectToAction("Index","Home");
                            
                            default:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                                
                                return RedirectToAction("Dashboard","Administrador");
                        }
                    }else 
                        {
                            
                            return View("Erro", new RespostaViewModel("Senha incorreta"));
                        }
                    
                }else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }
            } catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel());
            }
        }
        public IActionResult Historico ()
        {
            var emailCliente = ObterUsuarioSession();
            var AgendamentoPorCliente =agendamentoRepository.ObterTodosPorCliente(emailCliente);
            return View(new HistoricoViewModel()
            {
                Agendamento = AgendamentoPorCliente,
                NomeView = "Histórico",
                UsuarioEmail = ObterUsuarioSession()
            });
        }
        
        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}
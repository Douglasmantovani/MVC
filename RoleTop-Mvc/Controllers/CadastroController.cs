using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_Mvc.Enum;
using RoleTop_Mvc.Models;
using RoleTop_Mvc.Repositories;
using RoleTop_Mvc.ViewModel;

namespace RoleTop_Mvc.Controllers
{
    public class CadastroController:AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        
        public IActionResult CriarCadastro(RespostaViewModel respostaViewModel)
        {
            return View(new BaseViewModel(){
            NomeView = "CriarCadastro" ,
            UsuarioEmail = ObterUsuarioSession()
            });
        }
        public IActionResult CadastrarCliente(IFormCollection form)
        {
            try
            {
                string email;
                email =form ["email"];
                Cliente cliente = new Cliente(
                form["nome"],form["cpf"],form["telefone"],form["email"],form["senha"]);
                if(clienteRepository.ObterPorEmails(email)){
                    return View("Erro", new RespostaViewModel($"Usuário {email} Já Existe"){
                    });
                }else{
                cliente.TipoUsuario = (uint) TipoUser.CLIENTE;
                cliente.statusUsuario = (uint)StatusUsuario.Bom;
                clienteRepository.Inserir(cliente);
                return View("Sucesso", new RespostaViewModel(){
                    NomeView ="CriarCadastro" 
                });
                }
                    
                } catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "CriarCadastro"
                });
            }
        }
    }
}
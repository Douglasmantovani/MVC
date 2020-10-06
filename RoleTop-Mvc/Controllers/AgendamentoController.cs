using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_Mvc.Enum;
using RoleTop_Mvc.Models;
using RoleTop_Mvc.Repositories;
using RoleTop_Mvc.ViewModel;

namespace RoleTop_Mvc.Controllers {
    public class AgendamentoController : AbstractController {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository ();
        AdminRepository adminRepository = new AdminRepository();
        
        
        ClienteRepository clienteRepository = new ClienteRepository ();
        [HttpGet]
        public IActionResult Agendamento () {
            var UsuarioLogado = ObterUsuarioSession ();
            AgendamentoViewModel avm = new AgendamentoViewModel ();

            if (!string.IsNullOrEmpty (UsuarioLogado)) {
                var clienteLogado = clienteRepository.ObterPor (UsuarioLogado);

               if(clienteLogado== null)
                {
                    var Administrador = adminRepository.ObterPor(UsuarioLogado);
                     clienteLogado=Administrador;
                }
                avm.UsuarioEmail = UsuarioLogado;
                avm.cliente = clienteLogado;
            }
            return View(avm);
        }
        public IActionResult Registrar (IFormCollection form) {
            Agendamento a = new Agendamento ();
            a.Endereco = form["endereco"];
            a.Parcelamento = form["parcelamento"];
            a.DatadoPedido=DateTime.Now;
            a.NomeEvento = form["Eventos"];
            a.Npessoas = form["Npessoas"];
            a.TipodoEvento = form["tipoevento"];
            a.Adicionais = form ["adicionais"];
            a.DataEvento = DateTime.Parse (form["dataevento"]);
            Cliente c = new Cliente () {
                Nome = form["nome"],
                CPF = form["CPF"],
                Telefone = form["telefone"],
                Email = form["email"],
            };
            
            a.cliente = c;

            Cartao cartao = new Cartao () {
                NomeTitular = form["nomeCartao"],
                NumeroCartao = form["Ncartao"],
                Validade = DateTime.Parse (form["validade"]),
                CVV = form["cvv"]
            };
            c.cartao = cartao;

            var cliente = clienteRepository.ObterPor(c.Email);
            var Administrador = adminRepository.ObterPor(c.Email);

            if(Administrador==null)
            {
                if(cliente.statusUsuario==1)
                {
                  return View("Erro", new RespostaViewModel("Usuario Banido"));
                }
            }
            if (agendamentoRepository.Inserir (a)) {
                return View ("Sucesso", new RespostaViewModel () {
                    NomeView = "Agendamento",
                    UsuarioEmail = ObterUsuarioSession()
                });
            } else {
                return View ("Erro", new RespostaViewModel () {
                    NomeView = "Agendamento",
                        UsuarioEmail = ObterUsuarioSession ()
                });
            }
        }
        public IActionResult Aprovar(ulong id)
        {
            var Agendamento = agendamentoRepository.ObterPor(id);
            Agendamento.Status = (uint) StatusAgendamento.APROVADO;
            if(agendamentoRepository.Atualizar(Agendamento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este pedido")
                
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                });
            }
        }
        public IActionResult Reprovar(ulong id)
        {
            var agendamento = agendamentoRepository.ObterPor(id);
            agendamento.Status = (uint) StatusAgendamento.REPROVADO;

            if(agendamentoRepository.Atualizar(agendamento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                });
            }
        }
        public IActionResult Banir(uint Status)
        {
             var Cliente = clienteRepository.ObterPorStatus(Status);
            Cliente.statusUsuario = (uint) StatusUsuario.Ruim;

            if(clienteRepository.AtualizarStatus(Cliente))
            {

                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível Banir esse Usuario")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                });
            }
        }
    }
}
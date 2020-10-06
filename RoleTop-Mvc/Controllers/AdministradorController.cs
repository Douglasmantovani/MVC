using System.Data;
using Microsoft.AspNetCore.Mvc;
using RoleTop_Mvc.Enum;
using RoleTop_Mvc.Repositories;
using RoleTop_Mvc.ViewModel;


namespace RoleTop_Mvc.Controllers
{
    public class AdministradorController :AbstractController
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository ();
        ClienteRepository clienteRepository = new ClienteRepository();

        DashboardViewModel dvm = new DashboardViewModel();
        public IActionResult Dashboard()
        {
            
            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());
            
            if (!ninguemLogado && (uint) TipoUser.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {
                var agendamentos = agendamentoRepository.ObterTodos ();
                
                foreach (var agendamento in agendamentos) {
                    switch (agendamento.Status) {
                        case (uint) StatusAgendamento.APROVADO:
                            dvm.AgendamentoAprovados++;
                            break;
                        case (uint) StatusAgendamento.REPROVADO:
                            dvm.AgendamentoReprovados++;
                            break;
                        default:
                            dvm.AgendamentoPendentes++;
                            dvm.Agendamento.Add (agendamento);
                            break;
                    }
                }
            }
                    
             if (!ninguemLogado && (uint) TipoUser.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession())){

           
                var usuarios = clienteRepository.ObterTodos ();
                    
                     foreach (var Usuario in usuarios){
                    switch (Usuario.statusUsuario){
                        
                        case (uint) StatusUsuario.Ruim:
                            dvm.BanirUsuario++;
                            break;
                        default:
                            dvm.Manter++;
                            break;
                    }
                }
                dvm.Todos= agendamentoRepository.ObterTodos();
                dvm.NomeView = "Dashboard";
                dvm.UsuarioEmail = ObterUsuarioSession ();
                dvm.TodosClientes = clienteRepository.ObterTodos();
                return View (dvm);
             
            }else {
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o Dashboard"
                });
            }
        }
    
    }
}


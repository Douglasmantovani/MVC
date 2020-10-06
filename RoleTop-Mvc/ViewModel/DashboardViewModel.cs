using System.Collections.Generic;
using RoleTop_Mvc.Models;

namespace RoleTop_Mvc.ViewModel
{
    public class DashboardViewModel:BaseViewModel
    {
        public uint BanirUsuario {get;set;}
        public uint Manter {get;set;} 
        public List<Agendamento> Agendamento {get;set;}
        public List<Agendamento> Todos {get;set;}
        public List<Cliente> TodosClientes{get;set;}
        public uint AgendamentoAprovados {get;set;}
        public uint AgendamentoReprovados {get;set;}
        public uint AgendamentoPendentes {get;set;}

        

        public DashboardViewModel()
        {
            this.Agendamento = new List<Agendamento>();

            this.TodosClientes = new List<Cliente>();
        }

    }
}
    
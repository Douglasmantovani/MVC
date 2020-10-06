using RoleTop_Mvc.Models;

namespace RoleTop_Mvc.ViewModel
{
    public class AgendamentoViewModel:BaseViewModel
    {
        public Cliente cliente{get;set;}

        public AgendamentoViewModel(){
            this.cliente = new Cliente();
        }
    }
}
using System;
namespace RoleTop_Mvc.Models
{
    public class Cartao
    {
        public string NomeTitular{get;set;}
        public string NumeroCartao{get;set;}
        public DateTime Validade{get;set;}
        public string CVV{get;set;}
        public Cartao()
        {
            
        }
        public Cartao(string nometitular,string numerocartao,DateTime validade,string cvv)
        {
            this.NomeTitular = nometitular;
            this.NumeroCartao = numerocartao;
            this.Validade = validade;
            this.CVV=cvv;
        }
    }
}
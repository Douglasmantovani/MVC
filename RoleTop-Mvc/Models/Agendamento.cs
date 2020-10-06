using System;
using RoleTop_Mvc.Enum;
namespace RoleTop_Mvc.Models
{
    public class Agendamento
    {
        public ulong Id{get;set;}
        public DateTime DatadoPedido{get;set;}
        public Cliente cliente{get;set;}
        public string NomeEvento{get;set;}
        public string Npessoas{get;set;} 
        public DateTime DataEvento {get;set;}
        public string Endereco {get;set;}
        public string Parcelamento{get;set;}
        public string Adicionais {get;set;}
        public string TipodoEvento{get;set;}
        public uint Status{get;set;}
        
        
        public Agendamento()
        {
            this.cliente = new Cliente();
        }
        
        public Agendamento(DateTime datadopedido,string nomeevento,string npessoas,DateTime dataevento,string endereco,string parcelamento,string adicionais,string tipodoevento)
        {
            this.cliente = new Cliente();
            this.Adicionais =adicionais;
            this.TipodoEvento = tipodoevento;
            this.Parcelamento=parcelamento;
            this.Endereco=endereco;
            this.DatadoPedido=datadopedido;
            this.NomeEvento=nomeevento;
            this.Npessoas=npessoas;
            this.DataEvento=dataevento;
            this.Id = 0;
            this.Status=(uint) StatusAgendamento.PENDENTE;
        }
    }
}
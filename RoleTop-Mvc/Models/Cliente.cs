using System;
using RoleTop_Mvc.Enum;
namespace RoleTop_Mvc.Models {
    public class Cliente {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Cartao cartao { get; set; }
        public uint TipoUsuario { get; set; }
        public uint statusUsuario{get;set;}
        public Cliente () {
            this.cartao = new Cartao ();
        }
        public Cliente (string nome, string cpf, string telefone, string email, string senha) {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
            this.cartao = new Cartao ();
            this.statusUsuario=(uint)StatusUsuario.Bom;
        }
    }
}
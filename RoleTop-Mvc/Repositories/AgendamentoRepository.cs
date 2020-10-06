using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using RoleTop_Mvc.Models;

namespace RoleTop_Mvc.Repositories {
    public class AgendamentoRepository : RepositoryBase {

        ClienteRepository clienteRepository = new ClienteRepository ();

        private const string PATH = "Database/Agendamento.csv";

        public AgendamentoRepository () {
            if (!File.Exists (PATH)){
                File.Create (PATH).Close ();
            }
        }
        public string PreparaRegistroCSV (Agendamento a) {

            return $"id={a.Id};status_agendamento={a.Status};datadopedido={a.DatadoPedido};nome_cliente={a.cliente.Nome};cpf_cliente={a.cliente.CPF};telefone_cliente={a.cliente.Telefone};email_cliente={a.cliente.Email};agendamento_nome={a.NomeEvento};adicionais={a.Adicionais};data_evento={a.DataEvento};n_pessoas={a.Npessoas};tipodoevento={a.TipodoEvento};nome_titular={a.cliente.cartao.NomeTitular};numero_cartao={a.cliente.cartao.NumeroCartao};cartao_datavalidade={a.cliente.cartao.Validade};cartao_cvv={a.cliente.cartao.CVV};parcelamento={a.Parcelamento};cliente_endereco={a.Endereco}";
        }
        public bool Inserir (Agendamento a) {
            var quantidadePedidos = File.ReadAllLines (PATH).Length;
            a.Id = (ulong) ++quantidadePedidos;
            var linha = new string[] { PreparaRegistroCSV (a) };
            File.AppendAllLines (PATH, linha);
            return true;
        }
        public List<Agendamento> ObterTodosPorCliente(string emailCliente)
        {
            var agendamentos = ObterTodos();
            List<Agendamento> agendamentoPorCliente = new List<Agendamento>();
            foreach (var Agendamento in agendamentos)
            {
                if(Agendamento.cliente.Email.Equals(emailCliente))
                {
                    agendamentoPorCliente.Add(Agendamento);
                }
            }
            return agendamentoPorCliente;
        }

        public List<Agendamento> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            List<Agendamento> agendamento = new List<Agendamento>();
            foreach (var linha in linhas){
                Agendamento a = new Agendamento();
                a.Id =ulong.Parse(ExtrairValorDoCampo("id",linha));
                a.Status=uint.Parse(ExtrairValorDoCampo("status_agendamento",linha));
                a.DatadoPedido=DateTime.Parse(ExtrairValorDoCampo("datadopedido",linha));
                a.Endereco = ExtrairValorDoCampo("cliente_endereco",linha);
                a.cliente.Nome = ExtrairValorDoCampo("nome_cliente", linha);
                a.cliente.CPF = ExtrairValorDoCampo("cpf_cliente", linha);
                a.cliente.Telefone = ExtrairValorDoCampo("telefone_cliente", linha);
                a.cliente.Email = ExtrairValorDoCampo("email_cliente", linha);
                a.NomeEvento = ExtrairValorDoCampo("agendamento_nome", linha);
                a.Adicionais= ExtrairValorDoCampo("adicionais",linha);
                a.DataEvento = DateTime.Parse(ExtrairValorDoCampo ("data_evento", linha));
                a.Npessoas = ExtrairValorDoCampo("n_pessoas", linha);
                a.TipodoEvento = ExtrairValorDoCampo("tipodoevento",linha);
                a.cliente.cartao.NomeTitular = ExtrairValorDoCampo("nome_titular", linha);
                a.cliente.cartao.NumeroCartao = ExtrairValorDoCampo("numero_cartao", linha);
                a.cliente.cartao.Validade = DateTime.Parse(ExtrairValorDoCampo ("cartao_datavalidade", linha));
                a.cliente.cartao.CVV = ExtrairValorDoCampo("cartao_cvv", linha);
                a.Parcelamento = ExtrairValorDoCampo("parcelamento",linha);
                agendamento.Add (a);
            }
            return agendamento;
        }
        public Agendamento ObterPor(ulong id)
        {
            var AgendamentosTotais = ObterTodos();
            foreach (var Agendamento in AgendamentosTotais)
            {
                if(id.Equals(Agendamento.Id))
                {
                    return Agendamento;
                }
            }
            return null;
        }
        public bool Atualizar (Agendamento a) {
            var pedidosTotais = File.ReadAllLines (PATH);
            var pedidoCSV = PreparaRegistroCSV (a);
            var linhaPedido = -1;
            var resultado = false;
            for (int i = 0; i < pedidosTotais.Length; i++) {
                var idConvertido = ulong.Parse (ExtrairValorDoCampo ("id", pedidosTotais[i])); 
                if (a.Id.Equals(idConvertido)) {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }
            if (resultado) {
                pedidosTotais[linhaPedido] = pedidoCSV;
                File.WriteAllLines (PATH, pedidosTotais);
            }
            return resultado;
        }
        
    }
}
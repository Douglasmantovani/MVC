using System.Collections.Generic;
using System.IO;
using RoleTop_Mvc.Models;

namespace RoleTop_Mvc.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH="Database/Cliente.csv"; //endereço onde cria o arquivo

        public ClienteRepository()      //metodo para criar o banco de dados
        {
            if(!File.Exists(PATH))        //cria um novo arquivo se nao existir
            {
                File.Create(PATH).Close(); //se ja criou ele sai
            }
        }
        private string PrepararRegistroCSV(Cliente cliente)
        {
            
            return $"tipo_usuario={cliente.TipoUsuario};status_usuario={cliente.statusUsuario};nome={cliente.Nome};cpf={cliente.CPF};telefone={cliente.Telefone};email={cliente.Email};senha={cliente.Senha}";
             //no csv as informaçoes do cliente estarao assim
        }
        public bool ObterPorEmails(string email)
        { 
            var linhas = File.ReadAllLines(PATH);
            var cliente = new Cliente();
            foreach (var linha in linhas)
            {
                if(string.IsNullOrEmpty(linha))
                {
                    continue;
                }
                var Email = ExtrairValorDoCampo ("email",linha);
                
                if(email.Equals(Email))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[]{PrepararRegistroCSV(cliente)}; //insere as informaçoes do cliente no csv
            File.AppendAllLines(PATH ,linha);
            return true;
        }

        public Cliente ObterPor(string email) //
        {  //le as informaçoes do campo
            var linhas=File.ReadAllLines(PATH);
            foreach(var item in linhas)
            {
                if(ExtrairValorDoCampo("email",item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.TipoUsuario=uint.Parse(ExtrairValorDoCampo("tipo_usuario",item));
                    c.statusUsuario=uint.Parse(ExtrairValorDoCampo("status_usuario",item)); 
                    c.Nome= ExtrairValorDoCampo("nome",item);   
                    c.CPF=ExtrairValorDoCampo("cpf",item);
                    c.Telefone=ExtrairValorDoCampo("telefone",item);
                    c.Email=ExtrairValorDoCampo("email",item);
                    c.Senha=ExtrairValorDoCampo("senha",item);
                    return c;
                }
            }
            return null;
        }

        public List<Cliente> ObterTodos() {
            var linhas = File.ReadAllLines (PATH);
            List<Cliente> Cliente = new List<Cliente>();
            foreach (var linha in linhas){
                Cliente c = new Cliente();
                c.TipoUsuario= uint.Parse(ExtrairValorDoCampo("tipo_usuario",linha));
                c.statusUsuario=uint.Parse(ExtrairValorDoCampo("status_usuario",linha));
                c.Nome=ExtrairValorDoCampo("nome",linha);
                c.CPF=ExtrairValorDoCampo("cpf",linha);
                c.Telefone=ExtrairValorDoCampo("telefone",linha);
                c.Email=ExtrairValorDoCampo("email",linha);
                c.Senha=ExtrairValorDoCampo("senha",linha);
                Cliente.Add (c);
            }
            return Cliente;
        }

        public Cliente ObterPorStatus(uint status)
        {
            var ClientesTotais = ObterTodos();
            foreach (var Cliente in ClientesTotais)
            {
                if(status.Equals(Cliente.statusUsuario))
                {
                    return Cliente;
                }
            }
            return null;
        }
        public bool AtualizarStatus(Cliente c){
            var ClientesTotaisStatus = File.ReadAllLines (PATH);
            var ClienteCSV = PrepararRegistroCSV(c);
            var linhaCliente = -1;
            var resultado = false;
            for (int i = 0; i < ClientesTotaisStatus.Length; i++) {
                var StatusConvertido = uint.Parse (ExtrairValorDoCampo ("status_usuario", ClientesTotaisStatus[i])); //TODO NAO É ID , É CLIENTE_ID
                if (c.statusUsuario!=(StatusConvertido))
                { 
                    linhaCliente = i;
                    resultado = true;
                    break;       
                }
            }
            if (resultado) {
                ClientesTotaisStatus[linhaCliente] = ClienteCSV;
                File.WriteAllLines (PATH, ClientesTotaisStatus);
            }
             return resultado;
        }
        
    }
}
using System.IO;
using RoleTop_Mvc.Models;

namespace RoleTop_Mvc.Repositories
{
    public class AdminRepository:RepositoryBase
    {


        private const string PATH="Database/Admin.csv";

         public AdminRepository()      //metodo para criar o banco de dados
        {
            if(!File.Exists(PATH))        //cria um novo arquivo se nao existir
            {
                File.Create(PATH).Close(); //se ja criou ele sai
            }
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
    }
}
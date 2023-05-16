using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Ex003.Entities;

namespace Ex003.Repositories
{
    public class FuncionarioRepository
    {
        private string connectionString;

        public FuncionarioRepository()
        {
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDEx003;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public void Inserir(Funcionario funcionario)
        {
            var query = "insert into Funcionario (Nome, Cpf, DataAdmissao, TipoContratacao) "
                        + "values (@Nome, @Cpf, @DataAdmissao, @TipoContratacao)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, funcionario);
            }
        }

        public void Atualizar(Funcionario funcionario)
        {
            var query = "update Funcionario set Nome = @Nome, Cpf = @Cpf, DataAdmissao = @DataAdmissao," +
                "TipoContrataco = @TipoContratacao where Id = @Id ";

            using( var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, funcionario);
            }
        }

        public void Excluir(Funcionario funcionario)
        {
            var query = "delete from Funcionario where Id = @Id";

            using( var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, funcionario);
            }
        }

        public List<Funcionario> ConsultarTodos()
        {
            var query = "select * from funcionario";

            using ( var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Funcionario>(query).ToList();
            }
        }

        public Funcionario ObterPorId( int Id)
        {
            var query = "select from * Funcionario where Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Funcionario>(query, new { Id }).FirstOrDefault();
            }
           
        }
    }
}

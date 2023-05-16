using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex003.Entities;
using Ex003.Inputs;
using Ex003.Repositories;

namespace Ex003.Controllers
{
    public class FuncionarioController
    {
        private readonly FuncionarioRepository funcionarioRepository;

        public FuncionarioController()
        {
            funcionarioRepository = new FuncionarioRepository();
        }

        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n -=-=-< CADASTRO DE FUNCIONÁRIOS >-=-=- \n");

                var funcionario = new Funcionario();

                funcionario.Nome = FuncionarioInput.LerNome();
                funcionario.Cpf = FuncionarioInput.LerCpf();
                funcionario.DataAdmissao = FuncionarioInput.LerDataAdmissao();
                funcionario.TipoContratacao = (TipoContratacao) FuncionarioInput.LerTipoContratacao();

                funcionarioRepository.Inserir(funcionario);

                Console.WriteLine($"\nO FUNCIONÁRIO {funcionario.Nome} FOI CADASTRADO COM SUCESSO");

            }
            catch (Exception e)
            {
                Console.WriteLine("\nERRO: " + e.Message);
            }
        }

        public void AtualizarFuncionario()
        {
            try
            {
                Console.WriteLine("\n -=-=-< ATUALIZAR DE FUNCIONÁRIOS >-=-=- \n");

                var id = FuncionarioInput.LerId();
                
                var funcionario = funcionarioRepository.ObterPorId(id);

                if (funcionario != null) //null -> vazio ( sem instancia/valor )
                {
                    funcionario.Nome = FuncionarioInput.LerNome();
                    funcionario.Cpf = FuncionarioInput.LerCpf();
                    funcionario.DataAdmissao = FuncionarioInput.LerDataAdmissao();
                    funcionario.TipoContratacao = (TipoContratacao)FuncionarioInput.LerTipoContratacao();

                    funcionarioRepository.Atualizar(funcionario);

                    Console.WriteLine("FUNCIONÁRIO ATUALIZADO COM SUCESSO");

                }
                else
                {
                    Console.WriteLine("\nNENHUM FUNCIONÁRIO ENCONTRADO, TENTE OUTRO...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nERRO: " + e.Message);
            }
        }

        public void ExcluirFuncionario()
        {
            try
            {
                Console.WriteLine("\n -=-=-< EXCLUISÃO DE FUNCIONÁRIOS >-=-=- \n");

                var id = FuncionarioInput.LerId();

                var funcionario = funcionarioRepository.ObterPorId(id);

                if (funcionario != null) //null -> vazio ( sem instancia/valor )
                {
                    
                    funcionarioRepository.Excluir(funcionario);

                    Console.WriteLine("FUNCIONÁRIO EXCLUIDO COM SUCESSO");

                }
                else
                {
                    Console.WriteLine("\nNENHUM FUNCIONÁRIO ENCONTRADO, TENTE OUTRO...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nERRO: " + e.Message);
            }
        }

        public void ConsultarFuncionarios()
        {
            try
            {
                var lista = funcionarioRepository.ConsultarTodos();

                Console.WriteLine("QUANTIDADE DE FUNCIONARIOS CADASTRADOS: " + lista.Count);

                foreach (var item in lista)
                {
                    Console.WriteLine($"-----------< FUNCIONARIO {item.Id} >-----------");
                    Console.WriteLine("ID: " + item.Id);
                    Console.WriteLine("NOME: " + item.Nome);
                    Console.WriteLine("CPF: " + item.Cpf);
                    Console.WriteLine("DATA ADMISSAO: " + item.DataAdmissao.ToString("dd/MM/yyyy"));
                    Console.WriteLine("TIPO DE CONTRATACAO: " + item.TipoContratacao);
                    Console.WriteLine("---------------------------------------");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nERRO: " + e.Message);
            }
        }
    }
}

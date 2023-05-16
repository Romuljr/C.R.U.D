using Ex003.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n --------< CONTROLE DE FUNCIONÁRIO >-------- \n");
                Console.WriteLine("[ 1 ] - CADASTRAR FUNCIONÁRIO ");
                Console.WriteLine("[ 2 ] - ATUALIZAR FUNCIONÁRIO ");
                Console.WriteLine("[ 3 ] - EXCLUIR FUNCIONÁRIO ");
                Console.WriteLine("[ 4 ] - CONSULTAR FUNCIONÁRIOS ");
                Console.WriteLine(" -------------------------------------------");

                Console.WriteLine("DIGITE SUA OPÇÃO: ");
                var opcao = int.Parse(Console.ReadLine());

                var funcionarioController = new FuncionarioController();

                switch (opcao)
                {
                    case 1:
                        funcionarioController.CadastrarFuncionario();
                        break;

                    case 2:
                        funcionarioController.AtualizarFuncionario();
                        break;

                    case 3:
                        funcionarioController.ExcluirFuncionario();
                        break;

                    case 4:
                        funcionarioController.ConsultarFuncionarios();
                        break;

                    default:
                        Console.WriteLine("\nOPÇÃO INVÁLIDA");
                        break;
                }

                Console.WriteLine("DESEJA CONTINUAR [S/N]?");
                var confirmacao = Console.ReadLine();

                if(confirmacao.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Main(args);
                }
                else
                {
                    Console.WriteLine("\nENCERRANDO O PROGRAMA...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nERRO: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}

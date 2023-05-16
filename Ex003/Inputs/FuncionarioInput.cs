using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003.Inputs
{
    public class FuncionarioInput
    {   
        public static int LerId()
        {
            Console.WriteLine("DIGITE O ID DO FUNCIONARIO: ");
            return int.Parse(Console.ReadLine());
        }
        public static string LerNome()
        {
            Console.WriteLine("DIGITE O NOME DO FUNCIONARIO: ");
            return Console.ReadLine();
        }

        public static string LerCpf()
        {
            Console.WriteLine("DIGITE O CPF DO FUNCIONARIO: ");
            return Console.ReadLine();
        }

        public static DateTime LerDataAdmissao()
        {
            Console.WriteLine("DIGITE A DATA DE ADMISSAO DO FUNCIONARIO: ");
            return DateTime.Parse(Console.ReadLine());  
        }

        public static int LerTipoContratacao()
        {
            Console.WriteLine("[ 1 ] - CLT");
            Console.WriteLine("[ 2 ] - TERCEIRIZADO");
            Console.WriteLine("[ 3 ] - ESTÁGIO");

            Console.WriteLine("DIGITE O NÚMERO EQUIVALENTE AO SEU TIPO DE CONTRATAÇÃO: ");
            return int.Parse(Console.ReadLine());
        }
    }
}

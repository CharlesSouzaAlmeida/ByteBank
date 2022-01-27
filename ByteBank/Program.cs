using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


            Funcionario carlos = new Funcionario("547.879.157-20");
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            carlos.AumentarSalario();
            Console.WriteLine("Nova salário do Carlos: " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            Funcionario pedro = new Diretor();

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            roberta.AumentarSalario();
            Console.WriteLine("Novo Salário de Roberta " + roberta.Salario);

            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);


            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificao());

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
   public class Diretor : Funcionario
    {
       
        //Criando construtor 
        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }
      
        p

        public override double GetBonificacao()
        {

            return Salario + base.GetBonificacao();
        }
    }
}

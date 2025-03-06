using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPrimeiroRepositorio
{
    public class Pessoa
    {

        public string Nome;
        public int Idade;

        public void DizerOi() //n usar static, só criar se usar no Program.cs, uma static n necessita da isntancia do objeto pra trabalhar com ela? agr preciso passar atributos(?) do objeto pra usar nele, e so aq (?), n da pra usar em outras classes
        {
            Console.WriteLine($"{Nome} tem {Idade} anos."); //dentro da classe posso acessar diretamente aq
        }

    }
}

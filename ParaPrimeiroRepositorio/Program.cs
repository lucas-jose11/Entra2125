namespace ParaPrimeiroRepositorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa user = new Pessoa();
            user.Nome = "Tiago";
            user.Idade = 27;

            //Console.WriteLine($"{user.Nome} tem {user.Idade} anos."); // atributos, método é nada ais que uma função

            Funcionario estagiario = new Funcionario();
            estagiario.Nome = "Luis";
            estagiario.Cargo = "estagiario";
            estagiario.Salario = 2000;
            estagiario.Print();

            Funcionario gestor = new Funcionario(); // os dois sao funcionario, nada difere exceto os atributos
            gestor.Nome = "João";
            gestor.Cargo = "Gestor";
            gestor.Salario = 15000;
            gestor.Print();
        }
    }
}





//estudar git e github, push em note casa

//pra primeiro respoistório
        
//            int n = 0;
//while (n < 5)
//{
//    n++;
//}

//Console.WriteLine(n);
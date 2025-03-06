using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPrimeiroRepositorio
{
    public class Funcionario
    {
        public string Nome;
        public string Cargo;
        public double Salario;

        public void Print() // agr pode chamar qm for funcioanrio e vai, estagiario.print, gestor.print
        {
            Console.WriteLine("Funcioanrio -------------");
            Console.WriteLine($"Nome: {Nome}.");
            Console.WriteLine($"Cargo: {Cargo}.");
            Console.WriteLine($"Salario: {Salario}.");
            Console.WriteLine($"Salario Líquido: {SalarioLiquido()}.");
            Console.WriteLine("");
        }

        public double SalarioLiquido()
        {
            if (Cargo == "estagiario") // poderia ser assim, se fosse junto, mas poderia ser asso
            {
                return SalarioLiquidoEstagiario();
            }
            return SalarioLiquidoClt();
        }

        public double SalarioLiquidoEstagiario()
        {
            return Salario;
        }

        public double SalarioLiquidoClt()
        {
            return Salario * 0.725;
        }

    }
}

using System;
using Contas;

namespace _03_01_Criando_Primeira_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            Console.WriteLine(conta.ExibirExtrato());

            var conta2 = new Conta("0001", DateTime.Now, 100);
            Console.WriteLine(conta2.ExibirExtrato());

        }
    }
    
}

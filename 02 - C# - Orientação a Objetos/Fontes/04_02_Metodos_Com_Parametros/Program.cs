using System;
using Contas;

namespace _03_01_Criando_Primeira_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.Numero = "001";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 100;

            conta.ExibirExtrato();
            conta.Depositar(50);
            conta.ExibirExtrato();
            conta.Sacar(30);
            conta.ExibirExtrato();

        }
    }
    
}

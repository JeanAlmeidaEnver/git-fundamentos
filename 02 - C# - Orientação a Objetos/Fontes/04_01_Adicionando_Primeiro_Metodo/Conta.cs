using System;

namespace Contas
{
    public class Conta 
    {
        public string? Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        public void ExibirExtrato()
        {
            Console.WriteLine($"Conta Nº:         {Numero}");
            Console.WriteLine($"Data de Abertura: {DataAbertura.ToString("dd/MM/yyyy")} ");
            Console.WriteLine($"Saldo:            {Saldo.ToString("C")} ");
        }
    }
}
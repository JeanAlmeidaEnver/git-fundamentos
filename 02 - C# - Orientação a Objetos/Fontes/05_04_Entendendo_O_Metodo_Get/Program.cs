using System;
using RH;

namespace _05_02_Modificadores_De_Acesso_Privatge_X_Public
{
    class Program 
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Joel", "000.000.000-00");
            Console.WriteLine(funcionario.CPF);
            
        }
    }
}
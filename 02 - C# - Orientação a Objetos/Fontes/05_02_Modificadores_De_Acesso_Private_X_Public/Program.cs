using System;
using RH;

namespace _05_02_Modificadores_De_Acesso_Privatge_X_Public
{
    class Program 
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario();
            funcionario.Nome = "Joel";
            funcionario.CPF = "000.000.000.-00";
        }
    }
}
using System;

namespace _04_02_Action_Func_Predicate
{
    class Program
    {
        static void Main(string[]args)
        {
            Action<string> exibir = informacao => Console.WriteLine($"INFORMAÇÃO: {informacao}");
            exibir("Testando");

            Func<int, int, int> realizarOperacao = (a, b) => a + b;
            Console.WriteLine(realizarOperacao(50,25));

            Predicate<int> verificar = a => a % 2 ==0;
            Console.WriteLine(verificar(50));
        }
    }
}
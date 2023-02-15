using System;

namespace _02_03_Revisando_Arrays_Em_CSharp
{
    class program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            var nomes = new string[5];
            var letras = new char[]{'A','B','C'};

            for(int i = 0; i < letras.Length; i++)
            {
                Console.WriteLine(letras[i]);
            }
        }
    }
}
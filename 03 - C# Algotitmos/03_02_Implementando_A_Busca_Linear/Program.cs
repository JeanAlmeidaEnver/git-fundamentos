using System;

namespace _03_02_Implementando_A_Busca_linear
{
    class Program
    {
        static int BuscarItem(int[] array, int ItemBuscado)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (array[i] == ItemBuscado)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            var itens = new int[]{ 5, 10, 15, 20, 25};
            var itemBuscado = 20;

        //  for(int i = 0; i < itens.Length; i++)
        //    {
        //        Console.WriteLine(itens[i]);
        //        if(itens[i] == itemBuscado)
        //        {
        //            Console.WriteLine($"Posição do item buscado:{i}");
        //            break;
        //        }      
        //    } 

            Console.WriteLine(BuscarItem(itens, itemBuscado));
        }
    }
}
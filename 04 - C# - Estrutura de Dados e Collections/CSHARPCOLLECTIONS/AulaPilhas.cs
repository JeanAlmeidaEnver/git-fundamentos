namespace CSharpCollections
{
    public class AulaPilhas
    {
        public static void main()
        {
            var pilha = new Stack<string>();
            pilha.Push("Introdução ao C#");
            imprimir(pilha);
            Console.WriteLine("---------------------");
            pilha.Push("Orientação a objetos");
            imprimir(pilha);
            Console.WriteLine("---------------------");
            pilha.Push("Introdução ao ASP.NET");
            imprimir(pilha);
            Console.WriteLine("---------------------");
            pilha.Pop();
            imprimir(pilha);
        }

        private static void imprimir(Stack<string> pilha)
        {
            foreach ( var item in pilha)
            {
                Console.WriteLine(item);
            }
        }
    }
}
namespace CSharpCollections
{
    public class AulaFilas
    {
        public static void main()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Cleyson");
            fila.Enqueue("Elton");
            fila.Enqueue("Ariel");
            imprimir(fila);
            Console.WriteLine("--------------------------");
            fila.Dequeue();
            imprimir(fila);
        }

        private static void imprimir(Queue<string> fila)
        {
            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }
        }
    }
}
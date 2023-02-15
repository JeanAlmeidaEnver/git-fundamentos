namespace CSharpCollections
{
    public class AulasListas
    {
        public static void main()
        {
            var alunos = new List<string>() {"Cleyson", "Elton", "Wesley", "Ana", "Ariel"};
            imprimir(alunos);
            //Console.WriteLine(alunos.Capacity);
            //Console.WriteLine(alunos.Count);
            //Console.WriteLine(alunos.First());
            //Console.WriteLine(alunos.Last());
            //Console.WriteLine(alunos.IndexOf("Cleyson"));
            //Console.WriteLine(alunos.IndexOf("Sara"));
            imprimir(alunos);
            Console.WriteLine("-------------------------------");
            alunos.Add("Sara");
            imprimir(alunos);
            Console.WriteLine("-------------------------------");
            alunos.Insert(2, "Jean Carlos de Almeida");
            imprimir(alunos);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(alunos.Exists(aluno => aluno.StartsWith("Jean")));
            Console.WriteLine("-------------------------------");
            Console.WriteLine(alunos.Find(aluno => aluno.StartsWith("Jean")));

            Console.WriteLine("-------------------------------");
            var alunos2 = alunos.GetRange(3, 2);
            imprimir(alunos2);

            Console.WriteLine("-------------------------------");
            var alunos3 = alunos.GetRange(0, alunos.Count);
            imprimir(alunos3);
        }

        private static void imprimir(List<string> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
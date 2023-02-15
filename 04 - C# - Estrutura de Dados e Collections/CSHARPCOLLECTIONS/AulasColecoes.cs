namespace CSharpCollections
{
    public class AulasColecoes
    {
        public static void main()
        {
            var alunos = new HashSet<string>();
            alunos.Add("Cleyson");
            alunos.Add("Sara");
            alunos.Add("Elton");
            alunos.Add("Sara");

            imprimir(alunos);

            Console.WriteLine(alunos.First(aluno => aluno.StartsWith("S")));
        }

        private static void imprimir(HashSet<string> set)
        {
            foreach( var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
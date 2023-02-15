namespace CSharpCollections
{
    public class AulaDicionarios
    {
        public static void main()
        {
            var alunos = new Dictionary<string, string>();
            alunos.Add("123", "Cleyson");
            alunos.Add("1234", "Jean Carlos de Almeida");
            alunos["123"] = "Carlos";
            alunos["123"] = "Almeida Carlos";

            Console.WriteLine(alunos.FirstOrDefault(aluno => aluno.Key == "1234").Value);
            Console.WriteLine("-----------------------------------------------------");
            imprimir(alunos);
        }
        private static void imprimir(Dictionary<string, string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
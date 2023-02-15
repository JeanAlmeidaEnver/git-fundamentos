namespace RH
{
    public class Funcionario
    {
        public string? Nome;
        private string? cpf;
        public string CPF
        {
            get
            {
                return cpf.Replace(".", "").Replace("-", "");
            }
        }
        public Funcionario(string nome, string _cpf)
        {
            Nome = nome;
            cpf = _cpf;
        }
    }
}
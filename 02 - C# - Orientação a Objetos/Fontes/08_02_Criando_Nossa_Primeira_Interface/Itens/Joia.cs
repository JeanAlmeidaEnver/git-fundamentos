namespace Itens
{
    public class Joia : Item
    {
        public int Valor { get; set; }
        public Joia(string nome, int x, int y, int valor) : base (nome, x, y)
        {
            Valor = valor;
        }
    }
}
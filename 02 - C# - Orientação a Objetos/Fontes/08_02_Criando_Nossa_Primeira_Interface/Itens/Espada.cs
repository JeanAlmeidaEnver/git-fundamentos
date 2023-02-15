namespace Itens
{
    public class Espada : Item
    {
        public int Dano{ get; set; }
        public Espada(string nome, int x, int y, int dano) : base(nome, x, y)
        {
            Dano = dano;
        }
    }
}
namespace Itens
{
    public class Pocao : Item 
    {
        public int Vida { get; set; }
        public Pocao(string nome, int x, int y, int vida) : base(nome, x, y)
        {
            Vida = vida;
        }
    }
}
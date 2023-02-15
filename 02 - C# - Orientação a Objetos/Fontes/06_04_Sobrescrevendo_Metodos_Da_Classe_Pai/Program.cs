using Personagens;

namespace _06_02_Definindo_Heranca_Entre_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var cavaleiro = new Cavaleiro("Aragorn", 100);
            var arqueiro  = new Arqueiro("Legolas", 100);
            var mago      = new Mago("Gandalf", 100, 100);

            cavaleiro.Atacar();
            cavaleiro.Defender();

            arqueiro.Atacar();
            arqueiro.Defender();

            mago.Atacar();
            mago.Defender();

        }
    }
}
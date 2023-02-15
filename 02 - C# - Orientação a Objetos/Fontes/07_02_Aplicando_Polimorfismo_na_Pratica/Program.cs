using System;
using Notificacoes;

namespace _07_02_Aplicando_Polimoffism_Na_Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleciona o tipo de notificação: 1-Email | 2-SMS | 3-WhatsApp");
            var tipo = Console.ReadLine();

            Console.WriteLine("Digite o destinatário:");
            var destinatario = Console.ReadLine();

            Console.WriteLine("Digita a mensagem:");
            var mensagem = Console.ReadLine();

            Notificacao notificacao; 

            notificacao = new NotificacaoEmail(destinatario, mensagem);
        }
    }
}
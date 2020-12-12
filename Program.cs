using System;
using RepresentarJogador.classes;

namespace RepresentarJogador
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorDeFutebol jogador = new JogadorDeFutebol();
            Console.WriteLine("Digite o nome do jogador");
            jogador.Nome = Console.ReadLine();
            Console.WriteLine("Digite a posição do jogador [defesa] [meio-campo] [atacante]");
            jogador.Posicao = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento do jogador [ano, mês, dia]");
            jogador.DataDeNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nascionalidade do jogador");
            jogador.Nacionalidade = Console.ReadLine();
            Console.WriteLine("Digite a altura do jogador");
            jogador.Altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso do jogador");
            jogador.Peso = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            jogador.ImprimirDados();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"A idade do Jogador é {jogador.Idade()} anos");
            
            Console.ForegroundColor = ConsoleColor.Red;
            jogador.Aposentar();
            Console.ResetColor();
        }
    }
}

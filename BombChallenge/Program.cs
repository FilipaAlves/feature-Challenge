using System;
using static BombChallenge.Bomb;

namespace BombChallenge
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Desafio: Desarmar a Bomba!***");
            Console.WriteLine("Escreva, por ordem, a cor dos fios que quer cortar, para desarmar a bomba. Coloque-as separadas por vírgulas.\nEscolha entre as cores disponíveis:\nbranco, preto, vermelho, verde, laranja, roxo");
            string input = Console.ReadLine();
            BombOutput(input);
        }
    }
}

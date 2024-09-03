 /*-------------------------------------------------------------------
Questão 4: Jornada do Herói com Pontos de Vida e Itens de Cura
Contextualização
O herói de um jogo atravessa várias fases, ganhando ou perdendo pontos de vida. Além disso, 
em algumas fases, o herói pode usar itens de cura para recuperar pontos de vida.
Comando
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas fases ele deseja jogar.
2. Para cada fase, pergunte quantos pontos de vida o herói ganhou ou perdeu (valores 
positivos indicam ganho e negativos indicam perda).
3. Para cada fase, pergunte se o herói usou um item de cura (Sim/Não). Se sim, pergunte 
quantos pontos de cura foram usados.
O programa deve calcular e mostrar a vida total do herói ao final da jornada, considerando que 
ele começa com 100 pontos de vida.
@Lista: 03 - Condicionais
@Autor: Samuel Barbosa Chaves Brandão
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? cr;
        int fs, pt = 0, ptcr = 0, fim = 0,fim1 = 0;
        Console.WriteLine("Quantas fases você deseja jogar?");
        int.TryParse(Console.ReadLine(), out fs);
        for (int i = 0; i < fs; i++)
        {
            Console.WriteLine("Quantos pontos de vida o herói ganhou ou perdeu  em cada fase?(utilize o sinal - para indicar pontos negativos)");
            int.TryParse(Console.ReadLine(), out pt);
            Console.WriteLine("Usou intem de cura?");
            cr = Console.ReadLine();
            if (cr == "sim")
            {
                Console.WriteLine("Quantos pontos curou?");
                       int.TryParse(Console.ReadLine(), out ptcr);
            }
            fim +=ptcr;
            fim1= pt+fim+100;
        }

                Console.WriteLine($"você ganhou {fim1} pontos.");
    }
}

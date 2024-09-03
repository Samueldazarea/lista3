/*-------------------------------------------------------------------
Questão 3: Gerenciamento de Inventário com Limite e Tipos de 
Itens
Contextualização
Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua
quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1. Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no
inventário.
2. Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3. Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está
dentro da capacidade máxima, informando se está excedido ou não.
O programa deve calcular e exibir a pontuação total acumulada pelo jogador.
@Lista: 03 - Condicionais
@Autor: Samuel Barbosa Chaves Brandão
@Data: 02/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? nivel;
        int it, inv, qua, totIt = 0;
        Console.WriteLine(" Quantos tipos diferentes de itens ele deseja armazenar no inventário?");
        int.TryParse(Console.ReadLine(), out it);
        Console.WriteLine(" Qual é a capacidade máxima do inventário.");
        int.TryParse(Console.ReadLine(), out inv);
        for (int i = 0; i < it; i++)
        {
            Console.WriteLine("Qual o nome do item?");
            nivel = Console.ReadLine();
            Console.WriteLine("Quantos itens desse tipo ele possui?");
            int.TryParse(Console.ReadLine(), out qua);
            totIt += qua;
            }
            if(totIt<=inv)
            {
                       Console.WriteLine($"Tem-se {totIt} itens,Dentro da capacidade");
            }
            else
            {
                Console.WriteLine($"Tem-se {totIt} itens,fora da capacidade");
            }
    }
}

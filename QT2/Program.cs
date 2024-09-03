/*-------------------------------------------------------------------
@Lista: 03 - Lógica de Programação
@Autor: Samuel Barbosa Chaves Brandão
@Data: 27/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main()
    {

        int m, fim = 0, fim1 = 0, fim2 = 0, fim3 = 0;
        string? n;

        System.Console.WriteLine("Quantas missões foram completas?");
        int.TryParse(Console.ReadLine(), out m);
        for (int i = 0; i < m; i++)
        {
            System.Console.WriteLine("Qual o nível da dificuldade");
            n = Console.ReadLine();
            if (n == "facil")
            {

                System.Console.WriteLine("QUANTIDADE DE INMIGOS DERROTADOS NA MISSÃO");
                int.TryParse(Console.ReadLine(), out i);
                fim = 50 * i;

            }
            else if (n == "medio")
            {

                System.Console.WriteLine("QUANTIDADE DE INMIGOS DERROTADOS NA MISSÃO");
                int.TryParse(Console.ReadLine(), out i);
                fim1 = 100 * i;
            }
            else if (n == "dificil")
            {

                System.Console.WriteLine("QUANTIDADE DE INMIGOS DERROTADOS NA MISSÃO");
                int.TryParse(Console.ReadLine(), out i);
                fim2 = 150 * i;

            }

            fim3 = fim + fim1 + fim2;

        }
        System.Console.WriteLine($"VOCE GANHOU {fim3} pontos!");


    }


}
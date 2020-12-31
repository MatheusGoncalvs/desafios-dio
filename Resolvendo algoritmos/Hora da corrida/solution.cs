using System;

public class Pessoa
{
    public static void Main()
    {
        string[] entrada = Console.ReadLine().Split(" ");
        int totalVoltas = int.Parse(entrada[0]);
        int totalPlacas = int.Parse(entrada[1]);

        int totalPlacasPercurso = totalVoltas * totalPlacas;

        for (int i = 10; i < 100; i += 10)
        {
            double totalPlacasParaCadaMeta = (double)totalPlacasPercurso / 100 * i;

            Console.Write($"{Math.Ceiling(totalPlacasParaCadaMeta)} ");
        }
    }
}
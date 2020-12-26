using System;

class Desafio {
    static void Main() {
        int quilometros = Int32.Parse(Console.ReadLine()); //Captura a entrada, transforma em int e guarda na variavel quilometros; (Entrada)
        int minutos = quilometros * 2; // Os minutos é a multiplicação dos quilometros por 2; (Processamento)
        Console.WriteLine(minutos + " minutos"); //Escreve no console os minutos; (Saída)
    }
}
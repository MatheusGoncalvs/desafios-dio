using System;

public class pizzaria
{
  public static void Main()
  {
    string[] line = Console.ReadLine().Split(" ");
    int totalDePessoas = int.Parse(line[0]);
    int totalDeDatas = int.Parse(line[1]);
    
    string dataConsiderada = "";
    
    for (int i = 0; i < totalDeDatas; i++)
    {
      int totalDePessoasQuePodemComparecer = 0;
      
      string[] entradaDataConfirmacao = Console.ReadLine().Split(" ");
      dataConsiderada = entradaDataConfirmacao[0];
      
      for (int j = 1; j < totalDePessoas + 1; j++)
      {
        totalDePessoasQuePodemComparecer += int.Parse(entradaDataConfirmacao[j]);
      }
      
      if (totalDePessoasQuePodemComparecer == totalDePessoas)
      {
        Console.WriteLine(dataConsiderada);
        break;
      } 
      else if ( i + 1 >= totalDeDatas)
      {
        Console.WriteLine("Pizza antes de FdA");
      }
    }
  }
}
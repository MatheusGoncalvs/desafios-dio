using System;

public class Refeicao
{
    public static void Main()
    {
        string[] RefeicoesDisponiveis = Console.ReadLine().Split(" ");
        int Ca = int.Parse(RefeicoesDisponiveis[0]);
        int Ba = int.Parse(RefeicoesDisponiveis[1]);
        int Pa = int.Parse(RefeicoesDisponiveis[2]);

        string[] RefeicoesRequisitadas = Console.ReadLine().Split(" ");
        int Cr = int.Parse(RefeicoesRequisitadas[0]);
        int Br = int.Parse(RefeicoesRequisitadas[1]);
        int Pr = int.Parse(RefeicoesRequisitadas[2]);

        int CIndisponivel = 0;
        int BIndisponivel = 0;
        int PIndisponivel = 0;

        if (Cr > Ca)
            CIndisponivel = Cr - Ca;

        if (Br > Ba)
            BIndisponivel = Br - Ba;

        if (Pr > Pa)
            PIndisponivel = Pr - Pa;

        int TotalIndisponivel = CIndisponivel + BIndisponivel + PIndisponivel;

        if (TotalIndisponivel >= 0)
            Console.Write(TotalIndisponivel);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
        int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
        int totalDeFigurinhas = 0;

        int[] albumDeFigurinha = new int[numeroDeFigurinhas];
        int[] compradas = new int[numeroDeFigurinhasCompradas];

        if (numeroDeFigurinhasCompradas > 0)
        {
            for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
            {
                compradas[i] = Int32.Parse(Console.ReadLine());
            }

        }
        int[] removeRep = compradas.Distinct().ToArray();
        for (int x = 0; x < removeRep.Length; x++)
        {
            albumDeFigurinha[x] = removeRep[x];
        }

        int qtRemoveRep = removeRep.Length;

        if (qtRemoveRep < 0)
        {
            qtRemoveRep = 0;
        }
        if (removeRep.Length == albumDeFigurinha.Length)
        {
            totalDeFigurinhas = 0;
        }
        else
        {
            totalDeFigurinhas = numeroDeFigurinhas - qtRemoveRep;
        }

        Console.WriteLine(totalDeFigurinhas);
    }

}
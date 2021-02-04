using System;


class Program
{
    static void Main(string[] args)
    {
        string [] dados = Console.ReadLine().Split(" ");        
        int conTempo, conVelMed;
        conTempo = Convert.ToInt32(dados[0]);
        conVelMed = Convert.ToInt32(dados[1]);

        double consumo = (Convert.ToDouble(conTempo) * Convert.ToDouble(conVelMed)) / 12;             
        
        Console.WriteLine(consumo.ToString("0.000"));
    }
}

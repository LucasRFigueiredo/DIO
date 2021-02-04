using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
          int tempo = Console.ReadLine();
          int velMed = Console.ReadLine();
          double consumo = 12 / (tempo * velMed);
          
          Console.WriteLine("{0,f3}", consumo);
        }
    }
}
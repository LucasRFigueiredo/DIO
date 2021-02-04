using System;


class Program
{
    static void Main(string[] args)
    {
        double n1, n2, n3;
        n1 = Convert.ToDouble(Console.ReadLine());
        n2 = Convert.ToDouble(Console.ReadLine());
        n3 = Convert.ToDouble(Console.ReadLine());

        double media;
        media = (n1*0.2)+(n2*0.3)+(n3*0.5);
        
        

        Console.WriteLine("MEDIA = "+ media.ToString("0.0"));        
    }
}
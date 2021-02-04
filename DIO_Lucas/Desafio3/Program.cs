using System;
using System.Text;

class MainClass
{
    public static void Main(string[] args)
    {
        String vertebra;
        String classes;
        String alimentacao;

        vertebra = Console.ReadLine();
        classes = Console.ReadLine();
        alimentacao = Console.ReadLine();
       
        if ((vertebra.Equals("vertebrado")) && (classes.Equals("ave")) && (alimentacao.Equals("carnivoro")))
        {
            Console.WriteLine("aguia");
        }

        if ((vertebra.Equals("vertebrado")) && (classes.Equals("ave")) && (alimentacao.Equals("onivoro")))
        {
            Console.WriteLine("pomba");
        }

        if ((vertebra.Equals("vertebrado")) && (classes.Equals("mamifero")) && (alimentacao.Equals("onivoro")))
        {
            Console.WriteLine("homem");
        }

        if ((vertebra.Equals("vertebrado")) && (classes.Equals("mamifero")) && (alimentacao.Equals("herbivoro")))
        {
            Console.WriteLine("vaca");
        }

        if ((vertebra.Equals("invertebrado")) && (classes.Equals("inseto")) && (alimentacao.Equals("hematofago")))
        {
            Console.WriteLine("pulga");
        }

        if ((vertebra.Equals("invertebrado")) && (classes.Equals("inseto")) && (alimentacao.Equals("herbivoro")))
        {
            Console.WriteLine("lagarta");
        }

        if ((vertebra.Equals("invertebrado")) && (classes.Equals("anelideo")) && (alimentacao.Equals("hematofago")))
        {
            Console.WriteLine("sanguessuga");
        }

        if ((vertebra.Equals("invertebrado")) && (classes.Equals("anelideo")) && (alimentacao.Equals("onivoro")))
        {
            Console.WriteLine("minhoca");
        }

    }
}
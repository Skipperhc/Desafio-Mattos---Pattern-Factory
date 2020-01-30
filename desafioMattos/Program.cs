using System;
using System.Diagnostics;

namespace desafioMattos
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Console.WriteLine("Quer qual pizza? \n Calabresa || Portuguesa");

            var pizza= factory.Create(Console.ReadLine());

            Console.WriteLine($"Você escolheu uma pizza sabor: {pizza.Nome} que lhe custará {pizza.Preco},  para entregar: {pizza.ParaEntregar}");
            
        }
    }

    public class Factory
    {
        public Pizza Create(string opcao)
        {
            Pizza escolha = null;

            switch (opcao)
            {
                case "calabresa":
                    escolha = new Calabresa();
                    break;
                case "portuguesa":
                    escolha = new Portuguesa();
                    break;
                default:
                    Console.WriteLine("erro");
                    break;
            }

            Console.WriteLine("quer que entregue?");
            string c_entrega = Console.ReadLine();
            switch (c_entrega)
            {
                case "sim":
                    escolha.ParaEntregar = true;
                    break;
                case "nao":
                    escolha.ParaEntregar = false;
                    break;
            }
            return escolha;
        }
    }

    public class Calabresa : Pizza
    {
        public Calabresa()
        {
            Nome = "Calabresa";
            Preco = 40;
        }
    }
    
    public class Portuguesa : Pizza
    {
        public Portuguesa()
        {
            Nome = "Portuguesa";
            Preco = 100;
        }
    }
    
    public class Pizza
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public  bool ParaEntregar { get; set; }
    }
}
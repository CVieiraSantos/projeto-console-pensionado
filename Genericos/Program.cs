using System;
using System.Globalization;
using System.Collections.Generic;
using Genericos.Entities;


namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<Estudante> estudantes = new List<Estudante>();
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                estudantes.Add(new Estudante(name, email, quarto));
            }

            Console.WriteLine();

            foreach(Estudante est in estudantes)
            {
                if(estudantes != null){
                    Console.WriteLine(est);
                }
            }
            
            
        }
    }
}

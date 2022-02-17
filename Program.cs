using System;
using System.Collections.Generic;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPessoa = new List<Candidate>();
            var cont = string.Empty;
            var proc = string.Empty;
            
            Console.WriteLine("Cadastramento de pessoas.");
            Console.WriteLine();

            Console.WriteLine("Deseja fazer um cadastro ? 's' ou 'n'.");
            proc = Console.ReadLine();

            while(proc == "s")
            {
            do{

            var pessoa = new Candidate();
            Console.WriteLine("Digite seu nome.");
            pessoa.Name = Console.ReadLine();

            Console.WriteLine("Digite sua idade.");
            pessoa.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura.");
            pessoa.Alt = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite seu peso.");
            pessoa.kg = double.Parse(Console.ReadLine());

            listaPessoa.Add(pessoa);

            //deseja cadastrar mais uma?

            Console.WriteLine("Deseja cadastrar uma nova pessoa? s ou n.");
            cont = Console.ReadLine();
            
            } while(cont == "s");
            break;
            }

           

            var idCorrentePessoa = 1;
            foreach(var pessoa in listaPessoa) {

            Console.WriteLine($"Pessoa {idCorrentePessoa}: Nome: {pessoa.Name}");
            Console.WriteLine($"Pessoa {idCorrentePessoa}: Idade: {pessoa.Age}");
            Console.WriteLine($"Pessoa {idCorrentePessoa}: Altura: {pessoa.Alt}");
            Console.WriteLine($"Pessoa {idCorrentePessoa}: Peso: {pessoa.kg}");
            Console.WriteLine();
             idCorrentePessoa = idCorrentePessoa+1;

             
            } Console.WriteLine("Obrigado.");
        }
    }
}

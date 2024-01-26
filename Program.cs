using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace atividadepets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacao = 0;

            while (operacao != 4)
            {

                if (operacao == 0)
                {
                    Console.WriteLine("Bem vindo ou Petshop");
                    Console.WriteLine("Opções");
                    Console.WriteLine(" 1 - Calcular a medicação do seu pet");
                    Console.WriteLine(" 2 - Agendar banho");
                    Console.WriteLine(" 3 - Calcular a alimentação");
                    Console.WriteLine(" 4 - Sair ");

                }
                bool deuCerto = int.TryParse(Console.ReadLine(), out operacao);

                if (operacao == 1)
                {
                    Console.WriteLine("Informa o peso do seu pet");
                    int peso = int.Parse(Console.ReadLine());
                    Console.WriteLine("qual a dosagem de medicação?");
                    int dose = int.Parse(Console.ReadLine());
                    int div = peso / dose;
                    Console.WriteLine("A dosagem é" + div);

                }
                if (operacao == 2)
                {
                    Console.WriteLine("Qual o porte do seu pet? pequeno, medio ou grande?");
                    string porte = (Console.ReadLine());
                    Console.WriteLine("Deseja cuidados adcionais?");
                    string resposta = (Console.ReadLine());
                    decimal total = 0;

                    if (resposta == "sim")
                    {
                        Console.WriteLine("Tirar parasitas");
                        string resp = (Console.ReadLine());
                        
                        if (resp == "sim")
                        {
                            decimal conta = total + 20;
                            Console.WriteLine("oi + conta");
                        }
                    
                        Console.WriteLine("Aparar pelo");
                        string resp = (Console.ReadLine());
                   
                        Console.WriteLine("Shampoo premium");
                        string resp = (Console.ReadLine());
                     }
                }

                    if (operacao == 3)
                    {
                        Console.WriteLine("Quantos pets senhor(A) tem?");
                        int numero_pet = int.Parse(Console.ReadLine());

                        Console.WriteLine("E de racao quantos que tem?");
                        int racao = int.Parse(Console.ReadLine());
                    }
                    if (operacao == 4)
                    {

                    }
                
            }
        }
    }
}  


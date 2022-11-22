using System;
using System.Globalization;
using System.Collections.Generic;

namespace Financeira
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Contrato> list = new List<Contrato>();

            Console.WriteLine("Digite o nume de finanças que deseja registar: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                    
                Console.WriteLine($"Finança #{i}  ");

                inicio: //Checkpoint 

                Console.WriteLine("O que deseja registrar?");
                Console.WriteLine("Pessoa fisica = 1 / Pessoa Juridica = 2");
                int resp = int.Parse(Console.ReadLine());

                if (resp == 1)
                {
                    Console.WriteLine("Contratante: ");
                    string contratante = Console.ReadLine();

                    Console.WriteLine("Numero: ");
                    int numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor: ");
                    double valor = double.Parse(Console.ReadLine());

                    Console.WriteLine("Prazo (meses): ");
                    int prazo = int.Parse(Console.ReadLine());

                    Console.WriteLine("CPF: ");
                    int cpf = int.Parse(Console.ReadLine());

                    Console.WriteLine("Idade: ");
                    int idade = int.Parse(Console.ReadLine());

                    ContratoPessoaFisica p = new ContratoPessoaFisica();
                    p.calcularPrestacao();


                    list.Add(new ContratoPessoaFisica(contratante, numero, valor, prazo, cpf, idade));

                    Console.Clear();

                }

                else if (resp == 2)
                {
                    Console.WriteLine("Contratante: ");
                    string contratante = Console.ReadLine();

                    Console.WriteLine("Numero: ");
                    int numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor: ");
                    double valor = double.Parse(Console.ReadLine());

                    Console.WriteLine("Prazo (meses): ");
                    int prazo = int.Parse(Console.ReadLine());

                    Console.WriteLine("CNPJ: ");
                    int cnpj = int.Parse(Console.ReadLine());

                    Console.WriteLine("IE: ");
                    int ie = int.Parse(Console.ReadLine());

                    ContratoPessoaJuridica a = new ContratoPessoaJuridica();
                    a.calcularPrestacao();


                    list.Add(new ContratoPessoaJuridica(contratante, numero, valor, prazo, cnpj, ie));

                    Console.Clear();
                    
                }

                else // Se o usuario digitar um numero que não seja 1 ou 2
                {
                    Console.WriteLine("digite novamente");
                    goto inicio; //Volta para o checkpoint
                }


            }

            Console.WriteLine("LISTA DE CONTRATOS:");

            foreach (Contrato b in list)
            {
                Console.WriteLine();
                Console.WriteLine(b.ExibirInfo());

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace questao4
{
    /*4.	Crie um programa que deverá receber o nome, a descrição do produto e valor unitário 
     * de “n” produtos. O programa criado deverá apresentar as seguintes características:
•	Possuir um menu onde o usuário possa escolher qual das opções deseja com apenas um caractere; 
•	No menu uma opção de inserção de dados; 
•	No menu uma opção de listagem, onde nos dados inseridos poderão ser visualizados.
•	No menu uma opção para visualizar a somatória dos valores inseridos;
•	No menu uma opção para visualizar a média aritmética dos valores inseridos;
•	No menu uma opção para finalizar o programa.
*/
    class Program
    {
        static int x , menu = 0;
        static double soma = 0, media = 0;
        static List<double> valorUnitario = new List<double>();
        static List<string> nomes = new List<string>();
        static void Menu()
        {
            Console.WriteLine("\n┌────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                          MENU                          │");
            Console.WriteLine("├────────────────────────────────────────────────────────┤");
            Console.WriteLine("│ digite 1 para inserir dados                            │");
            Console.WriteLine("│ digite 2 para listar dados                             │");
            Console.WriteLine("│ digite 3 para vizualizar soma dos valores inseridos    │");
            Console.WriteLine("│ digite 4 para vizualizar a média dos valores inseridos │");
            Console.WriteLine("│ digite 9 para finalizar o programa                     │");
            Console.WriteLine("└────────────────────────────────────────────────────────┘");
            menu = int.Parse(Console.ReadLine());
        }

        static void Inserir()
        {
            Console.Clear();
            Console.WriteLine("digite a quantidade de produtos que deseja cadastrar.");
            x = int.Parse(Console.ReadLine());


            for (int i = 0; i < x; i++)
            {
                Console.Clear();
                Console.WriteLine($"digite o nome do {i + 1}º produto.");
                nomes.Add(Console.ReadLine());

                Console.WriteLine($"digite o valor do {i + 1}º produto.");
                valorUnitario.Add(double.Parse(Console.ReadLine()));


            }
        }

        static void Listar()
        {
            Console.Clear();
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"o nome do {i + 1}º produto é {nomes[i]}, o seu valor é de R${valorUnitario[i]}");
                soma += valorUnitario[i];
            }
            Console.ReadLine();
        }
        static void Somar()
        {
            Console.Clear();
            Console.WriteLine($"a soma do valor de todos os produtos é de R${soma}.");
        }
        static void Media()
        {
            Console.Clear();
            Console.WriteLine($"a média dos valores dos produtos é de R${soma / x}");
        }
        static bool Finalizar()
        {
            Console.Clear();
            return false;
            Console.ReadKey();
        }

        static void Main(string[] args)
            {
            bool abc = true;
            while(abc)
                {
                 Menu();

                switch (menu)
                {

                    case 1:
                        {
                            Inserir();
                            break;
                        }

                    case 2:
                        {
                            Listar();
                            break;
                        }
                    case 3:
                        {
                            Somar();
                            break;
                        }
                    case 4:
                        {
                            Media();
                            break;
                        }
                    case 9:
                        {
                            abc = Finalizar();
                            break;

                        }

                }
            }
            }
        }
    }



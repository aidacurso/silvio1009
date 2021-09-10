using System;
using System.Collections.Generic;
using System.Linq;

namespace questao3
{/*3.	Crie um programa que deverá receber o nome e valor unitário de “n” produtos.
  * Após o usuário finalizar a inserção dos dados o programa deverá: 
•	Limpar a tela;
•	Listar os dados recebidos;
•	Exibir a somatória dos valores;
•	Exibir a média aritmética dos valores dos produtos;
•	Informar qual o maior e menor valor de produto.
*/
    class Program
    {
        static int x;
        static double soma= 0, media= 0;
        static List<double> valorUnitario = new List<double>();
        static List<string> nomes = new List<string>();
   
        static void Receber()
        {
            Console.WriteLine("digite a quantidade de produtos que deseja cadastrar.");
            x = int.Parse(Console.ReadLine());


            for (int i = 0; i < x; i++)
            {
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
            Console.WriteLine($"a soma do valor de todos os produtos é de R${soma}.");
            Console.WriteLine($"a média dos valores dos produtos é de R${soma/x}");
            Console.WriteLine($"o maior valor cadastrado dos produtos é R${valorUnitario.Max()} e o menor valor é R${ valorUnitario.Min()}");
            
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Receber();
            Listar();
        }
    }
}

using System;
using System.Collections.Generic;

namespace questao2
{/*2.	Crie um programa que deverá receber o nome,
  * idade e salário de “n” pessoas, após o usuário finalizar
  * a inserção dos dados o programa deverá limpar a tela e listar
  * os dados recebidos. Utilize uma estrutura de classe estática na construção deste código.*/
    class Program
    {
        static int x;
        static List<byte> idades = new List<byte>();
        static List<string> nomes = new List<string>();
        static List<string> salarios = new List<string>();
        static void Receber()
        {
            Console.WriteLine("digite a quantidade de pessoas que deseja cadastrar.");
            x = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"digite o nome da {i + 1}ª pessoa.");
                nomes.Add(Console.ReadLine());

                Console.WriteLine($"digite a idade da {i + 1}ª pessoa.");
                idades.Add(byte.Parse(Console.ReadLine()));

                Console.WriteLine($"digite o salário da {i + 1}ª pessoa");
                salarios.Add(Console.ReadLine());
            }
        }

        static void Listar()
        {
            Console.Clear();
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"o nome da {i + 1}ª pessoa é {nomes[i]}, a sua idade é de {idades[i]} anos e o seu salário é de R${salarios[i]}.");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Receber();
            Listar();
        }
    }
}

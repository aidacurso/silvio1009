using System;

namespace questao1
{/*1.	Crie um programa que deverá receber o nome e idade de 5 pessoas,
  * após receber os nomes o programa deverá limpar a tela e listar os nomes
  * recebidos. Utilize a classe estática na construção deste código.*/
    class Program
    {
        static int[] idades = new int[5];
        static string[] nomes = new string[5];

        static void Receber()
        {
            for (int i = 0; i <5; i++)
            {
                Console.WriteLine($"digite o nome da {i+1}ª pessoa.");
                nomes[i] = Console.ReadLine();

                Console.WriteLine($"digite a idade da {i+1}ª pessoa.");
                idades[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Listar()
        {
            Console.Clear();
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"o nome da {i+1}ª pessoa é {nomes[i]} e a sua idade é de {idades[i]} anos.");
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

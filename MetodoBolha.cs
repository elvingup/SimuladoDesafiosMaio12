using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BubbleSortDesafio20230512
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Ordenar uma lista de números sem utilizar os métodos da linguagem.
            Crie um programa em C# que recebe uma lista de números inteiros e 
            ordena essa lista em ordem crescente. Exiba a lista ordenada na tela.*/
      
            Console.WriteLine("Informe algum length para a serie do vetor");
            int length=Convert.ToInt32(Console.ReadLine());

            int[] n = new int[length];

            foreach(int i  in n)
            {
                Console.WriteLine("\nInforme um numero inteiro para a serie do vetor");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nSERIE DO VETOR");
            foreach(int i in n)
            {
                Console.WriteLine(n[i]);
            }

            int aux;

            Console.WriteLine("\nORDEM CRESCENTE");
            foreach(int i in n)
            {
                foreach(int j in n)
                {
                    if (n[j] > n[i])
                    {
                        aux = n[i];
                        n[i] = n[j];
                        n[j] = aux;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

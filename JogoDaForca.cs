using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanDesafio20230512
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que implemente o jogo da forca. 
             * O programa deve gerar uma palavra aleatória para ser adivinhada pelo jogador, 
             * e permitir que o jogador insira uma letra por vez para tentar adivinhar a palavra. 
             * O programa deve exibir a palavra com os espaços em branco para as letras não adivinhadas. 
             */

            char[] palavra = { 'D', 'E', 'S', 'A', 'F', 'I', 'O' };
            char[] jogador = new char[7];

            foreach (char c in jogador)
            {
                jogador[c] = '_';
                
            }

            bool flag=false;

            do
            {
                Console.WriteLine("Digite um numero de um a sete conforme a vaga da letra\n");
                int letra = Convert.ToInt32(Console.ReadLine());

                switch (letra)
                {
                    case 1:
                        Console.WriteLine("Digite uma letra");
                        char letra1 = Convert.ToChar(Console.ReadLine());
                        jogador[letra-1] = letra1;
                        break;
                    case 2:
                        Console.WriteLine("Digite uma letra");
                        char letra2 = Convert.ToChar(Console.ReadLine());
                        jogador[letra-1] = letra2;
                        break;
                    case 3:
                        Console.WriteLine("Digite uma letra");
                        char letra3 = Convert.ToChar(Console.ReadLine());
                        jogador[letra - 1] = letra3;
                        break;
                    case 4:
                        Console.WriteLine("Digite uma letra");
                        char letra4 = Convert.ToChar(Console.ReadLine());
                        jogador[letra - 1] = letra4;
                        break;
                    case 5:
                        Console.WriteLine("Digite uma letra");
                        char letra5 = Convert.ToChar(Console.ReadLine());
                        jogador[letra - 1] = letra5;
                        break;
                    case 6:
                        Console.WriteLine("Digite uma letra");
                        char letra6 = Convert.ToChar(Console.ReadLine());
                        jogador[letra - 1] = letra6;
                        break;
                    case 7:
                        Console.WriteLine("Digite uma letra");
                        char letra7 = Convert.ToChar(Console.ReadLine());
                        jogador[letra - 1] = letra7;
                        break;
                    default:
                        Console.WriteLine("Informe um numero de um a sete");
                        break;
                }

                foreach (char c in jogador)
                {
                    Console.Write(" " + jogador[c]);
                }

                Console.WriteLine("\nContinuar? S-sim || N-não");
                char continuar = Convert.ToChar(Console.ReadLine());
                String continuarr = continuar.ToString();
                continuarr = continuarr.ToLower();
                if (continuarr == "s")
                {
                    flag = true;
                }
            
            } while (flag == true);

            Console.WriteLine("\nO jogo terminou assim\n");

            foreach (char c in jogador)
            {
                Console.Write(" " + jogador[c]);
            }

            Console.ReadKey();
        }
    }
}

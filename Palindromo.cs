using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladoC_Palindromo20230512
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa em C# que recebe uma string e verifica se ela é um palíndromo, ou seja, se pode ser lida da mesma forma tanto da esquerda para a direita quanto da direita para a esquerda. Desconsidere espaços em branco e letras maiúsculas ou minúsculas. Se a string for um palíndromo, exiba a mensagem "A string X é um palíndromo"; caso contrário, exiba a mensagem "A string X não é um palíndromo", em que X é a string recebida como entrada.
            Obs: O codigo (program.cs) deve ser upado no github, e a resposta ser o link do repositório. Caso não consiga, inserir o program.cs na entrega da atividade pelo classroom  */

            Console.WriteLine("Informe alguma palvara");
            string palavra = Console.ReadLine();
                        
            string palavraa = palavra.ToLower().Replace(" ","");
            
            char[] chars = palavraa.ToCharArray();

            int j = 0; int k = 0;

            for(int i = 0; i < chars.Length; i++)
            {
                char c1 = chars[i];

                char c2 = chars[chars.Length - i];

                j++;

                if(c1 == c2)
                {
                    k++;
                }
            }

            if (j == k)
            {
                Console.WriteLine("A palavra " + palavra + " é um palindromo.");
            }
       
            Console.ReadKey();
        }
    }
}

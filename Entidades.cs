using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesIdades.Entidades
{
    public class EntradaDeDados
    {
        List<string> Nome = new List<string>();
        List<int> Idade = new List<int>();
        public void EntradaIdadeNome()
        {
            var idadeMaisVelho = 0;
            var nomeMaisVelho = "";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("###################################\n");
                Console.WriteLine("######## PESQUISA DE IDADE ########\n");
                Console.WriteLine("###################################\n");
                Console.Write($"\nNome da {i + 1}ª pessoa: ");
                var nome = Console.ReadLine();

                Console.Write($"\nIdade da {i + 1}ª pessoa: ");
                var idade = Convert.ToInt32(Console.ReadLine());

                if (idade > 0)
                {
                    if (idade > idadeMaisVelho)
                    {
                        idadeMaisVelho = idade;
                        nomeMaisVelho = nome;

                    }
                    Nome.Add(nome);
                    Idade.Add(idade);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nO valor não pode ser igual ou menor a 0!\n");
                    EntradaIdadeNome();
                }
            }
            SaidaDados(nomeMaisVelho, idadeMaisVelho);
        }

        public void SaidaDados(string nomeMaisVelho, int idadeMaisVelho)
        {
            Console.Clear();
            Console.WriteLine("######## PESSOAS CADASTRADAS ########\n");
            Console.WriteLine("        NOME     ||     IDADE");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(        Nome[i] + "     ||     " + Idade[i]);
            }
            Console.WriteLine($"\n\n{nomeMaisVelho} é a pessoa mais velha e tem {idadeMaisVelho} anos!");
        }
    }
}
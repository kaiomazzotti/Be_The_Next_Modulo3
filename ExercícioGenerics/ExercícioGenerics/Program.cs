using System;
using System.Collections.Generic;
using System.IO;

namespace DictionaryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string dicionario = "dicionario.txt";

            // Verifica se o arquivo existe e, se sim, lê o conteúdo para o dicionário
            if (File.Exists(dicionario))
            {
                string[] linhas = File.ReadAllLines(dicionario);
                foreach (string linha in linhas)
                {
                    string[] parte = linha.Split(',');
                    dictionary[parte[0]] = parte[1];
                }
            }
            int input = 4;
            do
            {
                Console.WriteLine("Bem vindo ao dicionário ABC! Digite: " +
                    "\n1 - Para pesquisar uma palavra no dicionário." +
                    "\n2 - Para inserir uma nova palavra no dicionário." +
                    "\n3 - Para mostrar todo o dicionário." +
                    "\n0 - Para sair.");
                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine("Digite parte da chave para a busca:");
                            string searchTerm = Console.ReadLine().ToLower();

                            // Fazendo a busca no dicionário com o Linq
                            var result = dictionary.Where(x => x.Key.Contains(searchTerm)).ToDictionary(x => x.Key, x => x.Value);
                            int n = 0;
                            // Exibindo os resultados da busca
                            Console.WriteLine("\n");
                            foreach (KeyValuePair<string, string> entry in result)
                            {
                                Console.WriteLine(entry.Key + ":" + entry.Value);
                                Console.WriteLine();
                                n++;
                            }
                            Console.WriteLine("Busca Terminada! foram encontrados o total de {0} palavras",n);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {

                            Console.Write("Insira a nova palavra : ");
                            string palavra = Console.ReadLine().ToLower();
                            if (dictionary.ContainsKey(palavra))
                            {
                                Console.WriteLine("Essa palavra já existe no dicionário");
                            }
                            else
                            {
                                Console.Write("Significado : ");
                                string significado = Console.ReadLine().ToLower();

                                dictionary[palavra] = significado;
                                using (StreamWriter writer = new StreamWriter(dicionario))
                                {
                                    foreach (KeyValuePair<string, string> entry in dictionary)
                                    {
                                        writer.WriteLine(entry.Key + "," + entry.Value );
                                    }
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            foreach (KeyValuePair<string, string> entry in dictionary)
                            {
                                string key = entry.Key;
                                string value = entry.Value;
                                Console.WriteLine(key + " : " + value + "\n");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 0:
                        break;
                    default:
                        {
                            Console.WriteLine("Insira um valor verdadeiro");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (input != 0);
        }
    }
}
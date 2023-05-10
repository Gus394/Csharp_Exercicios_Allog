using System;
using System.Collections.Generic;
using System.Text;

namespace Allog_03
{
    class Lista_de_Compras
    {
        int escolha;
        List<string> lista_de_compras;

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine(" 1. Adicionar item\n 2. Remover item\n 3. Exibir lista\n 4. Sair");
                try
                {
                    this.escolha = Convert.ToInt32(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine(" Insira o nome do item:");
                            this.lista_de_compras.Add(Console.ReadLine());
                            Console.WriteLine("\n Item adicionado.");
                            break;

                        case 2:
                            if (lista_de_compras.Count == 0)
                            {
                                Console.WriteLine("\n Nenhum item ainda.");
                            } else
                            {
                                Console.WriteLine("\n Insira o nome do item:");
                                if (this.lista_de_compras.Remove(Console.ReadLine()))
                                {
                                    Console.WriteLine(" Item removido.");
                                }
                                else
                                {
                                    Console.WriteLine(" Item não encontrado.");
                                }
                            }
                            break;

                        case 3:
                            if (lista_de_compras.Count == 0)
                                Console.WriteLine("\n Nenhum item.");
                            else
                            {
                                lista_de_compras.ForEach(Console.WriteLine);
                            }
                            break;

                        case 4:
                            return;

                        default:
                            Console.WriteLine(" Insira um valor valido.");
                            break;

                    }
                }
                catch ( Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                Console.WriteLine("\n Pressione qualquer tecla para continuar.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        
        public Lista_de_Compras()
        {
            this.lista_de_compras = new List<string>();
        }
    }
}

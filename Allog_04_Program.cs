using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("C:/Users/7355068/source/repos/Aula_5/Aula_5/arquivo.csv");
            while (true)
            {
                Console.WriteLine("Gerenciamento de clientes em um arquivo CSV\n\n1. Cadastrar\n2. Listar\n3. Editar\n4. Excluir\n5. Sair");
                switch (Console.ReadLine())
                {
                    case "1":
                        menu.Cadastro();
                        break;

                    case "2":
                        menu.Listar();
                        break;

                    case "3":
                        menu.Editar();
                        break;

                    case "4":
                        menu.Excluir();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Insira um valor valido.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}

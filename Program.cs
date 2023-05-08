using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Exercício 1
            ConverterDolarParaReal exercicio1 = new ConverterDolarParaReal();
            
            while(true)
            {
                try
                {
                    exercicio1.Ler_cotacao();
                    exercicio1.Ler_valor_em_dolares();
                    break;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            exercicio1.Conversao();
            exercicio1.Exibir_em_reais();
            */

            TrocarLetras exercicio6 = new TrocarLetras();
            exercicio6.Ler_frase();
            exercicio6.Substituir();
            exercicio6.Exibir_frase();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ConverterDolarParaReal
    {
        float cotacao;
        float valor_em_dolares;
        float valor_em_reais;

        public void Ler_cotacao()
        {
            Console.WriteLine("Cotacao:");
            this.cotacao = float.Parse(Console.ReadLine());
        }

        public void Ler_valor_em_dolares()
        {
            Console.WriteLine("Valor em dolar:");
            this.valor_em_dolares = float.Parse(Console.ReadLine());
        }

        public void Conversao()
        {
            this.valor_em_reais = this.cotacao * this.valor_em_dolares;
        }

        public void Exibir_em_reais()
        {
            Console.WriteLine("Valor em real: " + this.valor_em_reais);
        }

        // Getters
        public float Get_cotacao()
        {
            return this.cotacao;
        }

        public float Get_valor_em_dolares()
        {
            return this.valor_em_dolares;
        }

        public float Get_valor_em_reais()
        {
            return this.valor_em_reais;
        }

        public ConverterDolarParaReal()
        {
            this.cotacao = 0;
            this.valor_em_dolares = 0;
            this.valor_em_reais = 0;
        }
    }
}

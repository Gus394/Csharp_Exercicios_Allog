using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TrocarLetras
    {
        string frase;
        StringBuilder Nova_frase;

        public void Ler_frase()
        {
            this.frase = Console.ReadLine();
        }

        public void Substituir()
        {
            for (int i = 0; i < this.frase.Length; i++)
            {
                if (this.frase[i] == 'A' || this.frase[i] == 'a')
                {
                    this.Nova_frase.Append('&');
                }
                else
                {
                    this.Nova_frase.Append(this.frase[i]);
                }
            }
        }

        public void Exibir_frase()
        {
            Console.WriteLine(Nova_frase.ToString());
        }
        
        public TrocarLetras()
        {
            this.frase = "";
            this.Nova_frase = new StringBuilder("");
        }
    }
}

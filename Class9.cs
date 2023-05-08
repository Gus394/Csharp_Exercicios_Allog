using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Class9
    {
        int[] vet;
        int size;
        
        public void Ler_numeros()
        {
            Console.WriteLine("Digite os numeros do array de tamanho " + this.size + ":");
            try
            {
                for (int i = 0; i < this.size; i++)
                {
                    this.vet[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void Imprimir_inverso()
        {
            for (int i = this.size - 1; i > -1; i--)
            {
                Console.WriteLine(vet[i]);
            }
        }

        public Class9(int size)
        {
            this.size = size;
            this.vet = new int[size];
        }
    }
}

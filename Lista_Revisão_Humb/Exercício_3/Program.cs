using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] Quantidades = new int[8, 5];
            string[] DiasSemana = new string[8];
            string[] Pratos = new string[5];
            int[] IndicesMaisVendidos = new int[8];
            

            DiasSemana[0] = "";
            DiasSemana[1] = "Segunda";
            DiasSemana[2] = "Terça";
            DiasSemana[3] = "Quarta";
            DiasSemana[4] = "Quinta";
            DiasSemana[5] = "Sexta";
            DiasSemana[6] = "Sabado";
            DiasSemana[7] = "Domingo";

            Pratos[0] = "";
            Pratos[1] = "Prato 1";
            Pratos[2] = "Prato 2";
            Pratos[3] = "Prato 3";
            Pratos[4] = "Prato 4";

            Console.Clear();

            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if((Quantidades[i, j] == 0) && (i != 0 && j !=0 ))   
                    {
                        Console.Write($"Digite a quantidade vendida do {Pratos[j]} na {DiasSemana[i]}: ");
                        Quantidades[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("");
            }

            Console.Clear();
            

            Console.WriteLine("Quantidades de pratos vendidos:");
            Console.WriteLine();
            string format = "{0,-15}";

            for (int j = 0; j < 5; j++)
            {
                Console.Write(Pratos[j].PadRight(15));
            }

            for (int i = 0; i < 8; i++)
            {
                Console.Write(DiasSemana[i].PadRight(15));
                for (int j = 0; j < 5; j++)
                {
                    if (i != 0 && j !=0)
                    {
                        Console.Write(string.Format(format, Quantidades[i, j]));
                    }                                      
                }           
                Console.WriteLine();
            }


            for (int i = 1; i < 8; i++)
            {
                int MaiorValor = int.MinValue;
                for (int j = 1; j < 5; j++)
                {
                    if (Quantidades[i, j] > MaiorValor)
                    {
                        MaiorValor = Quantidades[i, j];
                        IndicesMaisVendidos[i] = j;
                    }                
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Prato mais popular em cada dia da semana:");
            for (int i = 0; i < 8; i++)
            {
                if (i != 0)
                {
                    int K = IndicesMaisVendidos[i];
                    Console.WriteLine($"{DiasSemana[i].PadRight(10)}{Pratos[K]}");
                }                  
            }

            Console.ReadLine();
        }
    }
}
